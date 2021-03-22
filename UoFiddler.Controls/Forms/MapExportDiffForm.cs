using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using Ultima;
using UoFiddler.Controls.Classes;

namespace UoFiddler.Controls.Forms
{
    public partial class MapExportDiffForm : Form
    {
        private readonly Map _workingMap;
        public MapExportDiffForm(Map currentMap, int xStart, int yStart, int xEnd, int yEnd)
        {
            InitializeComponent();
            Icon = Options.GetFiddlerIcon();
            _workingMap = currentMap;
            numericUpDownX1.Maximum = _workingMap.Width-1;
            numericUpDownX1.Value = xStart;

            numericUpDownX2.Maximum = _workingMap.Width-1;
            numericUpDownX2.Value = xEnd;

            numericUpDownY1.Maximum = _workingMap.Height-1;
            numericUpDownY1.Value = yStart;

            numericUpDownY2.Maximum = _workingMap.Height-1;
            numericUpDownY2.Value = yEnd;
        }

        public void ExportDiff(string filename, int xStart, int yStart, int xEnd, int yEnd)
        {
            if (!checkBoxMap.Checked && !checkBoxStatics.Checked)
            {
                MessageBox.Show("Check at least one among Map and Statics to export!", "Checkbox Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                return;
            }

            //string tempPath = Path.Combine(Options.OutputPath, $"{filename}{DateTime.Now.ToString("yyyyMMddHHmmss")}");

            string outputPath = Path.Combine(Options.OutputPath, $"{filename}.tbtdiff");
            if (File.Exists(outputPath))
            {
                MessageBox.Show("Diff Package already exists! You have to change the name of the file to export!", "Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                return;
            }

            //Directory.CreateDirectory(tempPath);

            int blockXStart = xStart >> 3;
            int blockXEnd = xEnd >> 3;
            int blockYStart = yStart >> 3;
            int blockYEnd = yEnd >> 3;

            byte mode = (byte)(Convert.ToByte(checkBoxMap.Checked) + Convert.ToByte(checkBoxStatics.Checked)*2);
            //1 = Map only
            //2 = Statics only
            //3 = Bot Map and Statics

            string diff = Path.Combine(Options.OutputPath, $"{filename}.tbtdiff");
            using (FileStream fsDiff = new FileStream(diff, FileMode.Create, FileAccess.Write, FileShare.Write))
            using (BinaryWriter binDiff = new BinaryWriter(fsDiff))
            {
                int blockWidth = _workingMap.Tiles.BlockWidth;
                int blockHeight = _workingMap.Tiles.BlockHeight;
                binDiff.Write(blockWidth);
                binDiff.Write(blockHeight);

                binDiff.Write(mode);
                if ((mode & 1) == 1)
                {
                    for (int blockX = blockXStart; blockX <= blockXEnd; blockX++)
                    {
                        for (int blockY = blockYStart; blockY <= blockYEnd; blockY++)
                        {
                            int block = blockX * _workingMap.Tiles.BlockHeight + blockY;
                            binDiff.Write(block);

                            Tile[] mapBlock = _workingMap.Tiles.GetLandBlock(blockX, blockY);
                            foreach (Tile tile in mapBlock)
                            {
                                binDiff.Write(tile.Id);
                                binDiff.Write(tile.Z);
                            }
                        }
                    }
                    binDiff.Write(-1);
                }
                if ((mode & 2) == 2)
                {
                    for (int blockX = blockXStart; blockX <= blockXEnd; blockX++)
                    {
                        for (int blockY = blockYStart; blockY <= blockYEnd; blockY++)
                        {
                            int block = blockX * _workingMap.Tiles.BlockHeight + blockY;
                            binDiff.Write(block);

                            HuedTile[][][] staBlock = _workingMap.Tiles.GetStaticBlock(blockX, blockY);

                            for (byte x = 0; x < 8; x++)
                            {
                                for (byte y = 0; y < 8; y++)
                                {
                                    binDiff.Write(staBlock[x][y].Length);
                                    foreach (HuedTile huedTile in staBlock[x][y])
                                    {
                                        binDiff.Write(huedTile.Id);
                                        binDiff.Write(huedTile.Z);
                                        binDiff.Write((ushort)huedTile.Hue);
                                    }
                                }
                            }
                        }
                    }
                    binDiff.Write(-1);
                }
            }
        
            MessageBox.Show($"TbtDiff Patch saved at: {outputPath}", "Saved", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            if (string.IsNullOrEmpty(name) || !IsValidPathBeta(name))
            {
                MessageBox.Show($"Invalid file name! A filename cannot contain any of the following characters: {Path.GetInvalidFileNameChars().ToString()}", "Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                return;
            }
            ExportDiff(name, (int)numericUpDownX1.Value, (int)numericUpDownY1.Value, (int)numericUpDownX2.Value, (int)numericUpDownY2.Value);
        }

        bool IsValidPathBeta(String path)
        {
            return path.IndexOfAny(Path.GetInvalidFileNameChars()) == -1;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(this, new EventArgs());
            }
        }
    }
}
