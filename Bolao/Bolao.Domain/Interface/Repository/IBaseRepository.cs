using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Bolao.Domain.Interface.Repository
{
    public interface IBaseRepository<TEntity> where TEntity: class
    {
        bool Excluir(TEntity entity);
        
        TEntity Salvar(TEntity entity);

        TEntity Editar(TEntity entity);

        TEntity SelecionarUm(Expression<Func<TEntity, bool>> expression);

        TEntity SelecionarUm(Expression<Func<TEntity, bool>> expression, Expression<Func<TEntity, object>>[] includes);

        IList<TEntity> Lista();

        IList<TEntity> Lista(Expression<Func<TEntity, object>>[] includes);

        IList<TEntity> ListaOnde(Expression<Func<TEntity, bool>> expression);

        IList<TEntity> ListaOnde(Expression<Func<TEntity, bool>> expression, Expression<Func<TEntity, object>>[] includes);
    }
}