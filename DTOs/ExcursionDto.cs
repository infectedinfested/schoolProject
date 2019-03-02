﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolProject.DTOs
{
    public class ExcursionDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int TeacherId { get; set; }
        public int StuddentId { get; set; }
        public bool present { get; set; }
    }
}
