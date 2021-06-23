using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class User
    {
        private INotification _usernameChanged;

        public string Username { get; set; }
        public User(string username, INotification notification) 
        {
            Username = username;
            _usernameChanged = notification;
        }

        public void changeusername(string newusername) 
        {
            Username = newusername;
            _usernameChanged.ChangedUsernameNotification(this);
        }

    }
}
