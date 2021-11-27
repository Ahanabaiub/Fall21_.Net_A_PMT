using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.DTO
{
    public class GroupMemberM
    {
        public int id { get; set; }
        public Nullable<int> group_id { get; set; }
        public Nullable<int> member_id { get; set; }
    }
}
