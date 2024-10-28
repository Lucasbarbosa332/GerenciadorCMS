using System;
using ContentManagementSystem.Models;
using ContentManagementSystem.Services;

namespace ContentManagementSystem.Controllers
{
    public class PostController
    {
        private PostService postService = new PostService();

        public void Run()
        {
            Console.WriteLine("Gerenciamento de Posts:");
            // Aqui você pode implementar a lógica para criar, listar e atualizar posts.
            // Exemplo: Criar um novo post
            var newPost = new Post
            {
                Id = 1,
                Title = "Meu Primeiro Post",
                Content = "Este é o conteúdo do meu primeiro post.",
                Category = new Category("Tecnologia")
            };
            postService.CreatePost(newPost);

            // Listar posts
            var posts = postService.GetAllPosts();
            foreach (var post in posts)
            {
                Console.WriteLine($"Título: {post.Title}, Conteúdo: {post.Content}");
            }
        }
    }
}
