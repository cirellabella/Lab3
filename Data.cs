using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public static class Data
    {
        public static List<Sunglasses> _sunglasses;
        public static List<User> _users;

        static Data()
        {
            _sunglasses = new List<Sunglasses>();
            _users = new List<User>();
        }

        public static List<Sunglasses> Sunglasses { get => _sunglasses; }
        public static List<User> User { get => _users; }

        public static void AddSunglasses(Sunglasses sunglasses)
        {
            _sunglasses.Add(sunglasses);
        }

        public static void AddUser(User user)
        {
            _users.Add(user);
        }
    }
}
