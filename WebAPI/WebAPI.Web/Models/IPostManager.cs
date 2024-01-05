using EF.Core.Repository.Interface.Manager;

namespace WebAPI.Web.Models
{
    public interface IPostManager:ICommonManager<Post>
    {
        Post GetById(int id);
        ICollection<Post> Search(string search);
        ICollection<Post> SearchString(string search);
    }
}
