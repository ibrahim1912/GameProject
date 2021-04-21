using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject
{

    //simüle yer sanki edevletten çekiyoruz burayı
    class UserValidationManager : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            if (gamer.BirthYear == 1992 && gamer.FirstName == "İbrahim" && gamer.IdentityNumber == 123456)
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
