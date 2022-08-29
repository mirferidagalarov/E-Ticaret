using Ticaret_E_Mvc_.Abstract;
using Ticaret_E_Mvc_.BLL.Abstract;
using Ticaret_E_Mvc_.Entities;

namespace Ticaret_E_Mvc_.BLL.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductRepository _prdocutRepository;
        public ProductManager(IProductRepository prdocutRepository)
        {
            _prdocutRepository = prdocutRepository;
        }
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
