using API_BlogPlatform.Domain.IRepositories;
using API_BlogPlatform.Domain.IServices;
using API_BlogPlatform.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_BlogPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {
        private readonly IBlogPostService _blogPostService;
        public BlogPostController(IBlogPostService blogPostService)
        {
            _blogPostService = blogPostService;
        }
        /// <summary>
        /// Store a new BlogPost into the repository
        /// </summary>
        /// <param name="blogPost"></param>
        /// <returns>200 when Ok; 400 when bad request </returns>
        [HttpPost]
        public IActionResult Post([FromBody] BlogPost blogPost)
        {
            try
            {
                if (blogPost == null)
                {
                    return BadRequest(new { message = "Blog no valido" });
                }
                _blogPostService.AddBlogPost(blogPost);
                return Ok(blogPost);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
        /// <summary>
        /// returns all the blogPost already stored in repository
        /// </summary>
        /// <returns>list of blogPost</returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var listBlogPost = _blogPostService.GetAllBlogPosts();
                return Ok(listBlogPost);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }


    }

}
