using EF.Core.Repository.Repository;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebAPI.Web.Context;

namespace WebAPI.Web.Models
{
    public class ProductRepository:CommonRepository<Product>,IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
