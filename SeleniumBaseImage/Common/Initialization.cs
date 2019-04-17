using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumBaseImage.Common
{
	public abstract class Initialization : IDisposable
	{
		internal IWebDriver _driver;
		internal PageModel.PageOfAppActions.PageActions pageActions;

		public Initialization()
		{
			_driver = InitWebDriver();

			InitPageActions(_driver);
		}		

		private void InitPageActions(IWebDriver driver)
		{
			pageActions = new PageModel.PageOfAppActions.PageActions(driver);
		}

		private IWebDriver InitWebDriver()
		{
			ChromeOptions options = new ChromeOptions();

			if (!System.Diagnostics.Debugger.IsAttached)
			{
				options.AddArguments("--headless", "--disable-gpu");
			}
			else
			{
				options.AddArguments("--start-maximized", "--auto-open-devtools-for-tabs");
			}

			IWebDriver driver = new ChromeDriver(options);

			return driver;
		}

		public void Dispose()
		{
			// Put in tidy up logic here
		}
	}
}
