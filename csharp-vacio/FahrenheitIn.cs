using System;
using System.ServiceModel;

namespace fahrenheitIn
{
    [ServiceContract]
    public interface FahrenheitIn
    {
        [OperationContract]
        double fahrenheitaC(double grados);
    }
}
