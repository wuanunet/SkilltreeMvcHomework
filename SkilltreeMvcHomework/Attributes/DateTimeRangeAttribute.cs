using System;
using System.ComponentModel.DataAnnotations;

namespace SkilltreeMvcHomework.Attributes
{
    public class DateTimeRangeAttribute : RangeAttribute
    {
        public DateTimeRangeAttribute()
            : base(typeof(DateTime), DateTime.MinValue.ToString(), DateTime.Today.ToString())
        {
        }
    }
}