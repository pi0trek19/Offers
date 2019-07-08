﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Offers.Models
{
    public class Client
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public List<Offer> Offers { get; set; }
        public int NoOffers { get; set; }
        public Client()
        {
            NoOffers = Offers.Count;
        }
    }
}
