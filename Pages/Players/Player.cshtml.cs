using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using League.Data;
using League.Models;

namespace League.Pages.Players
{
    public class PlayerModel : PageModel
    {
        private readonly LeagueContext _context;
        [BindProperty(SupportsGet =true)]
        public string PlayerId { get; set; }
        public Player Player { get; set; }
        public PlayerModel(LeagueContext context)
        {
            _context = context;
        }
        public async Task OnGetAsync(string PlayerId)
        {
            Player = await _context.Players.FindAsync(PlayerId);
        }
    }
}
