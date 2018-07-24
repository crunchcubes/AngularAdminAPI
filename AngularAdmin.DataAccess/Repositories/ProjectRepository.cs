using AngularAdmin.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AngularAdmin.DataAccess.Repositories
{
    public class ProjectRepository : GenericRepository<Task>
    {
        public ProjectRepository()
        {
            
        }

        public IEnumerable<Project> GetAllProjects()
        {
            List<Project> projects = db.Project.ToList();
            return projects;
        }

        public static object GetAllProjectResult()
        {
            ProjectRepository repository = new ProjectRepository();
            var projects = repository.GetAllProjects();

            var projectsResult = from project in projects
                              select new
                              {
                                  id = project.ProjectID,
                                  projectName = project.ProjectName
                              };

            return new { projects = projectsResult };
        }
    }
}
