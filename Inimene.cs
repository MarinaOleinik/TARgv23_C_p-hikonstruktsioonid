﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv23_C_põhikonstruktsioonid
{
    public class Inimene
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; }

        public Inimene() { }
        public Inimene(string nimi) 
        {  
            Nimi = nimi;
        }
    }
}
