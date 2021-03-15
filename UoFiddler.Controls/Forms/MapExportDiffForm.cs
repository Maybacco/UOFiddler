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
            numericUpDownX1.Maximum = _workingMap.Width;
            numericUpDownX1.Value = xStart;

            numericUpDownX2.Maximum = _workingMap.Width;
            numericUpDownX2.Value = xEnd;

            numericUpDownY1.Maximum = _workingMap.Height;
            numericUpDownY1.Value = yStart;

            numericUpDownY2.Maximum = _workingMap.Height;
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

            string tempPath = Path.Combine(Options.OutputPath, $"{filename}{DateTime.Now.ToString("yyyyMMddHHmmss")}");

            string zipPath = Path.Combine(Options.OutputPath, $"{filename}.tbtdiff");
            if (File.Exists(zipPath))
            {
                MessageBox.Show("Diff Package already exists! You have to change the name of the file to export!", "Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                return;
            }

            Directory.CreateDirectory(tempPath);

            int chunkXStart = xStart >> 3;
            int chunkXEnd = xEnd >> 3;
            int chunkYStart = yStart >> 3;
            int chunkYEnd = yEnd >> 3;

            if (checkBoxMap.Checked)
            {
                string mapIdx = Path.Combine(tempPath, $"mapdifl{_workingMap.FileIndex}.mul");
                FileStream fsMapIdx = new FileStream(mapIdx, FileMode.Create, FileAccess.Write, FileShare.Write);
                BinaryWriter binMapIdx = new BinaryWriter(fsMapIdx);

                string mapMul = Path.Combine(tempPath, $"mapdif{_workingMap.FileIndex}.mul");
                FileStream fsMapMul = new FileStream(mapMul, FileMode.Create, FileAccess.Write, FileShare.Write);
                BinaryWriter binMapMul = new BinaryWriter(fsMapMul);

                for (int chunkY = chunkYStart; chunkY <= chunkYEnd; chunkY++)
                {
                    for (int chunkX = chunkXStart; chunkX <= chunkXEnd; chunkX++)
                    {
                        int blockId = chunkX * _workingMap.Tiles.BlockHeight + chunkY;
                        binMapIdx.Write(blockId);

                        fsMapMul.Seek(4, SeekOrigin.Current);

                        Tile[] mapBlock = _workingMap.Tiles.GetLandBlock(chunkX, chunkY);
                        foreach (Tile tile in mapBlock)
                        {
                            binMapMul.Write(tile.Id);
                            binMapMul.Write(tile.Z);
                        }
                    }
                }
                fsMapIdx.Close();
                fsMapMul.Close();
            }

            if (checkBoxStatics.Checked)
            {
                string staIdx = Path.Combine(tempPath, $"stadifl{_workingMap.FileIndex}.mul");
                FileStream fsStaIdx = new FileStream(staIdx, FileMode.Create, FileAccess.Write, FileShare.Write);
                BinaryWriter binStaIdx = new BinaryWriter(fsStaIdx);

                string staLookup = Path.Combine(tempPath, $"stadifi{_workingMap.FileIndex}.mul");
                FileStream fsStaLookup = new FileStream(staLookup, FileMode.Create, FileAccess.Write, FileShare.Write);
                BinaryWriter binStaLookup = new BinaryWriter(fsStaLookup);

                string staMul = Path.Combine(tempPath, $"stadif{_workingMap.FileIndex}.mul");
                FileStream fsStaMul = new FileStream(staMul, FileMode.Create, FileAccess.Write, FileShare.Write);
                BinaryWriter binStaMul = new BinaryWriter(fsStaMul);

                int offset = 0;
                for (int chunkY = chunkYStart; chunkY <= chunkYEnd; chunkY++)
                {
                    for (int chunkX = chunkXStart; chunkX <= chunkXEnd; chunkX++)
                    {
                        int blockId = chunkX * _workingMap.Tiles.BlockHeight + chunkY;
                        binStaIdx.Write(blockId);

                        fsStaMul.Seek(offset, SeekOrigin.Begin);

                        HuedTile[][][] staBlock = _workingMap.Tiles.GetStaticBlock(chunkX, chunkY);

                        int length = 0;
                        for (byte y = 0; y < 8; y++)
                        {
                            for (byte x = 0; x < 8; x++)
                            {
                                foreach (HuedTile huedTile in staBlock[x][y])
                                {
                                    binStaMul.Write(huedTile.Id);
                                    binStaMul.Write(x);
                                    binStaMul.Write(y);
                                    binStaMul.Write(huedTile.Z);
                                    binStaMul.Write((short)huedTile.Hue);
                                    length += 7;
                                }
                            }
                        }
                        binStaLookup.Write(offset);
                        binStaLookup.Write(length);
                        binStaLookup.Write(-1);
                        offset += length;
                    }
                }
                fsStaIdx.Close();
                fsStaLookup.Close();
                fsStaMul.Close();
            }
            
            ZipFile.CreateFromDirectory(tempPath, zipPath);
            Directory.Delete(tempPath,true);

            MessageBox.Show($"Diff Package saved at: {zipPath}", "Saved", MessageBoxButtons.OK,
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
    }
}
