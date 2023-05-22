using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_BlogPlatform.Utils
{
    public class InfoMessages
    {
        public const string ErrorBlogPostValue = "Blogpost field values can not be empty or null";
        public const string ErrorBlogPostValueException = "Error when trying to register a blog";
        public const string ErrorBlogtHttpGet = "Error when trying to retrueve a list of blog";
        public const string ErrorBlogtHttpGetnull = "There is not blog resgistered ";
    }
}
