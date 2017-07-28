using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HelloWorldAPI.Models
{
    public class MessageContext : DbContext, IMessageContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MessageContext() : base("name=MessageContext")
        {
        }

		public System.Data.Entity.DbSet<HelloWorldAPI.Models.Message> Messages { get; set; }

		public void MarkAsModified(Message item)
		{
			Entry(item).State = EntityState.Modified;
		}
	}
}
