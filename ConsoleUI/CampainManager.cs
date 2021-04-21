using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject
{
    class CampainManager : ICampainService
    {
        public void AddCampain(Campain campain)
        {
            Console.WriteLine("Kampanya eklendi");
        }

        public void DeleteCampain(Campain campain)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void UptadeCampain(Campain campain)
        {
            Console.WriteLine("Kampanya güncellendi");
        }
    }
}
