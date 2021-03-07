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
    public class HomeController : Controller
    {
       
        private readonly IBlogRepository _blogRepository;
        public HomeController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public IActionResult Index()
        {
            return Ok();
        }

        [Authorize]
        public ActionResult<IEnumerable<BlogDetails>> Data()
        {
            var blog = _blogRepository.Get();
            return blog;
        }
    }
}
