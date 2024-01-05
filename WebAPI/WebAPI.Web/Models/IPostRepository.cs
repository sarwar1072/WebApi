using EF.Core.Repository.Interface.Repository;
using WebAPI.Web.Context;

namespace WebAPI.Web.Models
{
    public interface IPostRepository:ICommonRepository<Post>
    {
    }
}
