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
    public partial class ClientDialog : Form
    {
        private Client client;

        public string ClientName { get { return NametextBox.Text; } }
        public string Surname { get { return SurnametextBox.Text; } }
        public string Email { get { return EmailtextBox.Text; } }
        public string Phone { get { return PhonetextBox.Text; } }

        public ClientDialog(Client c1)
        {
            client = c1;
            InitializeComponent();
        }

        private void ClientDialog_Load(object sender, EventArgs e)
        {
            if (client!=null)
            {
                NametextBox.Text = client.Name;
                SurnametextBox.Text = client.Surname;
                EmailtextBox.Text = client.Email;
                PhonetextBox.Text = client.Phone;
            }
        }

        private void Okbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
