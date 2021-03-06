﻿using SkilltreeMvcHomework.Attributes;
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
        [DataType(DataType.MultilineText)]
        [RegularExpression(@"^[\s\S]{0,100}$", ErrorMessage = "不能超過 100 的字")]
        public string Remark { get; set; }

        [Required]
        [UIHint("DateTime")]
        [Display(Name = "日期")]
        [DateTimeRange(ErrorMessage = "記帳時間不能超過今天")]
        public DateTime CreateTime { get; set; }
    }
}