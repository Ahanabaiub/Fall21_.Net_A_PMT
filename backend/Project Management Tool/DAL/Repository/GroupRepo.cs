using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    class GroupRepo : IRepository<Group, int>
    {
        PMTEntities db;

        public GroupRepo(PMTEntities db)
        {
            this.db = db;
        }

        public void Add(Group e)
        {
            db.Groups.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var s = db.Groups.FirstOrDefault(e => e.id == id);
            db.Groups.Remove(s);
            db.SaveChanges();
        }

        public void Edit(Group e)
        {
            var s = db.Groups.FirstOrDefault(en => en.id == e.id);
            db.Entry(s).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Group> Get()
        {
            return db.Groups.ToList();
        }

        public Group Get(int id)
        {
            return db.Groups.FirstOrDefault(e => e.id == id);
        }
    }
}
