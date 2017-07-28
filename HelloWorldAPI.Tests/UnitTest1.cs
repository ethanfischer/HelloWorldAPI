using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldAPI.Controllers;
using HelloWorldAPI.Models;

namespace HelloWorldAPI.Tests
{
	[TestClass]
	public class TestMessagesController
	{
        private MessageContext db = new MessageContext();

		[TestMethod]
		public void GetMessage_ShouldReturnAMessage()
		{
			var controller = new MessagesController(new TestMessageContext());

			var result = controller.GetMessage();
			Assert.AreNotEqual("", result);
			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void GetMessage_ShouldReturnHelloWorld()
		{
			var controller = new MessagesController(new TestMessageContext());

			var result = controller.GetMessage();
			Assert.AreEqual("Hello World", result);
		}
	}
}