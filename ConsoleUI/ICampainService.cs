using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject
{
    interface ICampainService
    {
        void AddCampain(Campain campain);
        void DeleteCampain(Campain campain);
        void UptadeCampain(Campain campain);
    }
}
