using EF.Core.Repository.Manager;
using WebAPI.Web.Context;

namespace WebAPI.Web.Models
{
    public class PostManager:CommonManager<Post>,IPostManager
    {
        public PostManager(ApplicationDbContext context):base(new PostRepository(context))
        {
                
        }
        public ICollection<Post> Search(string search)
        {
            return Get(x => x.Title.ToLower() == search.ToLower()).ToList();
        }
        public ICollection<Post> SearchString(string  search)
        {
            return Get(x=>x.Title.Contains(search.ToLower())|| x.Description.ToLower().Contains(search.ToLower()) );
        }
        public Post GetById(int id)
        {
           return GetFirstOrDefault(x=>x.Id == id); 
        }
        public ICollection<Post> PagingList(int page,int pageSize) 
        {
            if (page <= 1)
            {
                page = 0;   
            }
            int pageNumber=page*pageSize;   
            return GetAll().Skip(pageNumber).Take(pageSize).ToList();
        }
    }
}
