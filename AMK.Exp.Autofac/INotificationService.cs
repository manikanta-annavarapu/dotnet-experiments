using System;
using System.Collections.Generic;
using System.Text;

namespace AMK.Exp.Autofac
{
    internal interface INotificationService
    {
        void NotifyUsernameChanged(string username);
    }
}
