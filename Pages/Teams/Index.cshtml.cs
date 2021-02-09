using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using League.Data;
using League.Models;
using Microsoft.EntityFrameworkCore;

namespace League.Pages.Teams
{
    public class IndexModel : PageModel
    {
        private readonly LeagueContext _context;
        public List<Conference> Conferences { get; set; }
        public List<Division> Divisions { get; set; }
        public List<Team> Teams { get; set; }
        public List<Division> DivInConference { get; set; }
        public List<Team> TeamsInDiv { get; set; }

        public IndexModel(LeagueContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Conferences = await _context.Conferences.ToListAsync();
            Divisions = await _context.Divisions.ToListAsync();
            Teams = await _context.Teams.ToListAsync();
        }

        public List<Division> GetDivInConference(string id)
        {
            var divs = from div in Divisions
                              where div.ConferenceId == id
                              select div;
            DivInConference = divs.ToList();
            return DivInConference;
        }

        public List<Team> GetTeamInDivision(string id)
        {
            var teams = from team in Teams
                        where team.DivisionId == id
                        select team;
            TeamsInDiv = teams.ToList();
            return TeamsInDiv;
        }
    }
}
