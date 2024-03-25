using System.ComponentModel.DataAnnotations;

namespace WebAPI.Web.Models.VillaModel
{
    public class House
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public double Rate { get; set; }
        public int  Sqrt { get; set; }
        public int Occupancy { get; set; }
        public string ImageUrl { get; set; }
        public string Amenity { get; set; }
        public DateTime Createddate { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
