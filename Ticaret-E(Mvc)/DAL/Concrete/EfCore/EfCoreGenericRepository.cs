using Microsoft.EntityFrameworkCore;
using Ticaret_E_Mvc_.Abstract;

namespace Ticaret_E_Mvc_.Concrete.EfCore
{
    public class EfCoreGenericRepository<TEntity> : IRepository<TEntity>
      where TEntity : class 
      
    {
        private readonly ShopContext _shopContext;
        public EfCoreGenericRepository(ShopContext shopContext)
        {
            _shopContext=shopContext;
        }
        public void Create(TEntity entity)
        {

            _shopContext.Set<TEntity>().Add(entity);
            _shopContext.SaveChanges();
            
        }

        public void Delete(TEntity entity)
        {

            _shopContext.Set<TEntity>().Remove(entity);
            _shopContext.SaveChanges();
            
        }

        public List<TEntity> GetAll()
        {
            
                return _shopContext.Set<TEntity>().ToList();
            
        }

        public TEntity GetById(int id)
        {
           
                return _shopContext.Set<TEntity>().Find(id);
            
        }

        public void Update(TEntity entity)
        {

            _shopContext.Entry(entity).State = EntityState.Modified;
            _shopContext.SaveChanges();
            
        }
    }
}
