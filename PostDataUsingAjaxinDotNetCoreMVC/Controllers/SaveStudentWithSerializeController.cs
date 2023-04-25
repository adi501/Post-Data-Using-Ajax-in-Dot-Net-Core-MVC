using Microsoft.AspNetCore.Mvc;
using PostDataUsingAjaxinDotNetCoreMVC.Models;

namespace PostDataUsingAjaxinDotNetCoreMVC.Controllers
{
    public class SaveStudentWithSerializeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult SaveStudentWithSerialize(Student1 student1)
        {
            return Json("student saved successfully");
        }
    }
}
