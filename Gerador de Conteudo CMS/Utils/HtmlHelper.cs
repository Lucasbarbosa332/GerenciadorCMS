using System.Collections.Generic;
using System.Text;
using ContentManagementSystem.Models;

namespace ContentManagementSystem.Utils
{
    public static class HtmlHelper
    {
        public static string RenderPostList(List<Post> posts)
        {
            var sb = new StringBuilder();
            sb.Append("<ul>");

            foreach (var post in posts)
            {
                sb.Append("<li>");
                sb.Append($"<h3>{post.Title}</h3>");
                sb.Append($"<p>{post.Content}</p>");
                sb.Append($"<p><small>Categorias: {string.Join(", ", post.Categories)}</small></p>");
                sb.Append("</li>");
            }

            sb.Append("</ul>");
            return sb.ToString();
        }

        public static string RenderCommentList(List<Comment> comments)
        {
            var sb = new StringBuilder();
            sb.Append("<ul>");

            foreach (var comment in comments)
            {
                sb.Append("<li>");
                sb.Append($"<strong>{comment.Author.Username}:</strong> {comment.Content} <small>(em {comment.CreatedAt})</small>");
                sb.Append("</li>");
            }

            sb.Append("</ul>");
            return sb.ToString();
        }
    }
}
