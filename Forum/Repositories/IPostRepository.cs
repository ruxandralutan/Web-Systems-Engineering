using System.Collections.Generic;
using Forum.Models;

namespace Forum.Repositories
{
    public interface IPostRepository
    {
        Post CreatePost(Post newPost, string uname);
        bool DeletePost(int id);
        IEnumerable<Post> GetAllPosts();
        Post GetPost(int id);
        Post UpdatePost(Post updatedPost);
    }
}