using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOne
{
    class UserValidateManager : IUserValidateService
    {
        public bool Validate(User user)
        {
            if (user.UserName == "Efe" && user.IdentityNumber == 12345678910 && user.BirthYear == 1995)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
