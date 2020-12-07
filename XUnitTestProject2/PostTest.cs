using Forum.Data;
using Forum.Models;
using Forum.Repositories;
using System;
using Xunit;
using XUnitTestProject;

namespace XUnitTestProject
{
    public class PostTest
    {

        private readonly ApplicationDbContext _context;
        private readonly static Random _random = new Random();
        private readonly IPostRepository _repo;
        private readonly ApplicationUser admin;

        public PostTest()
        {
            _context = new Context(new Microsoft.EntityFrameworkCore.DbContextOptions<ApplicationDbContext>());
            _repo = new PostRepository(_context);

            admin = new ApplicationUser()
            {
                UserName = "admin@admin.com"
            };
            _context.ApplicationUsers.Add(admin);
            _context.SaveChanges();
        }

        [Fact]
        public void CreatePostTest()
        {
            Post newPost = CreateDummyPost();
            Post p = _context.Posts.Find(newPost.PostId);
            Assert.True(p != null);
        }

        [Fact]
        public void RetrievePostTest()
        {
            Post newPost = CreateDummyPost();
            Post p = _repo.GetPost(newPost.PostId);
            Assert.True(p != null);
        }

        [Fact]
        public void UpdatePostTest()
        {
            Post newPost = CreateDummyPost();
            newPost.Title = "Test2";
            Post updatedPost = _repo.UpdatePost(newPost);
            Assert.True(updatedPost.Title == "Test2");
        }

        [Fact]
        public void DeletePostTest()
        {
            Post newPost = CreateDummyPost();
            bool confirmSuccessfulInsert = _repo.GetPost(newPost.PostId) != null;
            bool confirmDeletion = _repo.DeletePost(newPost.PostId);
            Assert.True(confirmSuccessfulInsert == true && confirmDeletion == true);
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
            _repo.CreatePost(newPost, admin.UserName);
            return newPost;
        }
    }
}
