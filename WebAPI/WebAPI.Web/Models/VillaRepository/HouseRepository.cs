using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebAPI.Web.Context;
using WebAPI.Web.Models.VillaModel;

namespace WebAPI.Web.Models.VillaRepository
{
    public class HouseRepository: IHouseRepository
    {
        private readonly ApplicationDbContext _context;
        public HouseRepository(ApplicationDbContext context)
        {
            _context = context;  
        }
        public  ICollection<House> GetAll()
        {
            return _context.Houses.ToList();    
        }
        public void  Add(House house) { 
        
        _context.Add(house);
            _context.SaveChanges();
        }
        public  void Delete(House house )
        {
            _context.Remove(house);

            _context.SaveChanges();                
        }
        public void Update(House house) { 
           _context.Update(house);
            _context.SaveChanges();
        }
        public  House GetById(int id) {
            return _context.Houses.AsNoTracking().Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
