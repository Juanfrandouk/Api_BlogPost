﻿namespace API_BlogPlatform.Domain.Models
{
    /// <summary>
    /// Main class in  model
    /// </summary>
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public string Author { get; set; }

    }
}
