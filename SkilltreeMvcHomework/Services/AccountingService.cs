using SkilltreeMvcHomework.Models;
using SkilltreeMvcHomework.Repositories;
using SkilltreeMvcHomework.ViewModels;
using System;
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

        public IResult Create(AccountingViewModel pageData)
        {
            var result = new Result(false);

            if (pageData == null)
            {
                throw new ArgumentException(nameof(pageData));
            }

            try
            {
                var accountBook = new AccountBook
                {
                    Id = Guid.NewGuid(),
                    Amounttt = (int)pageData.Cost,
                    Categoryyy = (int)pageData.Type,
                    Remarkkk = pageData.Remark,
                    Dateee = pageData.CreateTime
                };

                this._accountingRepository.Create(accountBook);
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Exception = ex;
            }

            return result;
        }

        public IEnumerable<AccountingViewModel> GetData()
        {
            var result = this._accountingRepository.GetAll()
                                                   .OrderByDescending(s => s.Dateee)
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