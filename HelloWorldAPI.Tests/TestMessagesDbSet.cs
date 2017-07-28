using System;
using System.Linq;
using HelloWorldAPI.Models;

namespace HelloWorldAPI.Tests
{
	class TestMessagesDbSet : TestDbSet<Message>
	{
		public override Message Find(params object[] keyValues)
		{
			return this.SingleOrDefault(message => message.ID == (int)keyValues.Single());
		}
	}
}