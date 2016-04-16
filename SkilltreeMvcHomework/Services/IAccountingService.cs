using SkilltreeMvcHomework.ViewModels;
using System.Collections.Generic;

namespace SkilltreeMvcHomework.Services
{
    public interface IAccountingService
    {
        IEnumerable<AccountingViewModel> GetData();
    }
}