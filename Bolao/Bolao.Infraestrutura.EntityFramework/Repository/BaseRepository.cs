using System;
using System.Collections.Generic;
using System.Linq;
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
            //_context.Set<TEntity>().Add(entity);
            //_context.SaveChanges();
            return entity;
        }

        public bool Excluir(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            return _context.SaveChanges() > 0;
        }

        public IList<TEntity> Lista()
            => _context.Set<TEntity>().ToList();

        public IList<TEntity> Lista(Expression<Func<TEntity, object>>[] includes)
        {
            var objeto = _context.Set<TEntity>();
            foreach (var include in includes)
            {
                objeto.Include(include);
            }
            return objeto.ToList();
        }

        public IList<TEntity> ListaOnde(Expression<Func<TEntity, bool>> expression)
            => _context.Set<TEntity>().Where(expression).ToList();

        public IList<TEntity> ListaOnde(Expression<Func<TEntity, bool>> expression, Expression<Func<TEntity, object>>[] includes)
        {
            var objeto = _context.Set<TEntity>().Where(expression);
            foreach (var include in includes)
            {
                objeto.Include(include);
            }
            return objeto.ToList();
        }

        public TEntity Salvar(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public TEntity SelecionarUm(Expression<Func<TEntity, bool>> expression)
            => _context.Set<TEntity>().FirstOrDefault(expression);

        public TEntity SelecionarUm(Expression<Func<TEntity, bool>> expression, Expression<Func<TEntity, object>>[] includes)
        {
            var objeto = _context.Set<TEntity>().Where(expression);
            foreach (var include in includes)
            {
                objeto.Include(include);
            }
            return objeto.FirstOrDefault();
        }
    }
}