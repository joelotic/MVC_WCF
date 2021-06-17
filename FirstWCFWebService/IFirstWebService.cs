using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FirstWCFWebService
{
	[ServiceContract]
	public interface IFirstWebService
	{
		[OperationContract]
		string  Message();
	}
}
