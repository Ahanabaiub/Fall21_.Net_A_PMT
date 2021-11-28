using BEL.DTO;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Project_Management_Tool_api.Controllers
{
    [EnableCors("http://localhost:3000", "*", "*")]
    public class ProjectController : ApiController
    {
        [Route("api/project/All")]
        [HttpGet]
        public List<ProjectM> GetAll()
        {
            return ProjectService.Get();
        }
    }
}
