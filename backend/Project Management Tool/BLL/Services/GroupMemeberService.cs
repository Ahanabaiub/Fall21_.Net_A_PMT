using AutoMapper;
using BEL.DTO;
using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class GroupMemeberService
    {
        public static List<GroupMemberM> GetAllMemnersByGrpId(int grp_id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Group_members, GroupMemberM>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.GroupMemeberDataAcees();
            var data = mapper.Map<List<GroupMemberM>>(da.getGroupMembersByGrpId(grp_id));


            return data;
        }
    }
}
