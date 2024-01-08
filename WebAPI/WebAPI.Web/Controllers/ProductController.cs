using Microsoft.AspNetCore.Mvc;
using WebAPI.Web.Models;

namespace WebAPI.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IFileService _fileService;
        private readonly IProductManager _productManager;
        public ProductController(IFileService fs, IProductManager productManager)
        {
            _fileService = fs;
            _productManager = productManager;
        }
        
        [HttpPost]
        public IActionResult Add([FromForm] Product model)
        {           
            var status = new Status();
            if (!ModelState.IsValid)
            {
                status.StatusCode = 0;
                status.Message = "Please pass the valid data";
                return Ok(status);
            }
            if (model.ImageFile != null)
            {
                var fileResult = _fileService.SaveImage(model.ImageFile);
                if (fileResult.Item1 == 1)
                {
                    model.Img = fileResult.Item2; // getting name of image
                }
                var productResult = _productManager.Add(model);
                if (productResult)
                {
                    status.StatusCode = 1;
                    status.Message = "Added successfully";
                }
                else
                {
                    status.StatusCode = 0;
                    status.Message = "Error on adding product";
                }
            }
            return Ok(status);
        }
    }
}
