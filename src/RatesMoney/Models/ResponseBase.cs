namespace RatesMoney.Models
{
	public class ResponseBase
	{
		/// <summary>
		/// Result string "Success" or "Failure".
		/// </summary>
        public string Result { get; set; }
		
		/// <summary>
		/// Error code.
		/// </summary>
        public string ErrorCode { get; set; }

		/// <summary>
		/// Problem description.
		/// </summary>
        public string Message { get; set; }

		/// <summary>
		/// Some message number.
		/// </summary>
        public string DocRefNumber { get; set; }

		/// <summary>
		/// Operation DateTime.
		/// </summary>
		public DateTime DocDateTime { get; set; }

		/// <summary>
		/// Doesn't have description.
		/// </summary>
        public string FeeAmount { get; set; }

		/// <summary>
		/// Doesn't have description.
		/// </summary>
		public string PrintForms { get; set; }

		/// <summary>
		/// Doesn't have description.
		/// </summary>
		public string CardAmounts { get; set; }

		/// <summary>
		/// Doesn't have description.
		/// </summary>
		public string AcceptCode { get; set; }

		/// <summary>
		/// Doesn't have description.
		/// </summary>
		public string CorrelationId { get; set; }
    }
}
