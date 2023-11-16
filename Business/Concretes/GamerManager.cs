using Business.Absracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{      
      
    public class GamerManager : IGamerService
    {
        private IValidationService _validationService;

        public GamerManager(IValidationService validationService)
        {
                _validationService = validationService;
        }

        public void Add(Gamer gamer)
        {
            if (_validationService.Validate(gamer)==true)
            {
                Console.WriteLine("Doğrulama başaralı kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine( "Kullanıcı Silindi" );

        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı Güncellendi");

        }
    }
}
