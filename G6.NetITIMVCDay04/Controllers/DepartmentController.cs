using G6.NetITIMVCDay04.Context;
using Microsoft.AspNetCore.Mvc;

namespace G6.NetITIMVCDay04.Controllers
{
    public class DepartmentController : Controller
    {
        /*----------------------------------------------------*/
        // Context
        CompanyContext db = new CompanyContext();
        /*----------------------------------------------------*/
        [HttpGet]
        public IActionResult Index()
        {
            // DbSet of all Departments 
            var _Departments = db.Departments;
            return View(db.Departments);
        }
        /*----------------------------------------------------*/
        [HttpGet]
        public IActionResult ViewDetails(int id)
        {
            // Single Obj Department
            var _Department = db.Departments.FirstOrDefault(d => d.Id == id);
            return View(_Department);
        }
        /*----------------------------------------------------*/
    }
}
