using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        ///Represents one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents score for particular team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents matchup this team came from as winner
        /// 
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
