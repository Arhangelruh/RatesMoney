namespace RatesMoney.Models
{
	public class CashExchangeRates
	{
        /// <summary>
        /// Rate date.
        /// </summary>
		public DateTime RateDate { get; set; }

        /// <summary>
        /// Input Currency.
        /// </summary>
        public string FromCurrency { get; set; }

        /// <summary>
        /// Output Currency.
        /// </summary>
		public string ToCurrency { get; set; }
        
        /// <summary>
        /// Rate value.
        /// </summary>
        public string Rate { get; set; }
        
        /// <summary>
        /// Number of units.
        /// </summary>
        public int Units { get; set; }

        /// <summary>
        /// Value of reverce rate.
        /// </summary>
        public bool IsReverce { get; set; }

        /// <summary>
        /// Work place Id.
        /// </summary>
        public int CashOfficeId { get; set; }

        /// <summary>
        /// Rate category (2 - for cash).
        /// </summary>
       
        public int RateCategory { get; set; }
        /// <summary>
        /// Department id.
        /// </summary>
        public string DepartmentId { get; set; }

        /// <summary>
        /// Type of operation.
        /// </summary>
        public int RateOperationType { get; set; }

        /// <summary>
        /// Kind of rate for client.
        /// </summary>
        public int RateProductType { get; set; }

        /// <summary>
        /// Max value.
        /// </summary>
        public string LimitFrom { get; set; }
    }
}
