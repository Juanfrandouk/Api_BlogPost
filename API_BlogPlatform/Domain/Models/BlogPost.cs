using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_BlogPlatform.Domain.Models
{
    /// <summary>
    /// Main class in  model
    /// </summary>
    public class BlogPost
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Title { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string Content { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string Author { get; set; }

    }
}
