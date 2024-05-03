using System;
using System.ServiceModel;

namespace celciusIn
{
	[ServiceContract]
	public interface CelciusIn
    {
		[OperationContract]
		public double CelciusaF(double grados);

    }
}