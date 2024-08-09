namespace RatesMoney.ViewModels
{
	public class RateViewModel
	{
        /// <summary>
        /// From currency field.
        /// </summary>
        public string? FromCurrency { get; set; }

        /// <summary>
        /// To currency field.
        /// </summary>
        public string? ToCurrency { get; set; }

        /// <summary>
        /// Buy rate.
        /// </summary>
        public string? BuyRate { get; set; }

        /// <summary>
        /// Sell rate.
        /// </summary>
        public string? SellRate { get; set; }

        /// <summary>
        /// Rate units.
        /// </summary>
        public int Units { get; set; }

        /// <summary>
        /// Rate type.
        /// </summary>
        public int RateType { get; set; }
    }
}
