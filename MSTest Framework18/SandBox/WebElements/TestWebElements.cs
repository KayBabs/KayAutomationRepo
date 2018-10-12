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
				//ObjectRepository.Driver.FindElement(By.ClassName("ls-ui-input"));
				ObjectRepository.Driver.FindElement(By.CssSelector(""));
				ObjectRepository.Driver.FindElement(By.TagName("input"));
				ObjectRepository.Driver.FindElement(By.LinkText("Warnings"));
				ObjectRepository.Driver.FindElement(By.PartialLinkText("arnings"));
				
				//var goButton = ObjectRepository.Driver.FindElement(By.Id("submit"));
				//goButton.Click();
			}
			catch (NoSuchElementException e)
			{
				Console.WriteLine(e);
				throw;
			}

			
			//var tagList = ObjectRepository.Driver.FindElements(By.TagName("input"));
			//foreach (var tag in tagList)
			//{
			//	if (tag.GetAttribute("class").Equals("ls-ui-input")) continue;
			//	{
			//		tag.Click();
			//		Thread.Sleep(8000);
			//		break;
			//	}
			//}
			LinkHelper.ClickLink(By.LinkText("Warnings"));
			

		}

	}
}
