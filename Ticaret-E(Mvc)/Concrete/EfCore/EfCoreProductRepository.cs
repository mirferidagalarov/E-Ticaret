using Ticaret_E_Mvc_.Abstract;
using Ticaret_E_Mvc_.Entities;

namespace Ticaret_E_Mvc_.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product, ShopContext>, IProductRepository
    {
        public List<Product> GetPopularProducts()
        {
            throw new NotImplementedException();
        }
    }
}
