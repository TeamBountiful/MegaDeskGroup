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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MegaDesk
{
    public partial class DisplayQuotes : Form
    {
        public DeskQuote deskQuote = null;



        public DisplayQuotes(DeskQuote deskQuote)
        {
            InitializeComponent();
            //set DisplayQuotesForm fields to deskQuote.variables

            this.deskQuote = deskQuote;
            this.DisplayOrderDate.Text = deskQuote.OrderDate;
            this.DisplayName.Text = deskQuote.Name;
            this.DisplayWidth.Text = deskQuote.Desk.Width.ToString();
            this.DisplayDepth.Text = deskQuote.Desk.Depth.ToString();
            this.DisplayRushOrder.Text = deskQuote.RushOrder.ToString();
            this.DisplaySurfMat.Text = deskQuote.SurfaceMaterial.ToString();
            this.DisplayDrawers.Text = deskQuote.Desk.NumberofDrawers.ToString();

            string deskQuoteReturn = deskQuote.GetPrice().ToString();
            this.DisplayQuoteTotal.Text = ($"$ {deskQuoteReturn}.00");

        }

        private void DisplayReturnMainButton_Click(object sender, EventArgs e)
        {

            AddNewQuote addNewQuote = (AddNewQuote)Tag;
            addNewQuote.Show();
            Close();
            MainMenuForm mainMenuForm = (MainMenuForm)addNewQuote.Tag;
            mainMenuForm.Show();
            addNewQuote.Close();

        }

        private void SaveQuote(object sender, EventArgs e)
        {
            //JToken existingQuote = quoteArray.FirstOrDefault(q => (string)q["quote"] == "Your quote here");
            string jsonContent = File.ReadAllText("quotes.json");
            //List<> quoteArray = {"OrderDate", "Name", "Witdh", "Depth", "RushOrder", "SurfaceMaterial", "NumberofDrawers", "Price"};
            List<DeskQuote> quoteArray = JsonConvert.DeserializeObject<List<DeskQuote>>(jsonContent);
            quoteArray.Add(deskQuote);
            string updatedJson = quoteArray.ToString();
            File.WriteAllText("quotes.json", updatedJson);

            //StreamReader reader = new StreamReader("quotes.json");
            //string json = reader.ReadToEnd();

            /*string json;
            using (StreamReader reader = new StreamReader("test.json"))
            {
                json = reader.ReadToEnd();
            }
            List<DeskQuote> quotes = JsonConvert.DeserializeObject<List<DeskQuote>>(json);
            quotes.Add(deskQuote);
            string updatedJson = JsonConvert.SerializeObject(quotes);
            File.WriteAllText("quotes.JSON", updatedJson);*/


            
        }
    }
}
