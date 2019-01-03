using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AlpacaMarketTesting___Paper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Alpaca.Markets.RestClient Client = new Alpaca.Markets.RestClient("PKKRRSRMHXLDU4HF9VCC", "Tl27vcracryyxlL0DFExvJcgTarl/UjaLqmlSSFt", "https://paper-api.alpaca.markets");
        async Task ClockTestAsync()
        {           

            var Clock = await Client.GetClockAsync();

            if(Clock != null)
            {
                TimeLabel.Text = string.Format("TimeStamp : {0}, NextOpen : {1}, NextClose : {2}", Clock.Timestamp, Clock.NextOpen, Clock.NextClose);
            }

        }

        private void GetTimeBttn_Click(object sender, EventArgs e)
        {
            ClockTestAsync();
        }

        private void AccntBttn_Click(object sender, EventArgs e)
        {
            AccntInfoTestAsync();
        }

        async Task AccntInfoTestAsync()
        {

            var AccountInfo = await Client.GetAccountAsync();

            if (AccountInfo != null)
            {
                AccntLabel.Text = AccountInfo.Status + " - $" + AccountInfo.PortfolioValue;
            }
        }
    }
}
