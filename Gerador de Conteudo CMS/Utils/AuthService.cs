using System.Collections.Generic;
using ContentManagementSystem.Models;

namespace ContentManagementSystem.Utils
{
    public class AuthService
    {
        private List<User> users = new List<User>();

        public void Register(string username, string password)
        {
            // Aqui você pode implementar a lógica de registro
        }

        public User Login(string username, string password)
        {
            // Aqui você pode implementar a lógica de login
            return null; // Retornar usuário autenticado
        }
    }
}
