using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOne
{
    class UserManager : IUserService
    {
        IUserValidateService _userValidateService;

        public UserManager(IUserValidateService userValidateService)
        {
            _userValidateService = userValidateService;
        }

        public void UserCreate(User user)
        {
            if (_userValidateService.Validate(user))
            {
                Console.WriteLine(user.UserName + " isimli kullanıcı sisteme eklendi");
            }
            else
            {
                Console.WriteLine("Siz gerçek bir kişi değilsiniz");
            }
        }

        public void UserDelete(User user)
        {
            Console.WriteLine(user.UserName + " isimli kullanıcı silindi");
        }

        public void UserUpdate(User user)
        {
            Console.WriteLine(user.UserName + " isimli kullanıcı güncellendi");
        }
    }
}
