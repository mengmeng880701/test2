﻿using Repository.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Database
{
    public class TMajor:CD
    {
        public string Name { get; set; }

        public string? Description { get; set; }

       

        public virtual List<TStudent> Students { get; set; }

        public virtual List<TTeacher> Teachers { get; set; }

    }
}
