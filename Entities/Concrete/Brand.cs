using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Brand : IEntity
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public DateTime CreateDate { get; set; }
		public bool Active { get; set; }
	}
}
