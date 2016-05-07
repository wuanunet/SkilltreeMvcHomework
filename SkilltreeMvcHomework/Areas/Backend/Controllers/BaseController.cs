using System.Web.Mvc;

namespace SkilltreeMvcHomework.Areas.Backend.Controllers
{
    [Authorize(Users = "wuanunet@hotmail.com")]
    public class BaseController : Controller
    {
    }
}