using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace UoFiddler.Controls.Forms
{
    public partial class RegionExporterForm : Form
    {
        private readonly List<Rectangle> _rectangles;

        public RegionExporterForm()
        {
            InitializeComponent();
        }

        public RegionExporterForm(List<Rectangle> rectangles) : this()
        {
            _rectangles = rectangles;
            RectanglesTb.Text = $"{rectangles.Count}";
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            var stream = new MemoryStream();
            using (XmlWriter writer = XmlWriter.Create(stream))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("region");
                writer.WriteAttributeString("priority", RegionPriorityTb.Text);
                writer.WriteAttributeString("name", RegionNameTb.Text);
                foreach (Rectangle rect in _rectangles)
                {
                    writer.WriteStartElement("rect");
                    writer.WriteAttributeString("x", rect.X.ToString());
                    writer.WriteAttributeString("y", rect.Y.ToString());
                    writer.WriteAttributeString("width", rect.Width.ToString());
                    writer.WriteAttributeString("heigth", rect.Height.ToString());
                    writer.WriteEndElement();
                }

                writer.WriteStartElement("music");
                writer.WriteAttributeString("name", RegionMusicTb.Text);
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
            string strXml = Encoding.UTF8.GetString(stream.ToArray());

            richTextBox1.Text = strXml;
        }
    }
}