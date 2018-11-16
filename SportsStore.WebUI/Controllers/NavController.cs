using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;

namespace SportsStore.WebUI.Controllers
{
    public class NavController : Controller
    {
        private readonly IProductRepository _productRepository;

        public NavController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // GET
        public string Menu()
        {
            IEnumerable<string> categories =
                _productRepository.Products.Select(x => x.Category).Distinct().OrderBy(x => x);
        }
    }
}