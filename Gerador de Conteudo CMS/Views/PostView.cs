using System;
using System.Collections.Generic;
using ContentManagementSystem.Models;
using ContentManagementSystem.Utils;

namespace ContentManagementSystem.Views
{
    public class PostView
    {
        public void DisplayPosts(List<Post> posts)
        {
            string html = HtmlHelper.RenderPostList(posts);
            Console.WriteLine(html);
        }
    }
}
