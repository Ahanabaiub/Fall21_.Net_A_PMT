using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class GroupMemberRepo: IRepository<Group_members,int>
    {
        PMTEntities db;

        public GroupMemberRepo(PMTEntities db)
        {
            this.db = db;
        }

        public void Add(Group_members e)
        {
            db.Group_members.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var s = db.Group_members.FirstOrDefault(e => e.id == id);
            db.Group_members.Remove(s);
            db.SaveChanges();
        }

        public void Edit(Group_members e)
        {
            var s = db.Group_members.FirstOrDefault(en => en.id == e.id);
            db.Entry(s).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Group_members> Get()
        {
            return db.Group_members.ToList();
        }

        public Group_members Get(int id)
        {
            return db.Group_members.FirstOrDefault(e => e.id == id);
        }


        public List<Group_members> getGroupMembersByGrpId(int grp_id)
        {
            return db.Group_members.Where(e=>e.group_id==grp_id).ToList();
        }
    }
}
