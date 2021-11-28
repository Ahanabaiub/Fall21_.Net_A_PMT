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
    public class ProjectService
    {
        enum projectStatus
        {
            Open,
            InProgress,
            Complete,
            Close
        }

        public static List<ProjectM> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Project, ProjectM>();
                c.CreateMap<Group, GroupM>();
                c.CreateMap<Group_members, GroupMemberM>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.ProjectDataAcees();
            var data = mapper.Map<List<ProjectM>>(da.Get());
            return data;
        }

        public static ProjectM Get(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Project, ProjectM>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.ProjectDataAcees();
            var data = mapper.Map<ProjectM>(da.Get(id));
            return data;
        }

        public static void Add(ProjectM s)
        {
            s.status = (int)projectStatus.Open;
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ProjectM, Project>();


            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Project>(s);
            DataAccessFactory.ProjectDataAcees().Add(data);
        }

        public static bool ConfirmProject(int id)
        {
            var project = Get(id);
            var group = GroupService.getGroupByProjectId(id);
            var countMember = GroupMemeberService.GetAllMemnersByGrpId(group.id).Count;


            if(project.status == (int)projectStatus.Open)
            {
                return true;
            }

            return false;
        }
    }
}
