using SkilltreeMvcHomework.Models;
using System.Linq;

namespace SkilltreeMvcHomework.Repositories
{
    public interface IAccountingRepository
    {
        void Create(AccountBook instance);

        IQueryable<AccountBook> GetAll();
    }
}