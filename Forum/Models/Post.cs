using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class Post
    {
        public int PostId { get; set; }

        [DisplayName("Post Title")]
        [Required(ErrorMessage = "This field is mandatory!")]
        public string Title { get; set; }

        [DisplayName("Post Content")]
        [Required(ErrorMessage = "This field is mandatory!")]
        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ApplicationUser User { get; set; }
    }
}
