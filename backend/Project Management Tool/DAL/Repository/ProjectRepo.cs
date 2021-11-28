using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ProjectRepo : IRepository<Project, int>
    {
        PMTEntities db;

        public ProjectRepo(PMTEntities db)
        {
            this.db = db;
        }

        public void Add(Project e)
        {
            db.Projects.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var s = db.Projects.FirstOrDefault(e => e.id == id);
            db.Projects.Remove(s);
            db.SaveChanges();
        }

        public void Edit(Project e)
        {
            var s = db.Projects.FirstOrDefault(en => en.id == e.id);
            db.Entry(s).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Project> Get()
        {
            return db.Projects.ToList();
        }

        public Project Get(int id)
        {
            return db.Projects.FirstOrDefault(e => e.id == id);
        }
    }
}
