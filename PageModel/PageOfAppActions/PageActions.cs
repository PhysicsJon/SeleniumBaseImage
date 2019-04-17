using OpenQA.Selenium;
using PageModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageModel.PageOfAppActions
{
	public class PageActions : Initialization
	{
		public PageActions(IWebDriver driver) : base(driver)
		{
		}

		public void ClickOnBob()
		{
			pageItems.BobProperty.Click();
		}

		public void SendStringToBob(string text)
		{
			pageItems.BobProperty.SendKeys(text);
		}
	}
}
