using Microsoft.AspNetCore.Mvc;
using RestfulWebAPI.Models;
using RestfulWebAPI.Service;

namespace RestfulWebAPI.Controllers
{
    [Route("api/posts")]
    [ApiController]
    public class PostsController : Controller
    {
        private readonly IPostService _postService;

        public PostsController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpPost]
        public ActionResult Create(Posts post)
        {
            var response = _postService.Create(post);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public ActionResult GetPost(int id)
        {
            var response = _postService.GetPost(id);
            return Ok(response);
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var response = _postService.GetAll();
            return Ok(response);    
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(_postService.DeleteProduct(id));
        }

        [HttpPut("{id}")]
        public ActionResult UpdatePost(int id, Posts post) 
        {
            var response = _postService.Update(id,post);
            return Ok(response);
        }



    }
}
