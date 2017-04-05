using System;
using Magenic.BadgeApplication.Processor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Magenic.BadgeApplication.Processor.Tests
{
	[TestClass]
	public class ADProcessorTest
	{
		[TestMethod]
		public void adCycle_Harness()
		{
			AutofacBootstrapper.Init();

			ADProcessor adProcessor = new ADProcessor();
			adProcessor.adCycle();
			Assert.IsTrue(true);
		}
	}
}
