using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
	public class Series:IEntity
	{
		public int Id { get; set; }
		public int CategoryId { get; set; }
		public int TypeId { get; set; }
		public string Name { get; set; }
		public string Director { get; set; }
		public int Season { get; set; }
		public int Episode { get; set; }
		public string Poster { get; set; }
	}
}
