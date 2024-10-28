using System;

namespace ContentManagementSystem.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public User Author { get; set; }
        public Post Post { get; set; }
        public DateTime CreatedAt { get; set; }

        public Comment(string content, User author, Post post)
        {
            Content = content;
            Author = author;
            Post = post;
            CreatedAt = DateTime.Now;
        }
    }
}
