using System;
using System.ComponentModel.DataAnnotations;

namespace SkilltreeMvcHomework.ViewModels
{
    public class AccountingViewModel
    {
        [Range(1, int.MaxValue, ErrorMessage = "請至少選擇一項")]
        [Display(Name = "類別")]
        public AccountingTypeEnum Type { get; set; }

        [Display(Name = "金額")]
        public int Cost { get; set; }

        [Display(Name = "備註")]
        public string Remark { get; set; }

        [Display(Name = "日期")]
        public DateTime CreateTime { get; set; }
    }
}