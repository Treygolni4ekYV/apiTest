using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using project.Data;
using project.Models;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly PostContext postContext;

        public PostController(PostContext postContext)
        {
            this.postContext = postContext;
        }

        [HttpGet]
        [Route("GetUsers")]
        public List<Post> GetPosts()
        {
            return postContext.Posts.ToList();
        }

        [HttpPost]
        [Route("AddUser")]
        public string AddPost(Post post)
        {
            postContext.Posts.Add(post);
            postContext.SaveChanges();
            return "Post added";
        }
    }
}
