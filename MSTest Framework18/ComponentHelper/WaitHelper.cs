using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSTest_Framework18.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MSTest_Framework18.ComponentHelper
{
	public class WaitHelper
	{
		private static IWebElement _element;

		public static void WaitForElement(By locator)
		{
			var wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(15));
			_element = wait.Until(d => d.FindElement(locator));
		}
	}
}
