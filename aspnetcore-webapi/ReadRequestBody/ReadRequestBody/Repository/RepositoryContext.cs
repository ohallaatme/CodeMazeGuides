using System;
using Microsoft.EntityFrameworkCore;
using ReadRequestBody.Entities.Models;
using ReadRequestBody.Repository.Configuration;

namespace ReadRequestBody.Repository
{
	public class RepositoryContext : DbContext
	{
		public RepositoryContext(DbContextOptions options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new UserConfiguration());
		}

		public DbSet<User>? Users { get; set; }
	}
}

