using System.Collections.Generic;
using ContentManagementSystem.Models;

namespace ContentManagementSystem.Services
{
    public class CommentService
    {
        private List<Comment> comments = new List<Comment>();

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        public List<Comment> GetCommentsForPost(Post post)
        {
            return comments.FindAll(c => c.Post.Id == post.Id);
        }
    }
}
