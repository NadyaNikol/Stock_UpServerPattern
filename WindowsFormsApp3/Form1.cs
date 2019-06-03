using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        Stock stock = new Stock();
        Random random = new Random();

        List<Client> clients = new List<Client>();
        public Form1()
        {
            InitializeComponent();

            timer.Interval = 10000;
            timer.Tick += Timer_Tick;
            timer.Start();

            comboBox1.DataSource = clients;
            comboBox1.DisplayMember = "Login";

        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            stock.BTCCource = random.Next(8000, 8600);
            stock.Notify();
            labelCourceBTC.Text = stock.BTCCource.ToString();
            ShowClientInfo();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            double temp = 0;
            if (String.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Вы должны ввести имя");
            }


            Client client = new Client();
            client.Login = textBoxName.Text;
            if (double.TryParse(textBoxBTC.Text, out temp))
            {
                client.BTC = temp;
            }
            else 
            {
                MessageBox.Show("Вы должны ввести сумму BTC");
            }



            if (double.TryParse(textBoxUSD.Text, out temp))
            {
                client.USD = temp;
            }
            else
            {
                MessageBox.Show("Вы должны ввести сумму USD");
            }



            if (double.TryParse(textboxCourceForBuy.Text, out temp))
            {
                client.CourceForBuy = temp;
            }
            else
            {
                MessageBox.Show("Вы должны ввести курс для покупки");
            }


            if (double.TryParse(textboxCourceForSell.Text, out temp))
            {
                client.CourceForSell = temp;
            }
            else
            {
                MessageBox.Show("Вы должны ввести курс для продажи");
            }


            if (double.TryParse(textBoxSummForBuy.Text, out temp))
            {
                client.SumForBuy = temp;
            }
            else
            {
                MessageBox.Show("Вы должны ввести сумму для покупки");
            }

            if (double.TryParse(textBoxSummForSell.Text, out temp))
            {
                client.SumForSell = temp;
            }
            else
            {
                MessageBox.Show("Вы должны ввести сумму для продажи");
            }


            clients.Add(client);
            stock.AddObserable(client);
            UpdateBinding();

        }


        void UpdateBinding()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = clients;
            comboBox1.DisplayMember = "Login";// отображение свойства

        }

        void ShowClientInfo()
        {
            if (comboBox1.SelectedIndex !=-1)
            {
                Client client = comboBox1.SelectedItem as Client;
                textBoxName.Text = client.Login;

                textBoxBTC.Text = client.BTC.ToString();
                textboxCourceForBuy.Text = client.CourceForBuy.ToString();
                textboxCourceForSell.Text = client.CourceForSell.ToString();
                textBoxSummForBuy.Text = client.SumForBuy.ToString();
                textBoxSummForSell.Text = client.SumForSell.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowClientInfo();
        }
    }
}
