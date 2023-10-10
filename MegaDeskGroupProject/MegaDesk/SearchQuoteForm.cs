using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk
{
    public partial class SearchQuoteForm : Form
    {
        readonly string filePath = "quotes.json";
        public List<DeskQuote> quotes;
        public List<DeskQuote> filteredQuotes;
        public SearchQuoteForm()
        {
            InitializeComponent();
            FillQuotes();
        }

        private void SearchReturnButton_Click(object sender, EventArgs e)
        {
            MainMenuForm viewMainMenuForm = (MainMenuForm)Tag;
            viewMainMenuForm.Show();
            Close();

        }

        private void FillQuotes()
        {
            string jsonSaves = File.ReadAllText(filePath);
            quotes = System.Text.Json.JsonSerializer.Deserialize<List<DeskQuote>>(jsonSaves);
            searchQuotes.DataSource = quotes;

        }

        private void filter_Click(object sender, EventArgs e)
        {
            string jsonSaves = File.ReadAllText(filePath);
            quotes = System.Text.Json.JsonSerializer.Deserialize<List<DeskQuote>>(jsonSaves);
            filteredQuotes = (quotes.FindAll(quote => quote.Desk.SurfaceMaterial.ToString() == materialFilterPicker.SelectedItem.ToString()));
            searchQuotes.DataSource = filteredQuotes;
        }
    }
}
