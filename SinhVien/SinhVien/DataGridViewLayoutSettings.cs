using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SinhVien
{
    public static class DataGridViewLayoutSettings
    {
        public static void ReadDataGridViewSettings(DataGridView dgv)
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlNodeList xmlnode;
            FileStream fs = new FileStream(Application.StartupPath+@"\MyGrid.xml",FileMode.Open
                ,FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("column");
            for(int i = 0; i <= xmlnode.Count-1; i++)
            {
                string columnname = xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                int width = int.Parse(xmlnode[i].ChildNodes.Item(1).InnerText.Trim());
                string headerText = xmlnode[i].ChildNodes.Item(2).InnerText.Trim();
                int displayIndex = int.Parse(xmlnode[i].ChildNodes.Item(3).InnerText.Trim());
                Boolean visible = Convert.ToBoolean(xmlnode[i].ChildNodes.Item(4).InnerText.Trim());
                dgv.Columns[columnname].Width = width;
                dgv.Columns[columnname].HeaderText = headerText;
                dgv.Columns[columnname ].DisplayIndex = displayIndex;
                dgv.Columns[columnname].Visible = visible;
            }
            fs.Close();
        }

        public static void WriteDataGridViewSettings(DataGridView dgv)
        {
            XmlTextWriter writer = new XmlTextWriter(Application.StartupPath+ @"\MyGrid.xml",null);
            writer.WriteStartDocument();
            writer.WriteStartElement(dgv.Name);
            int count = dgv.Columns.Count;
            for(int i = 0; i < count; i++)
            {
                writer.WriteStartElement("column");
                writer.WriteStartElement("Name");
                writer.WriteString(dgv.Columns[i].Name);  
                writer.WriteEndElement();
                writer.WriteStartElement("width");
                writer.WriteEndElement();
                writer.WriteStartElement("headerText");
                writer.WriteString(dgv.Columns[i].HeaderText);
                writer.WriteEndElement();
                writer.WriteStartElement("displayIndex");
                writer.WriteString(dgv.Columns[i].DisplayIndex.ToString());
                writer.WriteEndElement();
                writer.WriteStartElement("visible");
                writer.WriteString(dgv.Columns[i].Visible.ToString());
                writer.WriteEndElement();
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();

        }
    }
}
