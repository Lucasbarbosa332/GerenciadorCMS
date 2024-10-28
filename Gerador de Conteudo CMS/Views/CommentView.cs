using System;
using System.Collections.Generic;
using ContentManagementSystem.Models;
using ContentManagementSystem.Utils;

namespace ContentManagementSystem.Views
{
    public class CommentView
    {
        public void DisplayComments(List<Comment> comments)
        {
            string html = HtmlHelper.RenderCommentList(comments);
            Console.WriteLine(html);
        }
    }
}
