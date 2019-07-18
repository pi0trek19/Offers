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
        [DisplayName("Nr rej.")]
        public string CarReg { get; set; }
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
            CarReg = c1.RegNo;
        }
    }
    public class SentOffer : Offer
    {
        [DisplayName("Data wysłania oferty")]
        public DateTime SendTimestamp { get; set; }

        public SentOffer(Car c1, int mon, decimal mfee, decimal stap, decimal endp, int monmil, DateTime dateTime) : base(c1, mon, mfee, stap, endp, monmil)
        {
            this.RentCar = c1;
            this.MonthlyFee = mfee;
            this.StartPayment = stap;
            this.EndPayment = endp;
            this.MonthlyMilage = monmil;
            this.SendTimestamp = dateTime;
            this.CarReg = c1.RegNo;
        }
    }

}
