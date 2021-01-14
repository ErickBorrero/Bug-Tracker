using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class BugModel
    {
        public int BugId { get; set; }

        public DateTime DateCreated { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public string ConfirmationStatus { get; set; }

        public string Category { get; set; }

    }
}
