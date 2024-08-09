namespace RatesMoney.Constants
{
	public class RateAPIConstant
	{
		/// <summary>
		/// List of available currencies.
		/// </summary>
		public static List<string> rates = ["USD", "EUR", "RUB", "CNY", "UAH"];

		/// <summary>
		/// List of available converse curremcies
		/// </summary>
		public static List<string> converseRates = ["EUR/USD","USD/RUB","EUR/RUB","USD/CNY","EUR/CNY","CNY/RUB"];

		/// <summary>
		/// Type of operation for buy.
		/// </summary>
		public static int BuyType = 1;

		/// <summary>
		/// Type of operation for sell.
		/// </summary>
		public static int SellType = 2;

		/// <summary>
		/// Type of operation for convert.
		/// </summary>
		public static int ConvertType = 3;
	}
}
