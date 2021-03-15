using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using Ultima;
using UoFiddler.Controls.Classes;

namespace UoFiddler.Controls.Forms
{
    public partial class MapExportJsonForm : Form
    {
        private readonly Map _workingMap;
        public MapExportJsonForm(Map currentMap, int xStart, int yStart, int xEnd, int yEnd)
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

        public void ExportJson(string filename, int xStart, int yStart, int xEnd, int yEnd)
        {
            if (!checkBoxMap.Checked && !checkBoxStatics.Checked)
            {
                MessageBox.Show("Check at least one among Map and Statics to export!", "Checkbox Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                return;
            }

            Close();

            Cursor.Current = Cursors.WaitCursor;
            _workingMap.ExportMapFragment(Options.OutputPath, xStart, yStart, xEnd, yEnd, filename, checkBoxMap.Checked, checkBoxStatics.Checked);
            Cursor.Current = Cursors.Default;
            MessageBox.Show($"Report saved to {Options.OutputPath}", "Saved", MessageBoxButtons.OK,
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
            ExportJson(name, (int)numericUpDownX1.Value, (int)numericUpDownY1.Value, (int)numericUpDownX2.Value, (int)numericUpDownY2.Value);
        }

        bool IsValidPathBeta(String path)
        {
            return path.IndexOfAny(Path.GetInvalidFileNameChars()) == -1;
        }
    }
}
