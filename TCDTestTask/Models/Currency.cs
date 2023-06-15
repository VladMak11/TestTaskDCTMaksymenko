﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCDTestTask.Models
{
    public class Currency
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public decimal Volume { get; set; }
        public decimal PriceChange { get; set; }
        public List<Market> Markets { get; set; }
    }
}
