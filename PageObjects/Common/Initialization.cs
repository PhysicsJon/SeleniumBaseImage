using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;

namespace PageObjects.Common
{
	public abstract class Initialization
	{
		private readonly IWebDriver _driver;

		public Initialization(IWebDriver driver)
		{
			_driver = driver;
			PageFactory.InitElements(_driver, this);
		}
	}
}
