using Microsoft.EntityFrameworkCore;
using Ticaret_E_Mvc_.Abstract;
using Ticaret_E_Mvc_.Entities;

namespace Ticaret_E_Mvc_.Concrete.EfCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>,ICategoryRepository
    {
        private readonly ShopContext _shopContext;
        public EfCoreCategoryRepository(ShopContext shopContext):base(shopContext)
        {
            _shopContext = shopContext;
        }
        public List<Category> GetPopularCategories()
        {
            throw new NotImplementedException();
        }
    }
}
