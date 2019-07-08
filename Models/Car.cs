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
    }
}
