using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MSTest_Framework18.Settings;
using OpenQA.Selenium;

namespace MSTest_Framework18.ComponentHelper
{
	public class GenericHelper
	{
		public static bool IsElementPresent(By locator)
		{
			try
			{
				return ObjectRepository.Driver.FindElements(locator).Count == 1;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		public static IWebElement GetElement(By locator)
		{
			if (IsElementPresent(locator))
			{
				return ObjectRepository.Driver.FindElement(locator);
			}
			else
			{
				throw new NoSuchElementException("element is not present " + locator.ToString());
			}
		}
	}
}
