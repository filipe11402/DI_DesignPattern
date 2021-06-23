using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class ChangedUsername: INotification
    {

        public void ChangedUsernameNotification(User user) 
        {
            Console.WriteLine("username was changed to: " + user.Username);
        }

    }
}
