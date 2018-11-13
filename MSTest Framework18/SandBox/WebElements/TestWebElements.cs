using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest_Framework18.ComponentHelper;
using MSTest_Framework18.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;

namespace MSTest_Framework18.SandBox.WebElements
{
	[TestClass]
	public class TestWebElements
	{
		[TestMethod]
		public void Elements()
		{
			NavigationHelper.
				NavigateToUrl(ObjectRepository.
					Config.GetWebsite());
			ButtonHelper.ClickButton(By.CssSelector("#top-links > ul > li.dropdown > a > span.hidden-xs.hidden-sm.hidden-md"));
			WaitHelper.WaitForElement(By.CssSelector("#top-links > ul > li.dropdown > a > span.hidden-xs.hidden-sm.hidden-md"));
			ButtonHelper.ClickButton(By.LinkText("Register"));

			Thread.Sleep(3000);
			//ButtonHelper.IsButtonEnabled(By.LinkText(""));
			//ButtonHelper.ClickButton(By.LinkText(""));

			//CheckboxHelper.IsCheckBoxTicked(By.Name("agree"));
			//CheckboxHelper.TickCheckbox(By.Name("agree"));

		}

	}
}
