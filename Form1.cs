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
           // offerBindingSource.DataSource = document.OffersList;
           // offerBindingSource.ResetBindings(true);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //BindOffers();
            //dataGridView2.DataSource = document.ClientsList;

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
                //BindOffers();
            }
        }

        private void AddCarToList(Car c1)
        {
            foreach (Car car in document.CarsList)
            {
                if (ReferenceEquals(car,c1))
                {
                    return;
                }
            }
            document.CarsList.Add(c1);
        }
    }
}
