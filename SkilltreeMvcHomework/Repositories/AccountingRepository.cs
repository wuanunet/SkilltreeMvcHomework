using SkilltreeMvcHomework.Models;
using System.Linq;

namespace SkilltreeMvcHomework.Repositories
{
    public class AccountingRepository : IAccountingRepository
    {
        private SkillTreeHomeworkDBEntities dbContext = new SkillTreeHomeworkDBEntities();

        public void Create(AccountBook instance)
        {
            dbContext.AccountBook.Add(instance);
            dbContext.SaveChanges();
        }

        public IQueryable<AccountBook> GetAll()
        {
            var result = dbContext.AccountBook;

            return result;
        }
    }
}