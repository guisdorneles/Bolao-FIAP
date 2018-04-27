using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Bolao.Domain.Interface.Repository;
using Bolao.Infraestrutura.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;

namespace Bolao.Infraestrutura.EntityFramework.Repository
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        #region Construtor
        
        protected readonly BolaoContext _context;

        public BaseRepository()
        {  }

        #endregion

        public TEntity Editar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> Lista()
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> Lista(Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> ListaOnde(Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> ListaOnde(Expression<Func<TEntity, bool>> expression, Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public TEntity Salvar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity SelecionarUm(Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public TEntity SelecionarUm(Expression<Func<TEntity, bool>> expression, Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }
    }
}