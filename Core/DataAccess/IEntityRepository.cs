using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
	//Generic constraint
	//class : Referans tip
	//IEntity : IEntity olabilir ve IEntity implemente eden bir nesne olabilir
	//new() : new'lenebilir olmalı
	public interface IEntityRepository<T> where T:class,IEntity,new()
	{
		List<T> GetAll(Expression<Func<T,bool>> filter=null);
		T Get(Expression<Func<T,bool>> filter);
		void Add(T entity);
		void Update(T entity);
		void Delete(T entity);	
	}
}