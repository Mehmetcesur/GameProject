﻿using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Business.Absracts
{
    public interface IValidationService
    {
        bool Validate(Gamer gamer);

        
    }
}
