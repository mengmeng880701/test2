using Repository.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Database
{
    public class TStudent:CD
    {
    public string Name { get; set; }

    public string phone { get; set; }

    public long TeacherId { get; set; }

    public virtual TTeacher Teacher { get; set; }


    public long MajorId { get; set; }

    public virtual TMajor Major { get; set; }

    }
}
