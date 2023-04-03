﻿using System.Linq.Expressions;
using ReadRequestBody.Contracts;
using ReadRequestBody.Entities.Models;

namespace ReadRequestBody.Repository
{
	public class RepositoryBase<T> : IRepositoryBase<T> where T : class
	{
		protected RepositoryContext RepositoryContext;

		public RepositoryBase(RepositoryContext repositoryContext) =>
			RepositoryContext = repositoryContext;

		public IQueryable<T> FindAll() =>
			RepositoryContext.Set<T>();

		public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) =>
			RepositoryContext.Set<T>()
			.Where(expression);

		public void Create(T entity) => RepositoryContext.Set<T>().Add(entity);

		public void Update(T entity) => RepositoryContext.Set<T>().Update(entity);

		public void Delete(T entity) => RepositoryContext.Set<T>().Remove(entity);
	}
}

