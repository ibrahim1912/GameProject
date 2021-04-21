using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject
{
    class NewStateUserValidationManager : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            return true;
        }
    }
}
