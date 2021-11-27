using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class MemberApplicationRepo : IRepository<member_application,int>
    {
        PMTEntities db;

        public MemberApplicationRepo(PMTEntities db)
        {
            this.db = db;
        }


        public void Add(member_application e)
        {
            db.member_application.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var s = db.member_application.FirstOrDefault(e => e.id == id);
            db.member_application.Remove(s);
            db.SaveChanges();
        }

        public void Edit(member_application e)
        {
            var s = db.member_application.FirstOrDefault(en => en.id == e.id);
            db.Entry(s).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<member_application> Get()
        {
            return db.member_application.ToList();
        }

        public member_application Get(int id)
        {
            return db.member_application.FirstOrDefault(e => e.id == id);
        }
    }
}
