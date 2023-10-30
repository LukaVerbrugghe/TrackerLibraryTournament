using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibraryTournament {
    public class TournamentModel {
        public string TournamentName { get; set; }
        public decimal EntryFee { get; set; }
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        public List<PriceModel> Prizes { get; set; } = new List<PriceModel>();
        public List<List<MathcupModel>> Rounds { get; set; } = new List<List<MathcupModel>>();
    }
}
