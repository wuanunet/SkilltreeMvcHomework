using SkilltreeMvcHomework.ViewModels;
using System.Collections.Generic;

namespace SkilltreeMvcHomework.Services
{
    public interface IAccountingService
    {
        IResult Create(AccountingViewModel pageData);

        IEnumerable<AccountingViewModel> GetData();
    }
}