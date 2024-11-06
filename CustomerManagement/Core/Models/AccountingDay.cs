using System.ComponentModel.DataAnnotations;

namespace CustomerManagement.Core.Models
{
    public class AccountingDay
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
    }
}
