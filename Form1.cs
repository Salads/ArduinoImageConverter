using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace ArduinoImageConverter
{
    public partial class Form1 : Form
    {
        private List<string> m_filenames = new List<string>();
        private List<string> m_safeFilenames = new List<string>();

        public Form1()
        {
            InitializeComponent();
            m_guiFormatComboBox.SelectedIndex = 0;
            m_guiArrayElemSizeComboBox.SelectedIndex = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void selectFilesButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "png images (*.png) | *.png";
                openFileDialog.FilterIndex = 0;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    m_filenames.Clear();
                    m_safeFilenames.Clear();

                    m_filenames.AddRange(openFileDialog.FileNames);
                    m_safeFilenames.AddRange(openFileDialog.SafeFileNames);

                    foreach(string f in m_safeFilenames)
                    {
                        m_guiFileListView.Items.Add(f);
                    }
                }
            }
        }

        private uint RangeMap(uint srcRangeStart, uint srcRangeEnd, uint destRangeStart, uint destRangeEnd, uint srcVal)
        {
            uint srcRange = srcRangeEnd - srcRangeStart; // Same amount of numbers, but starts from zero.
            float srcRangePercent = srcVal / srcRange;

            uint destRange = destRangeEnd - destRangeStart;
            uint newVal = (uint)(destRangeStart + (srcRangePercent * destRange));
            return newVal;
        }

        private string GetArrayTypeString()
        {
            int arrayElemSize = 8;
            string elemType = "const unsigned char";
            if (m_guiArrayElemSizeComboBox.SelectedIndex == 1)
            {
                arrayElemSize = 16;
                elemType = "const unsigned short";
            }
            else if (m_guiArrayElemSizeComboBox.SelectedIndex == 2)
            {
                arrayElemSize = 18;
                elemType = "const unsigned int";
            }

            if(m_guiUseStdIntCheckbox.Checked)
            {
                elemType = string.Format("const uint{0}_t", arrayElemSize);
            }

            return elemType;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void m_guiConvertButton_Click(object sender, EventArgs e)
        {
            m_guiCodeTextBox.Clear();
            bool swapRB = m_guiSwapRBCheckbox.Checked;
            bool useStdInt = m_guiUseStdIntCheckbox.Checked;
            string codeOutput = string.Empty;

            for (int i = 0; i < m_filenames.Count; i++)
            {
                string f = m_filenames[i];

                List<uint> packedColors = new List<uint>();
                Bitmap img = new Bitmap(f);
                uint monoValByte = 0;
                int monoValIdx = 7;
                for (int y = 0; y < img.Height; y++)
                {
                    for (int x = 0; x < img.Width; x++)
                    {
                        Color pixel = img.GetPixel(x, y);
                        
                        byte srcR = pixel.R;
                        byte srcG = pixel.G;
                        byte srcB = pixel.B;
                        uint srcRGB = (uint)((srcR << 16) | (srcG << 8) | (srcB << 0)); // avoid alpha channel screwing with conversions
                        if (swapRB)
                        {
                            byte temp = srcR;
                            srcR = srcB;
                            srcB = temp;
                        }

                        if (m_guiFormatComboBox.SelectedIndex == 0) // monochrome
                        {
                            uint monoVal = (uint)(srcRGB > 0 ? 1 : 0);
                            monoValByte |= monoVal << monoValIdx;
                            monoValIdx--;
                            if(monoValIdx == -1)
                            {
                                packedColors.Add(monoValByte);
                                monoValIdx = 7;
                                monoValByte = 0;
                            }
                            else if(y == img.Height - 1 && x == img.Width - 1)
                            {
                                packedColors.Add(monoValByte);
                            }
                        }
                        else if (m_guiFormatComboBox.SelectedIndex == 1) // (5,6,5), 16 bit
                        {
                            uint r = RangeMap(0, 255, 0, 0b11111, srcR);
                            uint g = RangeMap(0, 255, 0, 0b111111, srcG);
                            uint b = RangeMap(0, 255, 0, 0b11111, srcB);

                            uint val = (uint)(r << 11 | g << 5 | b);
                            packedColors.Add(val);
                        }
                        else if (m_guiFormatComboBox.SelectedIndex == 2) // (6,6,6), 18 bit
                        {
                            uint r = RangeMap(0, 255, 0, 0b111111, srcR);
                            uint g = RangeMap(0, 255, 0, 0b111111, srcG);
                            uint b = RangeMap(0, 255, 0, 0b111111, srcB);

                            uint val = (uint)(r << 12 | g << 6 | b);
                            packedColors.Add(val);
                        }
                    }
                } // END image processing

                // Generate code for single image

                // Generate comment for data array
                codeOutput += string.Format("// {0}: {1}x{2}{3}", 
                    m_safeFilenames[i], img.Width, img.Height, Environment.NewLine);

                // Generate array
                codeOutput += GetArrayTypeString() + " " + Path.GetFileNameWithoutExtension(m_safeFilenames[i]) + " [] PROGMEM = " + Environment.NewLine;
                codeOutput += "{";

                for (int x = 0; x < packedColors.Count; x++)
                {

                    if (x % img.Width == 0)
                    {
                        codeOutput += Environment.NewLine + "\t";
                    }

                    codeOutput += "0b" + Convert.ToString((int)packedColors[x], 2).PadLeft(8, '0');
                    if (x < packedColors.Count - 1)
                    {
                        codeOutput += ", ";
                    }
                }

                codeOutput += Environment.NewLine + "};" + Environment.NewLine;


            } // END filename loop

            // Generate array helper code
            codeOutput += GetArrayTypeString() + "* allArray[] = " + Environment.NewLine;
            codeOutput += "{" + Environment.NewLine;

            for(int x = 0; x < m_safeFilenames.Count; x++)
            {
                codeOutput += "\t";
                codeOutput += Path.GetFileNameWithoutExtension(m_safeFilenames[x]);
                
                if (x < m_safeFilenames.Count - 1)
                {
                    codeOutput += ",";
                }

                codeOutput += Environment.NewLine;
            }

            codeOutput += "};" + Environment.NewLine;

            m_guiCodeTextBox.Text = codeOutput;
        }

        private void OnCopyCodeButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(m_guiCodeTextBox.Text);
        }
    }
}
