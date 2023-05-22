using API_BlogPlatform.Domain.IRepositories;
using API_BlogPlatform.Domain.Models;
using API_BlogPlatform.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_BlogPlatform.Persistence.Repositories
{
    /// <summary>
    /// Implementation for interface IBlogPostRepository  
    /// </summary>
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly ApiDbContext _context;
        public BlogPostRepository(ApiDbContext context)
        {
            _context = context;
        }
        public async Task AddBlogPost(BlogPost blogPost)
        {
            _context.BlogPost.Add(blogPost);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<BlogPost>> GetAllBlogPosts()
        {
            var listBlogPost = await _context.BlogPost.Select(o => new BlogPost
            {
                Id = o.Id,
                Title = o.Title,
                Content = o.Content,
                Author = o.Author
            }).ToListAsync();

            return listBlogPost;
        }
    }
}
