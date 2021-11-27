using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.DTO
{
    public class MemberApplicationM
    {
        public int id { get; set; }
        public Nullable<int> project_id { get; set; }
        public Nullable<int> member_id { get; set; }
        public Nullable<int> status { get; set; }
    }
}
