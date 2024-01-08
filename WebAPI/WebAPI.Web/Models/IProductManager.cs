using EF.Core.Repository.Interface.Manager;

namespace WebAPI.Web.Models
{
    public interface IProductManager:ICommonManager<Product>    
    {
        void AddProduct(Product product);
    }
}
