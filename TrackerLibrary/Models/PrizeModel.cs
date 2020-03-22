using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// Unique indentifier for prize.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Numeric indetifier for place(1 = first place, 2 = second, etc)
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// indentifier for the place (first place, second, etc)
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Amount for the price // 0 = it's not used
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents percentage for the prize amount
        /// 0 = not used
        /// Fraction of 1. (0.5 = 50%)
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;

            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;

        }


    }
}
