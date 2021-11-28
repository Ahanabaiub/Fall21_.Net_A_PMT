using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.DTO
{
    public class GroupM
    {

        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> project_id { get; set; }

        public virtual ICollection<GroupMemberM> Group_members { get; set; }
    }
}
