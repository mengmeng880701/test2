﻿using Repository.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Database
{
    public class TClubStudent:CD
    {

        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public long StudentId { get; set; }

    }
}