using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSTest_Framework18.Settings;

namespace MSTest_Framework18.ComponentHelper
{
	public class PageTitleHelper
	{
		public static string GetPageTitle()
		{
			var pageTitle = ObjectRepository.Driver.Title;
			return pageTitle;
		}
	}
}
