﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHamburgerciOrnek
{
    public abstract class Malzeme
    {
        public string Adi { get; set; }
        public decimal Fiyati { get; set; }
        public override string ToString()
        {
            return Adi;
        }
    }
}
