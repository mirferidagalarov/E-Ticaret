using Ticaret_E_Mvc_.Abstract;
using Ticaret_E_Mvc_.Entities;

namespace Ticaret_E_Mvc_.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product>, IProductRepository
    {
        private readonly ShopContext _shopContext;
        public EfCoreProductRepository(ShopContext shopContext):base(shopContext)
        {
            _shopContext = shopContext;
        }
        public List<Product> GetPopularProducts()
        {
            throw new NotImplementedException();
        }
    }
}
