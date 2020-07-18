﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoccerUpdated.Models
{
    public class League
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<Club> Clubs { get; set; }
    }
}