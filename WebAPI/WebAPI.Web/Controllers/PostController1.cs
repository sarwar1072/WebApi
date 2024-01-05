using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Web.Context;
using WebAPI.Web.Models;

namespace WebAPI.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PostController1 : ControllerBase
    {
         IPostManager _postManager;
        public PostController1(IPostManager postManager)
        {
            _postManager = postManager;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var post = _postManager.GetAll().ToList();
                if (post == null)
                {
                    return NotFound();
                }
                return Ok(post);
            }
            catch(Exception ex) 
            { 
             return   BadRequest(ex.Message);
            }
            
        }
        [HttpPost]
        public IActionResult  SentToDataBase(Post post)
        {
            try
            {
                var postData = new Post()
                {
                    Title = post.Title,
                    Description = post.Description,
                    DateTime = DateTime.Now,
                };

                bool isSave = _postManager.Add(postData);

                if (isSave)
                {
                    return Created("", post);
                }
                return BadRequest("Creation fail");
            }
            catch(Exception ex) { 
                return BadRequest(ex.Message);  
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var post = _postManager.GetById(id);
                if (post == null)
                {
                    return NotFound();
                }
                return Ok(post);
            }
            catch(Exception ex) {
                return BadRequest(ex.Message);
            }          
        }
        [HttpPut]
        public IActionResult EditPost(Post post)
        {
            try
            {
                if (post.Id == null)
                {
                    return NotFound("Id null in here");
                }
                bool isUpdated = _postManager.Update(post);
                if (isUpdated)
                {
                    return Ok(post);

                }
                return BadRequest("Failed to update");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);  
            }
           
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            try
            {
                var getId = _postManager.GetById(id);
                if (getId == null)
                {

                    return BadRequest("Not Found");
                }
                bool isDelete = _postManager.Delete(getId);
                if (isDelete)
                {
                    return Ok("Data deleted");
                }
                return BadRequest("Failed to delete");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]  
        public IActionResult GetAllSearch(string  search) 
        {
            try
            {
                var result=_postManager.Search(search); 
                if(result.Count() ==0)
                {
                   return  BadRequest("Not found");
                }
                return Ok(result);  
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);  
            }
        
        }
        [HttpGet]
        public IActionResult ContainPost(string search)
        {
            try
            {
                var Text=_postManager.SearchString(search); 
                if(Text.Count() == 0)
                {
                    return NotFound("Not found");  
                }
                return Ok(Text);

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);  
            }
        }
        [HttpGet]
        public IActionResult PagingData(int page=1)
        {
            try
            {
                var pageingdata=_postManager.PagingList(page, 2);
                if(pageingdata.Count() == 0)
                {
                    return NotFound("not found");
                }
                return Ok(pageingdata);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
