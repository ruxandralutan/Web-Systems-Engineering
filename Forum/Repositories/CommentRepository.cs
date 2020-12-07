using Forum.Data;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Forum.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private ApplicationDbContext _context;

        public CommentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Comment CreateComment(Comment newComment,string userId, int postId)
        {
            newComment.CreatedOn = DateTime.Now;
            newComment.Post = _context.Posts.Find(postId);
            ApplicationUser user = _context.ApplicationUsers.Where(m => m.UserName == userId).First();
            newComment.User = user;
            _context.Comments.Add(newComment);
            _context.SaveChanges();
            return newComment;
        }

        public Comment GetComment(int id)
        {
            return _context.Comments.FirstOrDefault(m => m.CommentId == id);
        }

        public ICollection<Comment> GetCommentsForPost(int postId)
        {
            ICollection<Comment> comments = null;
            foreach(Comment com in _context.Comments)
            {
                if (com.Post.PostId == postId)
                    comments.Add(com);
            }
            return comments;
        }

        public ICollection<Comment> GetAllComments()
        {
            ICollection<Comment> comments = _context.Comments.Include(u => u.User).Include(p => p.Post).ToList();
            return comments;
        }

        public Comment UpdateComment(Comment updatedComment)
        {
            Comment originalComment = _context.Comments.FirstOrDefault(c => c.CommentId == updatedComment.CommentId);
            originalComment.Content = updatedComment.Content;
            _context.SaveChanges();
            return updatedComment;
        }

        public bool DeleteComment(int id)
        {
            Comment deletedComment =  _context.Comments.Find(id);
            if (deletedComment != null)
            {
                _context.Comments.Remove(deletedComment);
                _context.SaveChanges();
            }
            return (_context.Comments.Find(id) == null);
        }
       
    }
}

