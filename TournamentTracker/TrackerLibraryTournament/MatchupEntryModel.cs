using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TrackerLibraryTournament {
    public class MatchupEntryModel {
        /// <summary>
        /// Represents one  team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Reperesents the score of this particular team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Representss the matchup that this team came from as the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
