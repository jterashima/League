using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using League.Data;
using League.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace League.Pages.Players
{
    public class IndexModel : PageModel
    {
        private readonly LeagueContext _context;
        public List<Player> Players { get; set; }
        public List<Team> Teams { get; set; }
        public SelectList Positions { get; set; }
        public string TeamName { get; set; }

        [BindProperty(SupportsGet =true)]
        public string SortString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTeam { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchPosition { get; set; }

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

            if (!String.IsNullOrEmpty(SortString))
            {
                switch (SortString)
                {
                    case "Number":
                        players = players.OrderBy(player => player.Number);
                        break;
                    case "Name":
                        players = players.OrderBy(player => player.Name);
                        break;
                    case "Position":
                        players = players.OrderBy(player => player.Position);
                        break;
                    default:
                        break;
                }
            }
            var positionQuery = from player in _context.Players
                                select player.Position;
            Positions = new SelectList(await positionQuery.Distinct().ToListAsync());
            
            if(!String.IsNullOrEmpty(SearchTeam))
            {
                players = from player in players
                          where player.TeamId == SearchTeam
                          select player;
            }
            if(!String.IsNullOrEmpty(SearchPosition))
            {
                players = from player in players
                          where player.Position == SearchPosition
                          select player;
            }

            Players = players.ToList();
        }

        public string FindTeam(string id)
        {
            TeamName = Teams.Find(team => team.TeamId == id).Name;
            return TeamName;
        }
    }
}
