using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOne
{
    interface IUserService
    {
        void UserCreate(User user);
        void UserDelete(User user);
        void UserUpdate(User user);

    }
}
