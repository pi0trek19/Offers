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
        public List<Offer> Offers { get; set; }
        [DisplayName("Ilość ofert wysłanych")]
        public int NoOffers { get; set; }
        public Client()
        {
            NoOffers = Offers.Count;
        }
    }
}
