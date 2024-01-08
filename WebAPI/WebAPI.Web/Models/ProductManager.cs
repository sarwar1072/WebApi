using EF.Core.Repository.Manager;
using WebAPI.Web.Context;

namespace WebAPI.Web.Models
{
    public class ProductManager:CommonManager<Product>,IProductManager
    {
        public ProductManager(ApplicationDbContext context) : base(new ProductRepository(context))
        {

        }
        public void AddProduct(Product product)
        {
            Add(product);
             
        }
    }
}
