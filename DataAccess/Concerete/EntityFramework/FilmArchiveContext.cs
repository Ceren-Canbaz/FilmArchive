using Microsoft.EntityFrameworkCore;
using Entities.Concerete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
	public class FilmArchiveContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=DESKTOP-TTOQ6J4\SQLEXPRESS;Database=FilmArchive;Trusted_Connection=true");
		}
		public DbSet<Film> Films { get; set; }
		public DbSet<Series> Series { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<MovieType> Types { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Point> Points  { get; set; }
		public DbSet<FavoriteList> Lists { get; set; }
	}
}
