using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class Bug
    {
        [Key]
        public int BugId { get; set; }

        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }

        [Display(Name = "Date Resolved")]
        public DateTime? DateResolved { get; set; }

        [Required]
        public string Description { get; set; }

        public string Status { get; set; }

        public string ConfirmationStatus { get; set; }

        public string Category { get; set; }

    }
}
