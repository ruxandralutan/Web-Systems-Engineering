using Forum.Data;
using Forum.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Repositories
{
    public class PostRepository : IPostRepository
    {
        private ApplicationDbContext _context;


        public PostRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Post CreatePost(Post newPost, string uname)
        {
            newPost.CreatedOn = DateTime.Now;

            ApplicationUser user = _context.ApplicationUsers.Where(m => m.UserName == uname).First();
            newPost.User = user;
            _context.Posts.Add(newPost);
            _context.SaveChanges();
            return newPost;
        }
        
        public Post GetPost(int id)
        {
            Post post = _context.Posts
                            .Include(p => p.User)
                            .Include(p => p.Comments).ThenInclude(comment => comment.User)
                            .FirstOrDefault(m => m.PostId == id); 
            if(post.Comments == null)
            {
                post.Comments = new List<Comment>();
            }
            return post;
        }

        public IEnumerable<Post> GetAllPosts()
        {
            IEnumerable<Post> posts = _context.Posts.Include(p => p.User).Include(p => p.Comments).Include(p => p.Comments).ToList();
            return posts;
        }

        public Post UpdatePost(Post updatedPost)
        {
            Post originalPost = _context.Posts.FirstOrDefault(p => p.PostId == updatedPost.PostId);
            originalPost.Title = updatedPost.Title;
            originalPost.Content = updatedPost.Content;
             _context.SaveChanges();
            return updatedPost;
        }

        public bool DeletePost(int id)
        {
            Post deletedPost = _context.Posts.Include(p => p.Comments).FirstOrDefault(m => m.PostId == id);
            if (deletedPost != null)
            {
                _context.Posts.Remove(deletedPost);
                foreach(Comment com in deletedPost.Comments)
                {
                    _context.Comments.Remove(com);
                }
                _context.SaveChanges();
            }
            return (_context.Posts.Find(id) == null);
        }

        public void CreateDummyPost()
        {

        }
    }
}
