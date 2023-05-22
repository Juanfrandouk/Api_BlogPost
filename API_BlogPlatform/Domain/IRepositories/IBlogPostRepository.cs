using API_BlogPlatform.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API_BlogPlatform.Domain.IRepositories
{
    /// <summary>
    /// Interface  for BlogPost class
    /// </summary>
    public interface IBlogPostRepository
    {
        Task<IEnumerable<BlogPost>> GetAllBlogPosts(); // Returns a list of all blog posts.
        Task AddBlogPost(BlogPost blogPost); // Adds a new blog post to the repository.

    }
}
