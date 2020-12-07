using System.Collections.Generic;
using Forum.Models;

namespace Forum.Repositories
{
    public interface ICommentRepository
    {
        Comment CreateComment(Comment newComment, string userId, int postId);
        bool DeleteComment(int id);
        ICollection<Comment> GetAllComments();
        Comment GetComment(int id);
        Comment UpdateComment(Comment updatedComment);
    }
}