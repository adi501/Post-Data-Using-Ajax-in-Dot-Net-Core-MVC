using Microsoft.AspNetCore.Mvc;
using PostDataUsingAjaxinDotNetCoreMVC.Models;

namespace PostDataUsingAjaxinDotNetCoreMVC.Controllers
{
    public class SaveStudentWithoutSerializeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult SaveStudentWithoutSerialize(Student student)
        {
            return Json("student saved successfully");
        }
    }
}
