using API_BlogPlatform.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API_BlogPlatform.Domain.IServices
{
    /// <summary>
    /// Interface for  BlogPostService
    /// </summary>
    public interface IBlogPostService
    {
        Task<IEnumerable<BlogPost>> GetAllBlogPosts(); // Returns a list of all blog posts.
        Task AddBlogPost(BlogPost blogPost); // Adds a new blog post to the repository.
    }
}
