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

        [Required]
        //[MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string Title { get; set; }
        [Required]
        //[MaxLength(200)]
        [Column(TypeName = "varchar(200)")]
        public string Content { get; set; }
        [Required]
        //[MaxLength(200)]
        [Column(TypeName = "varchar(200)")]
        public string Author { get; set; }

    }
}
