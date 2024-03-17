using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using project.Models;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        [HttpGet(Name = "GetPosts")]
        public IEnumerable<Post> GetPosts(){
            return Enumerable.Range(1,5).Select(index => new Post{
                Id = index,
                Title = $"Статья номер {index}",
                Content = $"Контент статьи {index}"
            });
        }
    }
}
