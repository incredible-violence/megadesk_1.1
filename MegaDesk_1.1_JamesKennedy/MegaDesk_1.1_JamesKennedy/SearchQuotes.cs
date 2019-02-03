using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_JamesKennedy
{
    public partial class SearchQuotes : Form
    {
        DesktopMaterial mats;

        public SearchQuotes()
        {
            InitializeComponent();
            // list to populate comboBox
            List<DesktopMaterial> MatBoxList = Enum.GetValues(typeof(DesktopMaterial))
                .Cast<DesktopMaterial>().ToList();

            MatComboBox.DataSource = MatBoxList;
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string MaterialSelected = MatComboBox.SelectedItem.ToString();

                using (StreamReader sr = new StreamReader(@"quotes.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        // string[] value = sr.ReadLine().Split(',');
                        if (sr.ReadLine().Contains(MaterialSelected))
                        {
                            // add to output ListView 
                            ResultsView.Columns.Add(sr.ReadLine());
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
