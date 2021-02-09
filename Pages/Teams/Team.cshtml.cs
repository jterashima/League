using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using League.Data;
using League.Models;

namespace League.Pages.Teams
{
    public class TeamModel : PageModel
    {
        private readonly LeagueContext _context;
        [BindProperty(SupportsGet =true)]
        public string TeamId { get; set; }
        public Team Team { get; set; }
        public TeamModel(LeagueContext context)
        {
            _context = context;
        }
        public async Task OnGetAsync()
        {
            Team = await _context.Teams.FindAsync(TeamId);
        }
    }
}
