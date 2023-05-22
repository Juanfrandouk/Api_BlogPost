using API_BlogPlatform.Domain.IRepositories;
using API_BlogPlatform.Domain.IServices;
using API_BlogPlatform.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_BlogPlatform.Services
{
    public class BlogPostService : IBlogPostService
    {
        private readonly IBlogPostRepository _blogPostRepository;
        public BlogPostService(IBlogPostRepository blogPostRepository)
        {
            _blogPostRepository = blogPostRepository;
        }
        public async Task AddBlogPost(BlogPost blogPost)
        {
            await _blogPostRepository.AddBlogPost(blogPost);
        }

        public async Task<IEnumerable<BlogPost>> GetAllBlogPosts()
        {
            return await _blogPostRepository.GetAllBlogPosts();
        }
    }
}
