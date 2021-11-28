using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.DTO
{
    public class ProjectM
    {

       
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> supervisor_id { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public string description { get; set; }
        public System.DateTime deadline { get; set; }
        public Nullable<int> status { get; set; }

        public virtual ICollection<GroupM> Groups { get; set; }
    }
}
