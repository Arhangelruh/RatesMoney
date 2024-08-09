namespace RatesMoney.Models
{
	public class ApiAnswer
	{
        /// <summary>
        /// Rates.
        /// </summary>
        public List<CashExchangeRates> CashExchangeRates { get; set; }

        /// <summary>
        /// Metadata.
        /// </summary>
        public ResponseBase ResponseBase { get; set; }
    }
}
