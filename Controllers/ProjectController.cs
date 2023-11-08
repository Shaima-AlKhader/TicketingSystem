using Microsoft.AspNetCore.Mvc;
using TicketingSystem.Models;

namespace TicketingSystem.Controllers
{
    public class ProjectController : Controller
    {
        DBEntities.TicketingSystemContext context = new DBEntities.TicketingSystemContext();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddNewProject()
        {
            return View();
        }

        public IActionResult SaveNewProject(Models.ProjectModel projectModel)
        {
            DBEntities.Project project = new DBEntities.Project();

            project.ProjectName = projectModel.ProjectName;
            project.ClientName = projectModel.ClientName;
            project.ClientContactPerson = projectModel.ClientContactPerson;
            project.DeliverDate = projectModel.DeliverDate;
            project.IsUnderSupport = projectModel.IsUnderSupport;

            context.Projects.Add(project);
            context.SaveChanges();

            return RedirectToAction("GetAllProjects");
        }

        public IActionResult EditProject(int Id )
        {
            DBEntities.Project project= new DBEntities.Project();

            project = context.Projects.Where(x => x.ProjectId == Id).FirstOrDefault();

            Models.ProjectModel projectModel = new Models.ProjectModel();

            projectModel.ProjectId = project.ProjectId;
            projectModel.ProjectName = project.ProjectName;
            projectModel.ClientName = project.ClientName;
            projectModel.ClientContactPerson = project.ClientContactPerson;
            projectModel.DeliverDate = project.DeliverDate;
            projectModel.IsUnderSupport = project.IsUnderSupport;

            return View(projectModel);
        }

        public IActionResult UpdateProject(Models.ProjectModel projectModel)
        {
            DBEntities.Project project = new DBEntities.Project();

            project = context.Projects.Where(x => x.ProjectId == projectModel.ProjectId).FirstOrDefault();

            project.ProjectName = projectModel.ProjectName;
            project.ClientName = projectModel.ClientName;
            project.ClientContactPerson = projectModel.ClientContactPerson;
            project.DeliverDate = projectModel.DeliverDate;
            project.IsUnderSupport = projectModel.IsUnderSupport;

            context.SaveChanges();

            return RedirectToAction("GetAllProjects");
        }

        public IActionResult DeleteProject(int Id)
        {
            DBEntities.Project project = new DBEntities.Project();

            project = context.Projects.Where(x => x.ProjectId == Id).FirstOrDefault();

            context.Projects.Remove(project);
            context.SaveChanges();

            return RedirectToAction("GetAllProjects");
        }

        public IActionResult GetAllProjects()
        {
            List<Models.ProjectModel> lst = new List<Models.ProjectModel>();
            lst = ( from obj in context.Projects.ToList()
                    select new Models.ProjectModel()
                    {
                        ProjectId = obj.ProjectId,
                        ProjectName = obj.ProjectName,
                        ClientName = obj.ClientContactPerson,
                        ClientContactPerson = obj.ClientContactPerson,
                        DeliverDate = obj.DeliverDate,
                        IsUnderSupport = obj.IsUnderSupport

                    }).ToList();
            return View(lst);
        }
    }
}
