using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest_Framework18.Configuration;
using MSTest_Framework18.Interfaces;
using OpenQA.Selenium;

namespace MSTest_Framework18.Settings
{
	public class ObjectRepository
	{

		public static IConfig Config { get; set; }
		public static IWebDriver Driver { get; set; }
	}
	
}
