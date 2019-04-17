using OpenQA.Selenium;
using PageObjects.Common;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.PageOfApp
{
	public class PageItems : Initialization
	{
		public PageItems(IWebDriver driver) : base(driver)
		{
			// Empty contructor used to pass the WebDriver to the abstract class
		}

		[FindsBy(How=How.Id, Using = "bob")]
		public IWebElement BobProperty { get; set; }
	}
}
