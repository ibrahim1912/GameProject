using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject
{
    class GamerManager : IGamerService
    {

        //burda baska bir iş katmanını new lersek sıkıntı olur.o yuzden aşagıdaki çözümü yaparız

        IUserValidationService _userValidationService; //hareket1   //IUserValidationService baba gibi düşün kendi yorumum
        public GamerManager(IUserValidationService userValidationService)   //hareket2 constructor burda soyut yapıyı getiriyoruz bağımlılığı azaltmak için
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validation(gamer)==true)
            {
                Console.WriteLine("Kayıt olundu");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
