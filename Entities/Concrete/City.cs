﻿using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class City : IEntity
	{
		public int Id { get; set; }
		public int CountryId { get; set; }
		public string Name { get; set; }
		public DateTime CreateDate { get; set; }
		public int Active { get; set; }
	}
}
