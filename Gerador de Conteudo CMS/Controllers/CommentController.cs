using System;
using ContentManagementSystem.Models;
using ContentManagementSystem.Services;

namespace ContentManagementSystem.Controllers
{
    public class CommentController
    {
        private CommentService commentService = new CommentService();
        private UserService userService = new UserService(); // Para obter o autor

        public void AddComment(Post post)
        {
            Console.Write("Digite seu comentário: ");
            var content = Console.ReadLine();
            // Supondo que o usuário está autenticado, você deve obter o usuário atual.
            var currentUser = userService.GetAllUsers()[0]; // Apenas para exemplo, deve pegar o usuário autenticado
            var comment = new Comment(content, currentUser, post);
            commentService.AddComment(comment);
        }

        public void ListComments(Post post)
        {
            var comments = commentService.GetCommentsForPost(post);
            foreach (var comment in comments)
            {
                Console.WriteLine($"{comment.Author.Username}: {comment.Content} (em {comment.CreatedAt})");
            }
        }
    }
}
