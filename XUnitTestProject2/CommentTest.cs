using Forum.Data;
using Forum.Models;
using Forum.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using XUnitTestProject;

namespace XUnitTestProject
{
    public class CommentTest
    {
        private readonly ApplicationDbContext _context;
        private readonly static Random _random = new Random();
        private readonly ICommentRepository _repo;
        private readonly IPostRepository _repoPost;
        private readonly ApplicationUser admin;

        public CommentTest()
        {
            _context = new Context(new Microsoft.EntityFrameworkCore.DbContextOptions<ApplicationDbContext>());
            _repo = new CommentRepository(_context);
            _repoPost = new PostRepository(_context);

            admin = new ApplicationUser()
            {
                UserName = "admin@admin.com"
            };
            _context.ApplicationUsers.Add(admin);
            _context.SaveChanges();
        }

        [Fact]
        public void CreateCommentTest()
        {
            Comment newComment = CreateDummyComment();
            Comment c = _context.Comments.Find(newComment.CommentId);
            Assert.True(c != null);
        }

        [Fact]
        public void RetrieveCommentTest()
        {
            Comment newComment = CreateDummyComment();
            Comment c = _repo.GetComment(newComment.CommentId);
            Assert.True(c != null);
        }

        [Fact]
        public void UpdateCommentTest()
        {
            Comment newComment = CreateDummyComment();
            newComment.Content = "Test update";
            Comment updatedComment = _repo.UpdateComment(newComment);
            Assert.True(updatedComment.Content == "Test update");
        }

        [Fact]
        public void DeleteCommentTest()
        {
            Comment newComment = CreateDummyComment();
            bool confirmSuccessfulInsert = _repo.GetComment(newComment.CommentId) != null;
            bool confirmDeletion = _repo.DeleteComment(newComment.CommentId);
            Assert.True(confirmSuccessfulInsert == true && confirmDeletion == true);
        }

        public Comment CreateDummyComment()
        {
            int id = _random.Next();
            Comment newComment = new Comment()
            {
                CommentId = id,
                Content = "Test",
                CreatedOn = DateTime.Now
            };
            Post newPost = CreateDummyPost();
            _repo.CreateComment(newComment, admin.UserName, newPost.PostId);
            return newComment;
        }

        public Post CreateDummyPost()
        {
            int id = _random.Next();
            Post newPost = new Post()
            {
                PostId = id,
                Title = "Test",
                Content = "Test",
                CreatedOn = DateTime.Now
            };
            _repoPost.CreatePost(newPost, admin.UserName);
            return newPost;
        }
    }
}
