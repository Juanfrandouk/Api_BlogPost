using API_BlogPlatform.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_BlogPlatform.Domain.IRepositories
{
    public interface IBlogPostRepository
    {
        IEnumerable<BlogPost> GetAllBlogPosts(); // Returns a list of all blog posts.
        void AddBlogPost(BlogPost blogPost); // Adds a new blog post to the repository.

    }
}
