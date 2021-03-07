using BlogManagement.Model;
using BlogManagement.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogManagement.Controllers
{
    
    [ApiController]
    [Route("api")]
    public class BlogManagementController : ControllerBase
    {
        private readonly IBlogRepository _blogRepository;
        public BlogManagementController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        
        [HttpGet("blogs")]
        public ActionResult<IEnumerable<BlogDetails>> Get()
        {
            var blog = _blogRepository.Get();
            return blog;
        }

        [Authorize(Roles = "User")]
        [HttpGet("blog/{id}")]
        public ActionResult<BlogDetails> Get(int id)
        {
            return _blogRepository.GetById(id);
        }

        [Authorize(Roles = "User")]
        [HttpPost("insertblog")]
        public void Post(BlogDetails blog)
        {
            _blogRepository.Add(blog);
        }

        [Authorize(Roles = "User")]
        [HttpPut("updateblog")]
        public void Put(BlogDetails blog)
        {
            _blogRepository.Update(blog);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("deleteblog")]
        public void Delete(BlogDetails blog)
        {
            _blogRepository.Delete(blog);
        }
    }
}
