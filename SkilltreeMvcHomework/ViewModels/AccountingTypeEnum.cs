using System.ComponentModel.DataAnnotations;

namespace SkilltreeMvcHomework.ViewModels
{
    public enum AccountingTypeEnum
    {
        [Display(Name = "支出")]
        Expend = 0,

        [Display(Name = "收入")]
        Income = 1
    }
}