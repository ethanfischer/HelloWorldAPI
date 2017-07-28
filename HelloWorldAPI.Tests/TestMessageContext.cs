using System;
using System.Data.Entity;
using HelloWorldAPI.Models;

namespace HelloWorldAPI.Tests
{
	public class TestMessageContext : IMessageContext
	{
		public TestMessageContext()
		{
			this.Messages = new TestMessagesDbSet();
		}

		public DbSet<Message> Messages { get; set; }

		public int SaveChanges()
		{
			return 0;
		}

		public void MarkAsModified(Message item) { }
		public void Dispose() { }
	}
}