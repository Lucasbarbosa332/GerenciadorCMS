using System;
using System.Collections.Generic;

namespace ContentManagementSystem.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public List<string> Tags { get; set; }
        public Category Category { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<string> VersionHistory { get; set; } // Para controle de versões

        public Post()
        {
            Tags = new List<string>();
            VersionHistory = new List<string>();
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
    }
}
