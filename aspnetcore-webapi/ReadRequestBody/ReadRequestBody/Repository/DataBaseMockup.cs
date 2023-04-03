using System;
using ReadRequestBody.Entities.Models;

namespace ReadRequestBody.Repository
{
	public class DataBaseMockup
	{
		public IEnumerable<User> Users { get; set; } = new List<User>
		{
			new User
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
			}
		};
	}
}

