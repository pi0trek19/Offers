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
        
        private void Form1_Load(object sender, EventArgs e)
        {

            var bindingList1 = new BindingList<Offer>(document.OffersList);
            var source1 = new BindingSource(bindingList1, null);
            dataGridView1.DataSource = source1;


            var bindingList2 = new BindingList<Offer>(document.OffersList);
            var source2 = new BindingSource(bindingList2, null);
            dataGridView2.DataSource = source2;

        }
    }
}
