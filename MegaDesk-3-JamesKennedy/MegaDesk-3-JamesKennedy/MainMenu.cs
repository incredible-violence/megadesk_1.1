using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_JamesKennedy
{
    public partial class MainMenu : Form
    {
        // KeyedCollection<int, DeskQuote> quotes;
        // public List<DeskQuote> quotes = new List<DeskQuote>();

        public int QuoteNumber { get; set; }

        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addNewQuote_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void viewQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotesForm = new ViewAllQuotes();
            viewAllQuotesForm.Tag = this;
            viewAllQuotesForm.Show(this);
            Hide();
        }

        private void searchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes searchAllQuotes = new SearchQuotes();
            searchAllQuotes.Tag = this;
            searchAllQuotes.Show(this);
            Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
