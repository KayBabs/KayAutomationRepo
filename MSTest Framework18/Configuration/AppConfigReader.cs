using System;
using System.Configuration;
using MSTest_Framework18.Interfaces;
using MSTest_Framework18.Settings;

namespace MSTest_Framework18.Configuration
{
	public class AppConfigReader : IConfig
	{
		public string GetUsername()
		{
			return ConfigurationManager.AppSettings.Get(AppConfigKeys.Username);
		}

		public string GetPassword()
		{
			return ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);
		}

		public BrowserType GetBrowser()
		{
			string browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
			return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
		}

		public string GetWebsite()
		{
			return ConfigurationManager.AppSettings.Get(AppConfigKeys.Website);
		}

	}
}
