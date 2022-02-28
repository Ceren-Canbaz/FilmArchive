using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
	public class FavoriteList:IEntity
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int FilmId { get; set; }
	}
}
