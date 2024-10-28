using System;
using System.Collections.Generic;
using ContentManagementSystem.Models;

namespace ContentManagementSystem.Views
{
    public class UserView
    {
        public void DisplayUsers(List<User> users)
        {
            foreach (var user in users)
            {
                Console.WriteLine($"Username: {user.Username}, Email: {user.Email}");
            }
        }
    }
}
