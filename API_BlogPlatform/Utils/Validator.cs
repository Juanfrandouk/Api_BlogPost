using API_BlogPlatform.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_BlogPlatform.Utils
{
    public class Validator
    {
        public static bool ValidateBlogPost(BlogPost blogpost)
        {
            if (string.IsNullOrWhiteSpace(blogpost.Author) ||
                string.IsNullOrWhiteSpace(blogpost.Content) ||
                string.IsNullOrWhiteSpace(blogpost.Title))
            {
                return true;
            }


            return false;
        }
    }
}
