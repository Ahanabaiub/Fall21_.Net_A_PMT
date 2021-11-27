using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static PMTEntities db;

        static DataAccessFactory()
        {
            db = new PMTEntities();
        }

        public static IRepository<Project, int> ProjectDataAcees()
        {
            return new ProjectRepo(db);
        }
        public static IRepository<member_application, int> MemeberApplicationDataAcees()
        {
            return new MemberApplicationRepo(db);
        }
        public static IRepository<Group, int> GroupDataAcees()
        {
            return new GroupRepo(db);
        }
        public static IRepository<Group_members, int> GroupMemeberDataAcees()
        {
            return new GroupMemberRepo(db);
        }
    }
}
