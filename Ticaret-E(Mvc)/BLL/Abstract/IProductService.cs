using Ticaret_E_Mvc_.Entities;

namespace Ticaret_E_Mvc_.BLL.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);
        List<Product> GetAll();
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
    }
}
