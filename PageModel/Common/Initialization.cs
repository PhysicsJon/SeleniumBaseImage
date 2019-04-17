using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageModel.Common
{
	public abstract class Initialization
	{
		internal IWebDriver _driver;
		internal PageObjects.PageOfApp.PageItems pageItems;

		public Initialization(IWebDriver driver)
		{
			_driver = driver;

			InitPageObjects();
		}

		private void InitPageObjects()
		{
			pageItems = new PageObjects.PageOfApp.PageItems(_driver);
		}
	}
}
