using System.ComponentModel.DataAnnotations.Schema;

namespace SkilltreeMvcHomework.Models
{
    [Table("AccountBook")]
    public partial class AccountBook
    {
        public System.Guid Id { get; set; }

        public int Categoryyy { get; set; }

        public int Amounttt { get; set; }

        public System.DateTime Dateee { get; set; }

        public string Remarkkk { get; set; }
    }
}