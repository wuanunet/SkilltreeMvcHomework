using SkilltreeMvcHomework.Services;
using SkilltreeMvcHomework.ViewModels;
using System.Web.Mvc;

namespace SkilltreeMvcHomework.Controllers
{
    public class AccountingController : Controller
    {
        private readonly IAccountingService _accountingService;

        public AccountingController(IAccountingService accountingService)
        {
            this._accountingService = accountingService;
        }

        public ActionResult Manage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Manage(AccountingViewModel pageData)
        {
            if (!ModelState.IsValid)
            {
                return View(pageData);
            }

            var result = this._accountingService.Create(pageData);

            return RedirectToAction("Manage");
        }

        [ChildActionOnly]
        public ActionResult History()
        {
            var result = this._accountingService.GetData();

            return View(result);
        }
    }
}