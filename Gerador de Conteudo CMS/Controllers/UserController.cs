using System;
using ContentManagementSystem.Models;
using ContentManagementSystem.Services;

namespace ContentManagementSystem.Controllers
{
    public class UserController
    {
        private UserService userService = new UserService();

        public void RegisterUser()
        {
            Console.Write("Digite o nome de usuário: ");
            var username = Console.ReadLine();
            Console.Write("Digite a senha: ");
            var password = Console.ReadLine();
            var user = new User(username, password, "Editor"); // Default para Editor
            userService.Register(user);
        }

        public void LoginUser()
        {
            Console.Write("Digite o nome de usuário: ");
            var username = Console.ReadLine();
            Console.Write("Digite a senha: ");
            var password = Console.ReadLine();
            var user = userService.Login(username, password);

            if (user != null)
            {
                Console.WriteLine($"Login bem-sucedido! Bem-vindo, {user.Username}.");
            }
            else
            {
                Console.WriteLine("Falha no login. Verifique seu nome de usuário e senha.");
            }
        }
    }
}
