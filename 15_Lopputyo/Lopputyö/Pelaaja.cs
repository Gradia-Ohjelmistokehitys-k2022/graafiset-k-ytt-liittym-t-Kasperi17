﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lopputyö
{
    [Serializable]
    internal class Pelaaja
    {
       
        public string Nimi { get; set; }
        
        
        public Pelaaja(string nimi)
        {
            Nimi = nimi;
            
            
        }

       
    }
}
