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
        public void AddBlogPost(BlogPost blogPost)
        {
            _blogPostRepository.AddBlogPost(blogPost);
        }

        public IEnumerable<BlogPost> GetAllBlogPosts()
        {
            return _blogPostRepository.GetAllBlogPosts();
        }
    }
}
