using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReadRequestBody.Entities.Models;

namespace ReadRequestBody.Repository.Configuration
{
	public class UserConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
            builder.HasData(new User
            {
                Id = new Guid(),
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@somealias.com"
            },
            new User
            {
                Id = new Guid(),
                FirstName = "Jane",
                LastName = "Smith",
                Email = "jane.smith@somealias.com"
            },
            new User
            {
                Id = new Guid(),
                FirstName = "Sara",
                LastName = "Brown",
                Email = "sara.brown@somealias.com"
            });
		}
	}
}

