using AngularAdmin.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AngularAdmin.DataAccess.Repositories
{
    public class TaskRepository : GenericRepository<Task>
    {
        public TaskRepository()
        {
            
        }
        public IEnumerable<Task> GetTasksByPageIndex(int pageIndex, int pageSize)
        {
            List<Task> tasks =  db.Task.ToList();
            return tasks;
        }

        public IEnumerable<Project> GetAllProjects()
        {
            List<Project> projects = db.Project.ToList();
            return projects;
        }

        public static object GetTasksByPageIndexResult(int pageIndex, int pageSize)
        {
            TaskRepository repository = new TaskRepository();

            var tasks = repository.GetTasksByPageIndex(0, 0);
            var projects = repository.GetAllProjects();

            var tasksResult = from task in tasks
                        join project in projects on task.ProjectID equals project.ProjectID
                        select new {
                                        id = task.TaskID,
                                        taskName = task.TaskName,
                                        taskDescription = task.TaskDescription,
                                        projectName = project.ProjectName
                                    };

            return new { tasks = tasksResult };
        }

        public static object AddTask(Task task)
        {
            TaskRepository repository = new TaskRepository();
            repository.db.Task.Add(task);
            return null;
        }
    }
}
