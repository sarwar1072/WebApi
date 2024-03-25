using WebAPI.Web.Models.VillaModel;

namespace WebAPI.Web.Models.VillaRepository
{
    public interface IHouseRepository
    {
        ICollection<House> GetAll();
        void Add(House house);
        void Delete(House house);
        House GetById(int id);
        void Update(House house);
    }
}
