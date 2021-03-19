// /***************************************************************************
//  *
//  * $Author: Turley
//  *
//  * "THE BEER-WARE LICENSE"
//  * As long as you retain this notice you can do whatever you want with
//  * this stuff. If we meet some day, and you think this stuff is worth it,
//  * you can buy me a beer in return.
//  *
//  ***************************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace UoFiddler.Controls.Forms
{
    public partial class ExportResourceRegionForm : Form
    {
        public ExportResourceRegionForm(int startX, int startY, int width, int height)
        {
            InitializeComponent();

            StartXTB.Text = startX.ToString();
            StartYTB.Text = startY.ToString();
            WidthTB.Text = width.ToString();
            HeightTB.Text = height.ToString();
        }

        private List<string> ResNames => new List<string>()
        {
            "PiriteNew",
            "AzuriteNew",
            "ValoriumNew",
            "OssidianaNew",
            "MerkiteNew",
            "TitanioNew",
            "IthilmarNew",
            "OrialkonNew",
            "TalavholkNew",
            "AdamantioNew",
            "Bronzo",
            "Rame",
            "Ferro",
            "Oro",
            "Argento",
        };

        private void ExportResourceRegionButton_Click(object sender, EventArgs e)
        {
            var startX = StartXTB.Text;
            var startY = StartYTB.Text;

            var width = WidthTB.Text;
            var height = HeightTB.Text;

            var resources = new List<string>()
            {
                 PiriteTb.Text,
                 AzuriteTb.Text,
                 ValoriumTb.Text,
                 OssidianaTb.Text,
                 MerkiteTb.Text,
                 TitanioTb.Text,
                 IthilmarTb.Text,
                 OrialkonTb.Text,
                 TalavholkTb.Text,
                 AdamantioTb.Text,
                 BronzoTb.Text,
                 RameTb.Text,
                 FerroTb.Text,
                 OroTb.Text,
                 ArgentoTb.Text,
            };

            int total = 0;

            foreach (var res in resources)
            {
                int.TryParse(res, out int resAmount);
                total += resAmount;
            }

            if (total != 1000)
            {
                richTextBox1.Text = "ERROR! SUM != 1000!";
                return;
            }

            var resNameString = new StringBuilder();
            var resQuantitiesString = new StringBuilder();
            var resCount = 0;

            for (int i = 0; i < ResNames.Count; i++)
            {
                if (int.TryParse(resources[i], out int value))
                {
                    if (value == 0)
                    {
                        continue;
                    }
                }
                else
                {
                    continue;
                }
                if (i != 0 && i != ResNames.Count - 1)
                {
                    resNameString.Append(",");
                    resQuantitiesString.Append(",");
                }
                AddResource(ResNames[i], resources[i], ref resNameString, ref resQuantitiesString);
                resCount++;
            }

            //var piriteNum =     PiriteTb.Text;
            //var azuriteNum =    AzuriteTb.Text;
            //var valoriumNum =   ValoriumTb.Text;
            //var ossidianaNum =  OssidianaTb.Text;
            //var merkiteNum =    MerkiteTb.Text;
            //var titanioNum =    TitanioTb.Text;
            //var ithilmarNum =   IthilmarTb.Text;
            //var orialkonNum =   OrialkonTb.Text;
            //var talahvolkNum =  TalavholkTb.Text;
            //var adamantioNum =   AdamantioTb.Text;

            //var bronzoNum =     BronzoTb.Text;
            //var rameNum =       RameTb.Text;
            //var ferroNum =      FerroTb.Text;
            //var oroNum =        OroTb.Text;
            //var argentoNum =    ArgentoTb.Text;

            var regionName = NameTb.Text;
            var priority = PriorityTb.Text;

            var stream = new MemoryStream();
            XmlWriterSettings settings = new XmlWriterSettings { Indent = true, OmitXmlDeclaration = true, ConformanceLevel = ConformanceLevel.Fragment };
            using (XmlWriter writer = XmlWriter.Create(stream, settings))
            {
                writer.WriteStartElement("VeinInfo");
                writer.WriteAttributeString("rect", $"{startX},{startY},{width}, {height}");
                writer.WriteAttributeString("commento", regionName);
                writer.WriteAttributeString("map", "0");
                writer.WriteAttributeString("tipi", $"{resCount}");
                writer.WriteAttributeString("prio", priority);
                writer.WriteAttributeString("risorse", resNameString.ToString());
                writer.WriteAttributeString("quantita", resQuantitiesString.ToString());

                writer.WriteEndElement();
            }

            string strXml = Encoding.UTF8.GetString(stream.ToArray());

            richTextBox1.Text = strXml;

            /*
             * <VeinInfo rect="1004,2820,232,90" map="0" tipi="5"
             * risorse="Bronzo,Ferro,Rame,Argento,Ithilmar"
             * quantita="460,340,150,40,10"
             * commento="Interno Montagne Ceoris S" prio="5" />

             * */
        }

        private void AddResource(string resName, string resAmount, ref StringBuilder resNameString, ref StringBuilder resQuantitiesString)
        {
            resNameString.Append(resName);
            resQuantitiesString.Append(resAmount);
        }
    }
}