using AutoMapper;
using BEL.DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class GroupService
    {

        public static List<GroupM> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Group, GroupM>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.GroupDataAcees();
            var data = mapper.Map<List<GroupM>>(da.Get());
            return data;
        }

        public static GroupM Get(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Group, GroupM>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.GroupDataAcees();
            var data = mapper.Map<GroupM>(da.Get(id));
            return data;
        }

        public static void Add(GroupM s)
        {
           
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<GroupM, Group>();


            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Group>(s);
            DataAccessFactory.GroupDataAcees().Add(data);
        }

        public static GroupM getGroupByProjectId(int project_id)
        {

            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Group, GroupM>();

            });
            var groups = DataAccessFactory.GroupDataAcees().Get();
            Group group= new Group();
            foreach (var g in groups)
            {
                if(g.project_id == project_id)
                {
                    group = g;
                    break;
                }
            }

            var mapper = new Mapper(config);
            var grp = mapper.Map<GroupM>(group);

            return grp;
        }

      
    }
}
