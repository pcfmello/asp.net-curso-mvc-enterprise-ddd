using PCFMELLO.CursoMvc.Domain.Interfaces.Repository;
using PCFMELLO.CursoMvc.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace PCFMELLO.CursoMvc.Infra.Data.Repository
{
    // Repositório genérico de CRUD
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        protected CursoMVCContext Db;
        protected DbSet<TEntity> DbSet;

        public Repository()
        {
            Db = new CursoMVCContext();
            DbSet = Db.Set<TEntity>();
        }

        public virtual TEntity Adicionar(TEntity obj)
        {
            var objReturn = DbSet.Add(obj); // Salva o objeto na memória do EntityFramework
            Db.SaveChanges(); // Salva o objeto
            return objReturn; // Retorna o objeto já salvo
        }

        public virtual TEntity Atualizar(TEntity obj)
        {
            var entry = Db.Entry(obj); // Cria uma entrada com o objeto modificado
            DbSet.Attach(obj); // Atacha o objeto dentro do Set (DbSet) ou Contexto em memória
            entry.State = EntityState.Modified; // Indica que o objeto já existe no BD porém os dados atachados estão modificados do BD
            SaveChanges(); // SaveChanges() compara o que tem no BD e altera somente o que está diferente
            return obj;
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        /** O método Dispose() é chamado para liberar recursos, 
         * como a conexão com um banco de dados, 
         * tão logo o objeto usando o recurso "não esta mais sendo usado". 
         * http://www.macoratti.net/14/09/c_garb1.htm */
        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this); // Solicita ao Garbage Collector recolher/retirar a referência da memória
        }

        public virtual TEntity ObterPorId(Guid id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> ObterTodos()
        {
            return DbSet.ToList();
        }

        public virtual void Remover(Guid id)
        {
            DbSet.Remove(ObterPorId(id)); // Remover() remove pelo objeto e não pela chave primária (Id)
            SaveChanges();
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }
    }
}
