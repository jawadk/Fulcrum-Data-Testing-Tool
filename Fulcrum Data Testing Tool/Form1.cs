using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Fulcrum_Data_Testing_Tool
{
    public partial class DashBorad : Form
    {
        public DashBorad()
        {
            InitializeComponent();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            //fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                txtb_FilePath.Text = fdlg.FileName;
            }
        }

        private void btn_ReadXML_Click(object sender, EventArgs e)
        {
            XmlReader xmlFile ;
            xmlFile = XmlReader.Create(txtb_FilePath.Text, new
            XmlReaderSettings());
            DataSet ds = new DataSet();
            ds.ReadXml(xmlFile);
            int i = 0;
            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                MessageBox.Show(ds.Tables[0].Rows[i].ItemArray[2].ToString());
                
            }



            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(txtb_FilePath.Text);

            MessageBox.Show(CustomMethod.GetMessageID(xDoc));

            XmlTextReader reader = new XmlTextReader(txtb_FilePath.Text);
            XmlNodeType type;

            while (reader.Read())
            {
                type = reader.NodeType;

                if (type == XmlNodeType.Element)
                {
                    //if (reader.IsStartElement("MessageID"))
                    //{
                    //    MessageBox.Show(reader.Value);

                    //}

                    if (reader.Name == "Level1")
                    {
                        reader.Read();
                        MessageBox.Show(reader.Name.ToString());
                        MessageBox.Show(reader.Name + " + " + reader.Value);
                    }

                    if (reader.Name == "Level2")
                    {
                        reader.Read();
                        MessageBox.Show(reader.Value);
                    }

                    if (reader.Name == "CountryCode")
                    {
                        reader.Read();
                        MessageBox.Show(reader.Value);
                    }
                }

                
            }


            
        }
    }
}
