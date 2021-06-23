using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var notification = new ChangedUsername();
            User user1 = new User("Filipe", notification);
            user1.changeusername("rui");
        }
    }
}
