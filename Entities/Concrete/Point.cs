using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
	public class Point:IEntity
	{
		public int Id { get; set; }
		public int FilmId { get; set; }
		public decimal Score { get; set; }
	}
}
