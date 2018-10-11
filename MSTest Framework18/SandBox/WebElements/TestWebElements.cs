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
					Config.
						GetWebsite());
			try
			{
				ObjectRepository.Driver.FindElement(By.Id("idcta-username"));
				ObjectRepository.Driver.FindElement(By.ClassName("id4-cta-register"));
				ObjectRepository.Driver.FindElement(By.CssSelector("#ls-c-search__input-label"));
				ObjectRepository.Driver.FindElement(By.TagName("li"));
				ObjectRepository.Driver.FindElement(By.LinkText("Warnings"));
				var goButton = ObjectRepository.Driver.FindElement(By.Id("submit"));
				goButton.Click();
			}
			catch (NoSuchElementException e)
			{
				Console.WriteLine(e);
				throw;
			}

			var tagList = ObjectRepository.Driver.FindElements(By.TagName("li"));
			foreach (var tag in tagList)
			{
				if (tag.GetAttribute("value").Equals("orb-nav-home"))
				{
					tag.Click();
					Thread.Sleep(8000);
					break;
				}
			}
		}

	}
}
