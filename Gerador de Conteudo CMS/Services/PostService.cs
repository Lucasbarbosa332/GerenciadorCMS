using System.Collections.Generic;
using ContentManagementSystem.Models;

namespace ContentManagementSystem.Services
{
    public class PostService
    {
        private List<Post> posts = new List<Post>();

        public void CreatePost(Post post)
        {
            posts.Add(post);
        }

        public List<Post> GetAllPosts()
        {
            return posts;
        }

        public void UpdatePost(int id, string content)
        {
            var post = posts.Find(p => p.Id == id);
            if (post != null)
            {
                post.VersionHistory.Add(post.Content); // Salva a versão anterior
                post.Content = content;
                post.UpdatedAt = DateTime.Now;
            }
        }

        public Post GetPost(int id)
        {
            return posts.Find(p => p.Id == id);
        }
    }
}
