using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSTest_Framework18.Configuration;

namespace MSTest_Framework18.Interfaces
{
	public interface IConfig
	{
		string GetUsername();
		string GetPassword();
		BrowserType GetBrowser();
		string GetWebsite();
	}
}
