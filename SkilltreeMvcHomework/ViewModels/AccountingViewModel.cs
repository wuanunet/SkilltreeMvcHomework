using System;
using System.ComponentModel.DataAnnotations;

namespace SkilltreeMvcHomework.ViewModels
{
    public class AccountingViewModel
    {
        [Display(Name = "類別")]
        public AccountingTypeEnum Type { get; set; }

        [Required]
        [Display(Name = "金額")]
        public int Cost { get; set; }

        [Display(Name = "備註")]
        public string Remark { get; set; }

        [Required]
        [UIHint("DateTime")]
        [Display(Name = "日期")]
        public DateTime CreateTime { get; set; }
    }
}