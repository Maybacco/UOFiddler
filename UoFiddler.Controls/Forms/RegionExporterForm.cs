using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using UoFiddler.Controls.Classes;

namespace UoFiddler.Controls.Forms
{
    public partial class RegionExporterForm : Form
    {
        private readonly List<RegionRectangleInfo> _rectangles;

        public RegionExporterForm()
        {
            InitializeComponent();
        }

        public RegionExporterForm(List<RegionRectangleInfo> rectangles) : this()
        {
            _rectangles = rectangles;
            RectanglesTb.Text = $"{rectangles.Count}";
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            var stream = new MemoryStream();
            XmlWriterSettings settings = new XmlWriterSettings { Indent = true };
            using (XmlWriter writer = XmlWriter.Create(stream, settings))
            {

                writer.WriteStartElement("region");
                writer.WriteAttributeString("priority", RegionPriorityTb.Text);
                writer.WriteAttributeString("name", RegionNameTb.Text);
                foreach (var rect in _rectangles)
                {
                    writer.WriteStartElement("rect");
                    writer.WriteAttributeString("x", rect.StartX.ToString());
                    writer.WriteAttributeString("y", rect.StartY.ToString());
                    writer.WriteAttributeString("width", $"{rect.EndX - rect.StartX}");
                    writer.WriteAttributeString("height", $"{rect.EndY - rect.StartY}");
                    writer.WriteEndElement();
                }

                writer.WriteStartElement("music");
                writer.WriteAttributeString("name", RegionMusicTb.Text);
                writer.WriteEndElement();

                writer.WriteEndElement();

            }
            string strXml = Encoding.UTF8.GetString(stream.ToArray());

            richTextBox1.Text = strXml;
        }
    }
}