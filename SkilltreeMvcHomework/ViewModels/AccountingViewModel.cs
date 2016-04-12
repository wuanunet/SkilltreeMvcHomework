using System;
using System.ComponentModel.DataAnnotations;

namespace SkilltreeMvcHomework.ViewModels
{
    public class AccountingViewModel
    {
        [Display(Name = "類別")]
        public AccountingTypeEnum Type { get; set; }

        [Required]
        [UIHint("Decimal")]
        [Display(Name = "金額")]
        public decimal Cost { get; set; }

        [Display(Name = "備註")]
        public string Remark { get; set; }

        [Required]
        [UIHint("DateTime")]
        [Display(Name = "日期")]
        public DateTime CreateTime { get; set; }
    }
}