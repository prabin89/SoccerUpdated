﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoccerUpdated.Models
{
    public class League
    {
        public int Id { get; set; }
        
        [MaxLength(255)]
        public string Name { get; set; }
        public DateTime? Founded { get; set; }
        public string Description { get; set; }
        public IList<Club> Clubs { get; set; }
    }
}