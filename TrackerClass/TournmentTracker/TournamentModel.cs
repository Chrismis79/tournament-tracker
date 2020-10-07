using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker
{
    public class TournamentModel
    {
        public List<PersonModel> TournamentName { get; set; } = new List<PersonModel>();
        public decimal EntryFee { get; set; }
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

    }

}