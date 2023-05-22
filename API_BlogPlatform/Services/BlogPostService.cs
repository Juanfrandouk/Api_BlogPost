using API_BlogPlatform.Domain.IRepositories;
using API_BlogPlatform.Domain.IServices;
using API_BlogPlatform.Domain.Models;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API_BlogPlatform.Services
{
    /// <summary>
    /// Implementacion  de  Interface IBlogPostService
    /// </summary>
    public class BlogPostService : IBlogPostService
    {
        private readonly IBlogPostRepository _blogPostRepository;
        ILogger<BlogPostService> _logger;
        public BlogPostService(IBlogPostRepository blogPostRepository, ILogger<BlogPostService> logger)
        {
            _blogPostRepository = blogPostRepository;
            _logger = logger;
        }
        public async Task AddBlogPost(BlogPost blogPost)
        {
            try
            {
                await _blogPostRepository.AddBlogPost(blogPost);
            }
            catch (System.Exception)
            {

                throw;
            }

        }

        public async Task<IEnumerable<BlogPost>> GetAllBlogPosts()
        {
            return await _blogPostRepository.GetAllBlogPosts();
        }
    }
}
