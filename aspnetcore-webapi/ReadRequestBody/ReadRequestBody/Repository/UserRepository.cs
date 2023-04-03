using System;
using ReadRequestBody.Contracts;
using ReadRequestBody.Entities.Models;

namespace ReadRequestBody.Repository
{
	public class UserRepository : RepositoryBase<User>, IUserRepository
	{
		public UserRepository(RepositoryContext repositoryContext)
			: base(repositoryContext)
		{
		}

		public IEnumerable<User> GetAllUsers() =>
			FindAll()
			.OrderBy(u => u.LastName)
			.ToList();

		public User? GetUser(Guid userId) =>
			FindByCondition(u => u.Id.Equals(userId))
			.SingleOrDefault();

		public void CreateUser(User user) => Create(user);

		public IEnumerable<User> GetByIds(IEnumerable<Guid> ids) =>
			FindByCondition(x => ids.Contains(x.Id))
			.ToList();

		public void DeleteUser(User user) => Delete(user);

	}
}

