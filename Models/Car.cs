using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Offers.Models
{
    public class Car
    {
        public string RegNo { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public Car(string reg, string make, string model, string colour)
        {
            this.RegNo = reg;
            this.Make = make;
            this.Model = model;
            this.Colour = colour;

        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (this.GetType() != obj.GetType()) return false;
            Car car = (Car)obj;
            if (this.Colour.ToLower() == car.Colour.ToLower() && this.Make.ToLower() == car.Make.ToLower()
                && this.Model.ToLower() == car.Model.ToLower())
            {
                return true;
            }
            else return false;
        }
    }
}
