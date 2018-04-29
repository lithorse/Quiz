﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Models
{
    public class Score
    {
        public int Id { get; set; }
        //public int UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public int Points { get; set; }
    }
}
