using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
	public class Film:IEntity
	{
		public int Id { get; set; }
		public int CategoryId { get; set; }
		public int TypeId { get; set; }
		public string Name { get; set; }
		public string Director { get; set; }
		public int Time { get; set; }
		public string Poster { get; set; }
	}
}
