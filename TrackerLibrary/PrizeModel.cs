using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// The  unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The numeric identifier for the place, incremetn by 1
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// The friendly name for the place
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// th fixed amout this place earns or zero if it is not used
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// The number that represents the percentage of the overall take or
        /// zero if it is not used. The percentage is a fraction of 1 ( so 0.5 for 50%)
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
