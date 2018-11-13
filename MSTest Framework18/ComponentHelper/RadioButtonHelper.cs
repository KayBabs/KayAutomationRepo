using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace MSTest_Framework18.ComponentHelper
{
	public class RadioButtonHelper
	{
		private static IWebElement _element;

		public static bool IsRadioButtonSelected(By locator)
		{
			_element = GenericHelper.GetElement(locator);
			var radioButtonStatus = _element.GetAttribute("ticked");

			if ( radioButtonStatus != null)
			{
				return radioButtonStatus.Equals("true") || radioButtonStatus.Equals("radioSelect");
			}
			else
			{
				return false;
			}

		}

		public static void ClickRadioButton(By locator)
		{
			_element = GenericHelper.GetElement(locator);
			_element.Click();
		}
	}
}
