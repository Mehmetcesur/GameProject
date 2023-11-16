using Business.Absracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ValidationManager : IValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear >= 1994 && gamer.IdentityNo.Length== 11 )
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
