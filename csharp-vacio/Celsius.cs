using System;
using celciusIn;

namespace celcius {
    public class Celcius : CelciusIn {
        public double CelciusaF(double grados) {
            grados = (grados * 1.8) + 32;
            return grados;
        }
    }
}
