using Ticaret_E_Mvc_.Entities;

namespace Ticaret_E_Mvc_.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {

        List<Category> GetPopularCategories();
    }
}
