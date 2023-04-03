using System;
using ReadRequestBody.Entities.Models;

namespace ReadRequestBody.Contracts
{
	public interface IUserRepository
	{
		public IEnumerable<User> GetAllUsers();

		public User? GetUser(Guid userId);

		public void CreateUser(User user);

		public IEnumerable<User> GetByIds(IEnumerable<Guid> ids);

		public void DeleteUser(User user);
	}
}

