using Ticaret_E_Mvc_.Abstract;
using Ticaret_E_Mvc_.Entities;

namespace Ticaret_E_Mvc_.Concrete.EfCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category, ShopContext>, ICategoryRepository
    {
        public EfCoreCategoryRepository(ShopContext shopContext) : base()
        {
            //dsfa 
        }
        public List<Category> GetPopularCategories()
        {
            throw new NotImplementedException();
        }
    }
}
