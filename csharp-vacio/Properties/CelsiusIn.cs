using System;
using System.ServiceModel;

namespace celciusIn
{
	[ServiceContract]
	public interface CelciusIn
    {
		[OperationContract]
		public int CelciusaF(int grados);

    }
}