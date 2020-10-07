using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker
{
    public class MatchupEntryModel
    {
        public TeamModel TeamCompeting { get; set; } = new List<PersonModel>();
        public double Score { get; set; }
        public MatchupModel ParentMatchup { get; set; }

    }

}