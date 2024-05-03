using System;
using fahrenheitIn;

namespace fahrenheit {
    public class Fahrenheit : FahrenheitIn {
        public double fahrenheitaC(double grados) {
            return (grados - 32) * 0.5556;
        }
    }
}
