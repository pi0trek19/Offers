using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Offers.Models
{
    class Document
    {
        public List<Offer> OffersList = new List<Offer>();
        public List<Client> ClientsList = new List<Client>();
        public List<Car> CarsList = new List<Car>();
    }
}
