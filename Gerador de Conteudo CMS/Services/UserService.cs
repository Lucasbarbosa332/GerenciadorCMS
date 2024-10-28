using System.Collections.Generic;
using System.Linq;
using ContentManagementSystem.Models;

namespace ContentManagementSystem.Services
{
    public class UserService
    {
        private List<User> users = new List<User>();

        public void Register(User user)
        {
            // Aqui você deve implementar um método para hashear a senha antes de armazená-la
            users.Add(user);
        }

        public User Login(string username, string password)
        {
            // Aqui você deve comparar o hash da senha fornecida com o armazenado
            return users.FirstOrDefault(u => u.Username == username && u.PasswordHash == password);
        }

        public List<User> GetAllUsers()
        {
            return users;
        }
    }
}
