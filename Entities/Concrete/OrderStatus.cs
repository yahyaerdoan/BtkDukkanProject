﻿using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class OrderStatus : IEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime CreateDate { get; set; }
		public bool Active { get; set; }
	}
}
