﻿using NPOI.SS.Formula.Functions;
using Repository.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Database
{
    public class TTeacher : CD
    {
        public string Name { get; set; }

        public string phone {  get; set; }

        public string? Email { get; set; }

        public string? Description { get; set; }

    }
}
