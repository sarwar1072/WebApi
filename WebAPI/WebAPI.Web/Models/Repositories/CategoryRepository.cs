using Microsoft.EntityFrameworkCore;
using WebAPI.Web.Context;
using WebAPI.Web.Models.PokemonModel;

namespace WebAPI.Web.Models.Repositories
{
    public class CategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
                _context = context; 
        }
        //public Category GetCategoryById(int id)
        //{
        //    return _context.Categories.Where(x => x.Id == id).FirstOrDefault();
        //}
        //public ICollection<Pokemon> GetPokemonByCategoryId(int categoryId)
        //{
        //    return _context.PokemonCategories.Where(x=>x.CategoryId == categoryId).Select(x=>x.Pokemon).ToList();
        //} 
        
    }
}
