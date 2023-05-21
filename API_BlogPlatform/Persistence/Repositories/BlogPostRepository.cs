using API_BlogPlatform.Domain.IRepositories;
using API_BlogPlatform.Domain.Models;
using API_BlogPlatform.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_BlogPlatform.Persistence.Repositories
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly ApiDbContext _context;
        public BlogPostRepository(ApiDbContext context)
        {
            _context = context;
        }
        public void AddBlogPost(BlogPost blogPost)
        {
            _context.BlogPost.Add(blogPost);
            _context.SaveChanges();
        }

        public IEnumerable<BlogPost> GetAllBlogPosts()
        {
            var listBlogPost = _context.BlogPost.Select(o => new BlogPost
            {
                Id = o.Id,
                Title = o.Title,
                Content = o.Content,
                Author = o.Author
            }).ToList();

            return listBlogPost;
        }
    }
}
