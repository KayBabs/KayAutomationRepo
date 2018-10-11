using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest_Framework18.ComponentHelper;
using MSTest_Framework18.Configuration;
using MSTest_Framework18.Interfaces;
using MSTest_Framework18.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MSTest_Framework18
{
	[TestClass]
	public class UnitTest1
	{
		private readonly IConfig _config = new AppConfigReader();

		[TestMethod, TestCategory("SmokeTest")]
		public void LaunchAndCloseBrowser()
		{
			IWebDriver driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
			driver.Navigate().GoToUrl("https://www.bbc.co.uk/weather");
			driver.Quit();
			driver.Dispose();
		}
		
		[TestMethod]
		public void SimpleMethod()
		{
			
			NavigationHelper.
				NavigateToUrl(ObjectRepository.
				  Config.
				    GetWebsite());
			
			Console.WriteLine("this pagetitle is: {0}",PageTitleHelper.GetPageTitle());

		}
		
	}
}
