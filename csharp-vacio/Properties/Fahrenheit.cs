using System;
using fahrenheitIn;

namespace fahrenheit{
    public class Fahrenheit: fahrenheitIn{
        public int fahrenheitaC(int grados){
            grados= (grados−32)×0.5556;
            return grados;
        }
    }
}