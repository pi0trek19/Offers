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
            clientBindingSource.DataSource = document.ClientsList;
            clientBindingSource.ResetBindings(true);
            dataGridView2.DataSource = clientBindingSource;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].ReadOnly = false;
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
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nie wybrano pozycji", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
