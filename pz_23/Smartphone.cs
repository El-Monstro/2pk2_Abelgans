using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_23
{
    internal class Smartphone : Computer
    {
        
    public double Diagonal { get; set; }
        public string Diapazon { get; set; }
        
        public override string GetCompName()
        {
            return $"Diagonal: {Diagonal}, Diapazon: {Diapazon}";
        }
    }
}

