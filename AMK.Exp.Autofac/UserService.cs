using System;
using System.Collections.Generic;
using System.Text;

namespace AMK.Exp.Autofac
{
    internal class UserService
    {
        private readonly INotificationService _notificationService;

        public UserService(INotificationService notificationService) { 
            _notificationService = notificationService;

        }

        public void ChangeUsername(User user, string username)
        {
            user.Username = username;
            _notificationService.NotifyUsernameChanged(username);
        }
    }
}
