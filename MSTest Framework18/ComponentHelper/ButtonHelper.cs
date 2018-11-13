using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace MSTest_Framework18.ComponentHelper
{
	public class ButtonHelper
	{
		public static IWebElement _element;

		public static bool IsButtonEnabled(By locator)
		{
			_element = GenericHelper.GetElement(locator);
			return _element.Enabled;
		}

		public static void ClickButton(By locator)
		{
			_element = GenericHelper.GetElement(locator);
			_element.Click();
		}
	}
}
