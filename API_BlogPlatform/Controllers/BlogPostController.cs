using API_BlogPlatform.Domain.IServices;
using API_BlogPlatform.Domain.Models;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Linq;
using System.Threading.Tasks;
using Serilog;
using Microsoft.Extensions.Logging;
using API_BlogPlatform.Utils;
using System.Data.SqlClient;

namespace API_BlogPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase

    {
        private readonly ILogger<BlogPostController> _logger;
        private readonly IBlogPostService _blogPostService;
        public BlogPostController(IBlogPostService blogPostService, ILogger<BlogPostController> logger)
        {
            _blogPostService = blogPostService;
            _logger = logger;
        }
        /// <summary>
        /// Adds a new blog post to the repository.
        /// </summary>
        /// <param name="blogPost"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] BlogPost blogPost)
        {
            try
            {
                if (Validator.ValidateBlogPost(blogPost))
                {
                    _logger.LogError(InfoMessages.ErrorBlogPostValue);
                    return BadRequest(new { message = InfoMessages.ErrorBlogPostValue });
                }
                await _blogPostService.AddBlogPost(blogPost);
                return Ok(blogPost);
            }
            catch (SqlException dbcEx)
            {
                // Handle more specific SqlException exception here.  
                _logger.LogError(dbcEx.Message, InfoMessages.DatabaseErrorBlog);
                return BadRequest(InfoMessages.DatabaseErrorBlog);
            }
            catch (Exception ex)
            {

                // Handle generic ones here.  
                _logger.LogError(ex.Message, InfoMessages.BlogPostValueExceptioError);
                return BadRequest(InfoMessages.BlogPostValueExceptioError);

            }


        }
        /// <summary>
        /// returns all the blogPost already stored in repository
        /// </summary>
        /// <returns>list of blogPost</returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listBlogPost = await _blogPostService.GetAllBlogPosts();
                if (listBlogPost == null || listBlogPost.Count() == 0)
                {
                    return Ok(new { message = InfoMessages.HttpGetnullErrorBlog });
                }
                return Ok(listBlogPost);
            }
            catch (SqlException dbcEx)
            {
                // Handle more specific SqlException exception here.  
                _logger.LogError(dbcEx.Message, InfoMessages.DatabaseErrorBlog);
                return BadRequest(InfoMessages.DatabaseErrorBlog);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, InfoMessages.ErrorBlogtHttpGet);
                return BadRequest(InfoMessages.ErrorBlogtHttpGet);

            }

        }


    }

}
