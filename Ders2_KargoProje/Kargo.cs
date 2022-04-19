using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2_KargoProje
{
    internal class Kargo
    {
        private double kargo_agirlik;

        public double Agirlik
        {
            get { return kargo_agirlik; }
        }

        public Kargo(double teslim_agirlik)
        {
            kargo_agirlik = teslim_agirlik;
        }
    }
}
