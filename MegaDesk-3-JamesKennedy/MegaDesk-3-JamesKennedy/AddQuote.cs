using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_JamesKennedy
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void cancelAddQuote_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            // get input from various boxes
            int width = int.Parse(widthBox.Text);
            int depth = int.Parse(depthBox.Text);
            int drawers = int.Parse(drawerBox.Text);
            string mats = materialBox.Text;
            int rushD = int.Parse(rushBox.Text);
            string customer = customerBox.Text;

            // plug into DeskQuote object
            DeskQuote quote = new DeskQuote(width, depth, drawers, mats, rushD, customer);

            // add quote to list and return to main menu
            var mainMenu = (MainMenu)Tag;
            // mainMenu.quotes.Add(quote);
            mainMenu.Show();
            Close();
        }

        private void widthBox_Validating(object sender, CancelEventArgs e)
        {
            int width = int.Parse(widthBox.Text);

            // error checking logic
            if (width > Desk.MAXWIDTH)
            {
                widthBox.Text = "";
                MessageBox.Show("Maximum Width: " + Desk.MAXWIDTH, "DIMENSION ERROR", MessageBoxButtons.OK);       
            }
            else if ( width < Desk.MINWIDTH)
            {
                widthBox.Text = "";
                MessageBox.Show("Minimum Width: " + Desk.MINWIDTH, "DIMENSION ERROR", MessageBoxButtons.OK);
        
            }
        }

        private void depthBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // error checking logic
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Invalid Characters", "TYPE ERROR", MessageBoxButtons.OK);
                depthBox.Text = "";
            }
        }
    }
}
