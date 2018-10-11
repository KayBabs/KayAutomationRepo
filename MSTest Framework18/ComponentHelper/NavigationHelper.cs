using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSTest_Framework18.Settings;

namespace MSTest_Framework18.ComponentHelper
{
	public class NavigationHelper
	{
		public static void NavigateToUrl(string url)
		{
			ObjectRepository.Driver.Navigate().GoToUrl(url);
		}
	}
}
