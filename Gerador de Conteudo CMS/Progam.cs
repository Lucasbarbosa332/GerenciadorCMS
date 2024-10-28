using System;

namespace ContentManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Sistema de Gerenciamento de Conteúdo!");
            // Aqui você pode iniciar a lógica do seu CMS, como iniciar o console e interagir com os serviços
            // Por exemplo, inicializar o PostController
            var postController = new PostController();
            postController.Run();
        }
    }
}
