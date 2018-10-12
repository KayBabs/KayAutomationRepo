using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace MSTest_Framework18.ComponentHelper
{
	public class TextboxHelper
	{
		private static IWebElement element;
		
			public static void SendText(By locator, string text)
			{
				element = GenericHelper.GetElement((locator));
				element.SendKeys(text);
			}

		public static void ClearText(By locator)
		{
			element = GenericHelper.GetElement(locator);
			element.Clear();
		}
		
	}
}
