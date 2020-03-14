using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //Load text file
            //Convert text to List<PrizeModel>
            //Find ID
            //Add new Record w/ new ID (max + 1)
            //Convert prizes to List<string>
            //Save list<string> to txt file.
        }
    }
}
