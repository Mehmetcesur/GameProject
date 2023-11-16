﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Gamer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string IdentityNo { get; set; }

        public int BirthYear { get; set; }

        public List<Game> PurchasedGames { get; set; } = new List<Game>();
    }
}
