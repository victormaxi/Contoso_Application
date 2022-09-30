using Microsoft.AspNetCore.Mvc;
using Web_app.Core.Interfaces;
using Web_app.Data;

namespace Contoso_Web_UI.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudents _student;

        public StudentsController(IStudents student)
        {
            _student = student;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _student.GetAll());
        }
    }
}
