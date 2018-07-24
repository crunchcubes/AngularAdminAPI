using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Cors;
using AngularAdmin.DataAccess.Repositories;
using AngularAdmin.DataAccess.Entities;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AngularAdmin.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class ProjectController : ApiController
    {
        //[System.Web.Http.HttpPost]
        public IHttpActionResult GetProjects()
        {
            var result = ProjectRepository.GetAllProjectResult();
            return Ok(result);
        }
    }
}