using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Offers.Models
{
    class Offer
    {
        public Car RentCar { get; set; }
        public int NoMonths { get; set; }
        public decimal MonthlyFee { get; set; }
        public decimal StartPayment { get; set; }
        public decimal EndPayment { get; set; }
        public int MonthlyMilage { get; set; }

        public Offer()
        {

        }
    }
}
