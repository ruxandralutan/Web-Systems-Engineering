using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class Comment
    {
        public int CommentId { get; set; }

        [DisplayName("Comment Content")]
        [Required(ErrorMessage = "This field is mandatory!")]
        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }

        public ApplicationUser User { get; set; }
        public Post Post { get; set; }

    }
}
