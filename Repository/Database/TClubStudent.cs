using Repository.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Database
{
    public class TClubStudent:CD
    {

        

        


        public long ClubId { get; set; }
        public virtual TClub Club { get; set; }



        public long StudentId { get; set; }

       public virtual TStudent Student { get; set; }


        //此表與CLUB表為甚麼關係

        //一的表public virtual TStudent Student { get; set; }
        //多的表public virtual List<TClubStudent> TClubStudent { get; set; }

    }
}
