using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest_Framework18.Configuration;
using MSTest_Framework18.CustomException;
using MSTest_Framework18.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace MSTest_Framework18.Base
{
	[TestClass]
	public class BaseClass
	{
		#region BrowserOptions
		private static ChromeOptions GetChromeOption()
		{
			var cOptions = new ChromeOptions();
			cOptions.AddArgument("start-maximized");
			return cOptions;
		}
		private static InternetExplorerOptions GetIEOptions()
		{
			var iEOptions = new InternetExplorerOptions();
			{
				iEOptions.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
				iEOptions.EnsureCleanSession = true;
			}
			return iEOptions;
		}
		private static FirefoxProfile GetFirefoxOptions()
		{
			var fOptions = new FirefoxProfile();
			var fxManager = new FirefoxProfileManager();
			fOptions = fxManager.GetProfile("default");
			return fOptions;
		}
		private static ChromeOptions GetMoreChromeOptions()
		{
			var mChromeOptions = new ChromeOptions();
			mChromeOptions.AddArgument("headless");
			return mChromeOptions;
		}
		#endregion

		#region DriverInstance
		private static IWebDriver GetChromeDriver()
		{
			IWebDriver driver = new ChromeDriver(GetChromeOption());
			return driver;
		}
		public static IWebDriver GetExtraChromeDriver()
		{
			IWebDriver driver = new ChromeDriver(GetMoreChromeOptions());
			return driver;
		}
		private static IWebDriver GetFirefoxDriver()
		{
			IWebDriver driver = new FirefoxDriver();
			return driver;
		}
		private static IWebDriver GetIExplorerDriver()
		{
			IWebDriver driver = new InternetExplorerDriver(GetIEOptions());
			return driver;
		}
		private static IWebDriver GetEdgeDriver()
		{
			IWebDriver driver = new EdgeDriver();
			return driver;
		}
		#endregion

		#region BeforeAndAfterInitialization
		[AssemblyInitialize]
		public static void InitWebDriver (TestContext testContext)
		{
			ObjectRepository.Config = new AppConfigReader();

			switch (ObjectRepository.Config.GetBrowser())
			{
			        case BrowserType.Chrome:
					ObjectRepository.Driver = GetChromeDriver();
					break;
				    case BrowserType.ChromeHeadless:
					ObjectRepository.Driver = GetExtraChromeDriver();
					break;
					case BrowserType.Edge:
					ObjectRepository.Driver = GetEdgeDriver();
				    break;
					case BrowserType.Explorer:
					ObjectRepository.Driver = GetIExplorerDriver();
					break;
					case BrowserType.Firefox:
					ObjectRepository.Driver = GetFirefoxDriver();
					break;

				default:
					throw new NoSuitableDriverFound("Driver not Here {0}", ObjectRepository.Config.GetBrowser());
			}
			// ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

			ObjectRepository.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(15);
		}
		[AssemblyCleanup]
		public static void TearDown()
	   {
		   if (ObjectRepository.Driver != null)
		   {
			  ObjectRepository.Driver.Quit();
			  ObjectRepository.Driver.Dispose(); 
		   }
			
	   }
		#endregion
	}

}
