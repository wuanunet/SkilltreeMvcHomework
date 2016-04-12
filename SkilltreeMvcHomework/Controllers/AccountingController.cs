using SkilltreeMvcHomework.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SkilltreeMvcHomework.Controllers
{
    public class AccountingController : Controller
    {
        private static List<AccountingViewModel> _accountingList = GetAccountingList();

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

            _accountingList.Add(pageData);

            return RedirectToAction("Manage");
        }

        [ChildActionOnly]
        public ActionResult History()
        {
            var result = _accountingList;

            return View(result);
        }

        private static List<AccountingViewModel> GetAccountingList()
        {
            var result = new List<AccountingViewModel>
            {
                new AccountingViewModel { Type = AccountingTypeEnum.Income, Cost = 30000, Remark = "薪資收入", CreateTime = new DateTime (2016, 04, 01) },
                new AccountingViewModel { Type = AccountingTypeEnum.Expend, Cost = 8000, Remark = "房租", CreateTime = new DateTime (2016, 04, 05) },
                new AccountingViewModel { Type = AccountingTypeEnum.Income, Cost = 200, Remark = "統一發票中獎", CreateTime = new DateTime (2016, 04, 05) },
            };

            return result;
        }
    }
}