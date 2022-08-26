using Ticaret_E_Mvc_.Entities;

namespace Ticaret_E_Mvc_.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        List<Product> GetPopularProducts();

    }
}
