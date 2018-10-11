using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSTest_Framework18.Configuration;

namespace MSTest_Framework18.CustomException
{
	public class NoSuitableDriverFound : Exception
	 {
	//	public NoSuitableExceptionFound(string message) : base(message)
	//	{
			
	//	}

		public NoSuitableDriverFound(string message, BrowserType getBrowser) : base(message)
		{
			
		}
	}
}
