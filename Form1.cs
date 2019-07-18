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
    public partial class Form1 : Form
    {
        Document document = new Document();
        public Form1()
        {
            InitializeComponent();
        }
        private void BindOffers()
        {
            dataGridView1.Columns[0].ReadOnly = false;
            offerBindingSource.DataSource = document.OffersList;
            offerBindingSource.ResetBindings(true);
            dataGridView1.DataSource = offerBindingSource;
        }
        private void BindClients()
        {
            dataGridView2.Columns[0].ReadOnly = false;
            clientBindingSource.DataSource = document.ClientsList;
            clientBindingSource.ResetBindings(true);
            dataGridView2.DataSource = clientBindingSource;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BindOffers();
            BindClients();
        }

        private void NewOfferbutton_Click(object sender, EventArgs e)
        {
            AddNewOfferDialog newOfferDialog = new AddNewOfferDialog(document.CarsList, document.OffersList, null);
            if (newOfferDialog.ShowDialog()==DialogResult.OK)
            {
                AddCarToList(newOfferDialog.NewCar);
                Offer off = new Offer(newOfferDialog.NewCar, newOfferDialog.Months, newOfferDialog.Fee, 
                    newOfferDialog.Begin, newOfferDialog.End, newOfferDialog.Milage);
                document.OffersList.Add(off);
                BindOffers();
            }
        }

        private void AddCarToList(Car c1)
        {
            foreach (Car car in document.CarsList)
            {
                if (c1.Equals(car))
                {
                    return;
                }
            }
            document.CarsList.Add(c1);
        }

        private void EditOfferbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Offer offer1 = (Offer)dataGridView1.SelectedRows[0].DataBoundItem;
                
                AddNewOfferDialog newOfferDialog = new AddNewOfferDialog(document.CarsList, document.OffersList, offer1);
                if (newOfferDialog.ShowDialog() == DialogResult.OK)
                {
                    AddCarToList(newOfferDialog.NewCar);
                    offer1.RentCar = newOfferDialog.NewCar;
                    offer1.MonthlyFee = newOfferDialog.Fee;
                    offer1.MonthlyMilage = newOfferDialog.Milage;
                    offer1.NoMonths = newOfferDialog.Months;
                    offer1.StartPayment = newOfferDialog.Begin;
                    offer1.EndPayment = newOfferDialog.End;
                    offer1.CarReg = offer1.RentCar.RegNo;
                    BindOffers();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nie wybrano pozycji", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void UsuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Offer offer1 = (Offer)dataGridView1.SelectedRows[0].DataBoundItem;
                
                if (MessageBox.Show("Czy chcesz usunąć pozycję", "Uwaga", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    document.OffersList.Remove(offer1);
                }
 
            }
            catch (Exception)
            {
                MessageBox.Show("Nie wybrano pozycji", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewClientbutton_Click(object sender, EventArgs e)
        {
            ClientDialog dialog = new ClientDialog(null);
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                Client c1 = new Client(dialog.Email, dialog.ClientName, dialog.Surname, dialog.Phone);
                if (isClientOnList(c1))
                {
                    MessageBox.Show("Klient o podanym adresie email/telefonie znajduje się na liście", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                document.ClientsList.Add(c1);
                BindClients();
            }
        }
        private bool isClientOnList(Client c1)
        {
            foreach (Client client in document.ClientsList)
            {
                if (c1.Equals(client))
                {
                    return true;
                }
            }
            return false;
        }

        private void EditClientbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = (Client)dataGridView2.SelectedRows[0].DataBoundItem;
                ClientDialog dialog = new ClientDialog(client);
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    client.Name = dialog.ClientName;
                    client.Surname = dialog.Surname;
                    client.Email = dialog.Email;
                    client.Phone = dialog.Phone;
                    BindClients();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nie wybrano pozycji", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }

        private void UsuńToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = (Client)dataGridView2.SelectedRows[0].DataBoundItem;

                if (MessageBox.Show("Czy chcesz usunąć pozycję", "Uwaga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    document.ClientsList.Remove(client);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Nie wybrano pozycji", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SzczegółyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = (Client)dataGridView2.SelectedRows[0].DataBoundItem;
                ClientDetailsDialog dialog = new ClientDetailsDialog(client);
                dialog.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Nie wybrano pozycji", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendOffersbutton_Click(object sender, EventArgs e)
        {
            List<Offer> offers = new List<Offer>();
            List<Client> clients = new List<Client>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells[0] as DataGridViewCheckBoxCell;
                if (cell.Value != null)
                {
                    if (Convert.ToBoolean(cell.Value) == true)
                    {                        
                        Offer o1 = (Offer)row.DataBoundItem;
                        offers.Add(o1);
                    }
                }
            }
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells[0] as DataGridViewCheckBoxCell;
                if (cell.Value != null)
                {
                    if (Convert.ToBoolean(cell.Value) == true)
                    {
                        Client c1 = (Client)row.DataBoundItem;
                        clients.Add(c1);
                    }
                }
            }
            

        }
    }
}
