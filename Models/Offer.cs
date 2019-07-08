using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Offers.Models
{
    public class Offer
    {
        public Car RentCar { get; set; }
        [DisplayName("Ilość miesięcy")]
        public int NoMonths { get; set; }
        [DisplayName("Stawka miesięczna netto")]
        public decimal MonthlyFee { get; set; }
        [DisplayName("Opłata wstępna")]

        public decimal StartPayment { get; set; }
        [DisplayName("Wykup końcowy")]

        public decimal EndPayment { get; set; }
        [DisplayName("Limit przebiegu")]

        public int MonthlyMilage { get; set; }

        public Offer(Car c1, int mon, decimal mfee, decimal stap,decimal endp,int monmil)
        {
            RentCar = c1;
            NoMonths = mon;
            MonthlyFee = mfee;
            StartPayment = stap;
            EndPayment = endp;
            MonthlyMilage = monmil;
        }
    }
}
