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
    public class IndexModel : PageModel
    {
        private readonly BugTracker.Data.BugsContext _context;

        public IndexModel(BugTracker.Data.BugsContext context)
        {
            _context = context;
        }

        public IList<Bug> Bug { get;set; }

        public async Task OnGetAsync()
        {
            Bug = await _context.Bugs.ToListAsync();
        }
    }
}
