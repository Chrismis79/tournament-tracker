using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker
{
    public class MatchupModel
    {
        public List<MatchEntryModel> Entries { get; set; } = new List<MatchupModel>();
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }

    }

}