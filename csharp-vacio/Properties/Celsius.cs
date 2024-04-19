using System;
using celciusIn;

namespace celcius{
    public class Celcius: celciusIn{
        public int CelciusaF(int grados){
            grados = (grados×1.8)+32;
            return grados;
        }
    }
}