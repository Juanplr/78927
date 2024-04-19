using System;
using System.ServiceModel;

namespace fahrenheitIn
{
	[ServiceContract]
	public interface FahrenheitIn
    {
		[OperationContract]
		public int fahrenheitaC(int grados);

    }
}