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
    public partial class AddNewOfferDialog : Form
    {
        private List<Car> Cars;
        private List<Offer> Offers;
        private Offer Offer;
        private Car car;

        public int Months { get { return (int)MonthsnumericUpDown.Value; } }
        public decimal Fee { get { return RatenumericUpDown.Value; } }
        public decimal Begin { get { return BeginnumericUpDown.Value; } }
        public decimal End { get { return EndnumericUpDown.Value; } }
        public int Milage { get { return (int)MilagenumericUpDown.Value; } }
        public Car NewCar { get { return car; } }
        
        public AddNewOfferDialog(List<Car> cars,List<Offer> offers, Offer offer)
        {
            this.Offer = offer;
            this.Offers = offers;
            this.Cars = cars;
            InitializeComponent();
        }

        private void AddNewOfferDialog_Load(object sender, EventArgs e)
        {
            ListradioButton.Checked = true;
            NewCarradioButton.Checked = false;
            CarRegcomboBox.DataSource = Cars;
            CarRegcomboBox.DisplayMember = "RegNo";
            CarRegcomboBox.DropDownStyle = ComboBoxStyle.DropDown;
            CarRegcomboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CarRegcomboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            LoadCarData();

            if (Offer!=null)
            {
                MonthsnumericUpDown.Value = Offer.NoMonths;
                RatenumericUpDown.Value = Offer.MonthlyFee;
                BeginnumericUpDown.Value = Offer.StartPayment;
                EndnumericUpDown.Value = Offer.EndPayment;
                MilagenumericUpDown.Value = Offer.MonthlyMilage;
            }
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (NewCarradioButton.Checked)
            {
                car = new Car(CarRegtextBox.Text, MaketextBox.Text, ModeltextBox.Text, ColourtextBox.Text);
            }
            else
            {
                car = new Car(CarRegcomboBox.Text, MaketextBox.Text, ModeltextBox.Text, ColourtextBox.Text);
            }
            
            DialogResult = DialogResult.OK;                                
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ListradioButton_CheckedChanged(object sender, EventArgs e)
        {
            CarRegtextBox.Enabled = !CarRegtextBox.Enabled;
            LoadCarData();
        }

        private void NewCarradioButton_CheckedChanged(object sender, EventArgs e)
        {
            CarRegcomboBox.Enabled = !CarRegcomboBox.Enabled;
            MaketextBox.Text = "";
            ModeltextBox.Text = "";
            ColourtextBox.Text = "";
        }
        private void LoadCarData()
        {          
            Car c1 = (Car)CarRegcomboBox.SelectedItem;
            if (c1!=null)
            {
                MaketextBox.Text = c1.Make;
                ModeltextBox.Text = c1.Model;
                ColourtextBox.Text = c1.Colour;
            }
        }
        private void CarRegcomboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadCarData();
        }
    }
}
