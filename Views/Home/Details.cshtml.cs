using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BugTracker.Data;
using BugTracker.Models;

namespace BugTracker.Views.Home
{
    public class DetailsModel : PageModel
    {
        private readonly BugTracker.Data.BugsContext _context;

        public DetailsModel(BugTracker.Data.BugsContext context)
        {
            _context = context;
        }

        public Bug Bug { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bug = await _context.Bugs.FirstOrDefaultAsync(m => m.BugId == id);

            if (Bug == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
