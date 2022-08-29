using Microsoft.AspNetCore.Mvc;
using Ticaret_E_Mvc_.Abstract;
using Ticaret_E_Mvc_.BLL.Abstract;

namespace Ticaret_E_Mvc_.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;   
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
