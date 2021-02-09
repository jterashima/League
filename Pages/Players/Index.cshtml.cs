using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using League.Data;
using League.Models;
using Microsoft.EntityFrameworkCore;

namespace League.Pages.Players
{
    public class IndexModel : PageModel
    {
        private readonly LeagueContext _context;
        public List<Player> Players { get; set; }
        public List<Team> Teams { get; set; }
        public string TeamName { get; set; }

        public IndexModel(LeagueContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            //Get teams
            Teams = await _context.Teams.ToListAsync();

            //Get players
            var players = from player in _context.Players
                          select player;
            players = players.OrderBy(player => player.Name);

            Players = players.ToList();
        }

        public string FindTeam(string id)
        {
            TeamName = Teams.Find(team => team.TeamId == id).Name;
            return TeamName;
        }
    }
}
