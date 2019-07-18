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
    public partial class SendOffersDialog : Form
    {
        private List<Client> clients;
        private List<Offer> offers;
        public SendOffersDialog(List<Client> clList, List<Offer> ofList)
        {
            this.clients = clList;
            this.offers = ofList;
            InitializeComponent();
        }

        private void DrawTabControlOffers()
        {
            OfferstabControl.SuspendLayout();
            foreach (var offer in offers)
            {
                TabPage tp = new TabPage(offer.CarReg + " " + offer.MonthlyMilage);
                TableLayoutPanel layoutPanel = new TableLayoutPanel();
                layoutPanel.Dock = DockStyle.Fill;
                layoutPanel.RowCount = 6;
                layoutPanel.ColumnCount = 1;
                Label l1 = new Label();
                l1.Dock = DockStyle.Fill;
                l1.TextAlign = ContentAlignment.MiddleCenter;
                l1.Text = "Nr rej. "+offer.CarReg;

                Label l2 = new Label();
                l2.Dock = DockStyle.Fill;
                l2.TextAlign = ContentAlignment.MiddleCenter;
                l2.Text = "Ilość msc. " + offer.NoMonths.ToString();

                Label l3 = new Label();
                l3.Dock = DockStyle.Fill;
                l3.TextAlign = ContentAlignment.MiddleCenter;
                l3.Text = "Opłata wstępna " + offer.StartPayment.ToString();

                Label l4 = new Label();
                l4.Dock = DockStyle.Fill;
                l4.TextAlign = ContentAlignment.MiddleCenter;
                l4.Text = "Stawka msc. " + offer.MonthlyFee.ToString();

                Label l5 = new Label();
                l5.Dock = DockStyle.Fill;
                l5.TextAlign = ContentAlignment.MiddleCenter;
                l5.Text = "Przebieg msc. " + offer.MonthlyMilage.ToString();

                Label l6 = new Label();
                l6.Dock = DockStyle.Fill;
                l6.TextAlign = ContentAlignment.MiddleCenter;
                l6.Text = "Wykup " + offer.EndPayment.ToString();

                layoutPanel.Controls.Add(l1, 0, 0);
                layoutPanel.Controls.Add(l2, 0, 1);
                layoutPanel.Controls.Add(l3, 0, 2);
                layoutPanel.Controls.Add(l4, 0, 3);
                layoutPanel.Controls.Add(l5, 0, 4);
                layoutPanel.Controls.Add(l6, 0, 5);
                tp.Controls.Add(layoutPanel);
                OfferstabControl.TabPages.Add(tp);
            }
            OfferstabControl.ResumeLayout();
            OfferstabControl.Refresh();
            
        }

        private void DrawTabControlClients()
        {
            foreach (var client in clients)
            {
                TabPage tp = new TabPage(client.Surname);
                TableLayoutPanel layoutPanel = new TableLayoutPanel();
                layoutPanel.Dock = DockStyle.Fill;
                layoutPanel.RowCount = 4;
                layoutPanel.ColumnCount = 1;
                Label l1 = new Label();
                l1.Dock = DockStyle.Fill;
                l1.TextAlign = ContentAlignment.MiddleCenter;
                l1.Text = "Imię " + client.Name;

                Label l2 = new Label();
                l2.Dock = DockStyle.Fill;
                l2.TextAlign = ContentAlignment.MiddleCenter;
                l2.Text = "Nazwisko " + client.Surname;

                Label l3 = new Label();
                l3.Dock = DockStyle.Fill;
                l3.TextAlign = ContentAlignment.MiddleCenter;
                l3.Text = "Mail " + client.Email;

                Label l4 = new Label();
                l4.Dock = DockStyle.Fill;
                l4.TextAlign = ContentAlignment.MiddleCenter;
                l4.Text = "Tel. " + client.Phone;


                layoutPanel.Controls.Add(l1, 0, 0);
                layoutPanel.Controls.Add(l2, 0, 1);
                layoutPanel.Controls.Add(l3, 0, 2);
                layoutPanel.Controls.Add(l4, 0, 3);
                tp.Controls.Add(layoutPanel);
                ClientstabControl.TabPages.Add(tp);
            }
            ClientstabControl.ResumeLayout();
            ClientstabControl.Refresh();
        }
        private void SendOffersDialog_Load(object sender, EventArgs e)
        {
            DrawTabControlOffers();
            DrawTabControlClients();
        }
    }
}
