using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Order : IEntity
	{
		public string Id { get; set; }
		public int UserId { get; set; }
		public string AddressId { get; set; }
		public int OrderStatusId { get; set; }
		public int Count { get; set; }
		public DateTime CreateDate { get; set; }
		public bool Active { get; set; }
	}
}
