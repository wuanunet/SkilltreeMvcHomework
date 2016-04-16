using SkilltreeMvcHomework.Models;
using System.Linq;

namespace SkilltreeMvcHomework.Repositories
{
    public interface IAccountingRepository
    {
        IQueryable<AccountBook> GetAll();
    }
}