using EF.Core.Repository.Repository;
using WebAPI.Web.Context;

namespace WebAPI.Web.Models
{
    public class PostRepository:CommonRepository<Post>,IPostRepository
    {
        public PostRepository(ApplicationDbContext context):base(context)
        {
                
        }

    }
}
