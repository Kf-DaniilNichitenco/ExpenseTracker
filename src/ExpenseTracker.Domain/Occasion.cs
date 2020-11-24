﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Domain
{
    public class Occasion : BaseEntity
    {
        public DateTime OccasionDate { get; set; } = DateTime.Now;
        public string Title { get; set; }
        public string Context { get; set; }
    }
}
