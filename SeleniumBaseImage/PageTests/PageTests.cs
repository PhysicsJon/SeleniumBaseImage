using SeleniumBaseImage.Common;
using System;
using Xunit;

namespace SeleniumBaseImage.PageTests
{
	public class PageTests : Initialization, IDisposable
	{
		[Fact]
		public void ClickBob()
		{
			pageActions.ClickOnBob();
		}

		[Theory]
		[InlineData("Test1")]
		[InlineData("!£$//!")]
		[InlineData("12345")]
		[InlineData("adsfafadsasfa")]
		[InlineData("FKDIHGASFDKILAG")]
		public void SendStringToBob(string text)
		{
			pageActions.SendStringToBob(text);
		}
	}
}
