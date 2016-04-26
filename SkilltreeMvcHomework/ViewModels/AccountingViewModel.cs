using System;
using System.ComponentModel.DataAnnotations;

namespace SkilltreeMvcHomework.ViewModels
{
    public class AccountingViewModel
    {
        [Required]
        [Display(Name = "類別")]
        public AccountingTypeEnum Type { get; set; }

        [Required]
        [UIHint("Decimal")]
        [Display(Name = "金額")]
        [Range(0, int.MaxValue, ErrorMessage = "只能輸入正整數")]
        public decimal Cost { get; set; }

        [Required]
        [Display(Name = "備註")]
        public string Remark { get; set; }

        [Required]
        [UIHint("DateTime")]
        [Display(Name = "日期")]
        public DateTime CreateTime { get; set; }
    }
}