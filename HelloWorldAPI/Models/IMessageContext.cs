using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldAPI.Models
{
	public interface IMessageContext : IDisposable
	{
		DbSet<Message> Messages { get; }
		int SaveChanges();
		void MarkAsModified(Message item);

	}
}
