using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class OrderDetail : IEntity
	{
		public string Id { get; set; }
		public string OrderId { get; set; }
		public int ProductId { get; set; }
		public int Count { get; set; }
		public int SalePrice { get; set; }
		public DateTime CreateDate { get; set; }
		public bool Active { get; set; }
	}

}
