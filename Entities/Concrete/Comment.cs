using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
	public class Comment:IEntity
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int FilmId { get; set; }
		public string UsersComment { get; set; }
	}
}
