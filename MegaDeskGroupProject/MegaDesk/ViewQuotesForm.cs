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
using Newtonsoft.Json;

namespace MegaDesk
{
    public partial class ViewQuotesForm : Form
    {
        //file is the name of the json file of saved quotes.
        //quotes will be the list of quotes as class objects
        readonly string filePath = "quotes.json";
        public List<DeskQuote> quotes;
        public ViewQuotesForm()
        {
            InitializeComponent();
            if (File.Exists(filePath))
            {
              FillQuotes();
            }
            else
            {
              MessageBox.Show("Save file could not be found");
            }
        }
        private void FillQuotes()
        {
            string jsonSaves = File.ReadAllText(filePath);
            quotes = JsonConvert.DeserializeObject<List<DeskQuote>>(jsonSaves);            
            viewQuotes.DataSource = quotes;

        }
        private void ReturnToHomeFromView_Click(object sender, EventArgs e)
        {
            MainMenuForm viewMainMenuForm = (MainMenuForm)Tag;
            viewMainMenuForm.Show();
            Close();

        }

        private void ViewQuotesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
