using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Web.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Img { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }
    }
}
