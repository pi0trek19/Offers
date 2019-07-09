using Offers.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Offers
{
    public partial class ClientDetailsDialog : Form
    {
        private Client client;

        public ClientDetailsDialog(Client c1)
        {
            client = c1;
            InitializeComponent();
        }
        private void BindSOffers()
        {
            bindingSource1.DataSource = client.SentOffers;
            bindingSource1.ResetBindings(true);
            dataGridView1.DataSource = bindingSource1;
        }
        private void ClientDetailsDialog_Load(object sender, EventArgs e)
        {
            BindSOffers();
            label5.Text = client.Name;
            label6.Text = client.Surname;
            label7.Text = client.Email;
            label8.Text = client.Phone;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
