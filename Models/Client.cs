using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Offers.Models
{
    public class Client
    {
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Imię")]
        public string Name { get; set; }
        [DisplayName("Nazwisko")]
        public string Surname { get; set; }
        [DisplayName("Nr telefonu")]
        public string Phone { get; set; }
        public List<SentOffer> SentOffers { get; set; }
        [DisplayName("Ilość ofert wysłanych")]
        public int NoOffers { get; set; }
        public Client(string mail, string name, string surname, string phone)
        {
            this.Email = mail;
            this.Name = name;
            this.Surname = surname;
            this.Phone = phone;
            NoOffers = 0;
            SentOffers = new List<SentOffer>();
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (this.GetType() != obj.GetType()) return false;
            Client client = (Client)obj;
            if (this.Email == client.Email && this.Phone == client.Phone)
            {
                return true;
            }
            else return false;
        }
    }
}
