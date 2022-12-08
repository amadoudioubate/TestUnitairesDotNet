using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialisationOarametres
{
    public class Rectangle
    {

        public double Hauteur { get; set; }

        public double Largeur { get; set; }

        public double Surface()
        {
            return Hauteur * Largeur;
        }
    }
}
