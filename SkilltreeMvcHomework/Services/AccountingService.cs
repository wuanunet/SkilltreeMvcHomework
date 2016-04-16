using SkilltreeMvcHomework.Repositories;
using SkilltreeMvcHomework.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace SkilltreeMvcHomework.Services
{
    public class AccountingService : IAccountingService
    {
        private IAccountingRepository _accountingRepository;

        public AccountingService()
        {
            this._accountingRepository = new AccountingRepository();
        }

        public IEnumerable<AccountingViewModel> GetData()
        {
            var result = this._accountingRepository.GetAll()
                                                   .OrderBy(s => s.Dateee)
                                                   .Take(5)
                                                   .Select(s => new AccountingViewModel
                                                   {
                                                       Type = (AccountingTypeEnum)s.Categoryyy,
                                                       Cost = s.Amounttt,
                                                       CreateTime = s.Dateee,
                                                       Remark = s.Remarkkk
                                                   })
                                                   .ToList();

            return result;
        }
    }
}