using Flurl;
using Flurl.Http;
using RatesMoney.Constants;
using RatesMoney.Models;
using System.Net;

namespace RatesMoney.Services
{
	public class ApiService
	{
		public static async Task<ApiAnswer?> GetCurrentRatesAsync()
		{
			var apiModel = await AppConfiguration.GetApiSettings();
			var url = apiModel.ApiPath + ApiMethodsConstants.ActualCashExchangeRates;
			var workplaceCode = await AppConfiguration.GetWorkplaceCode();

			try
			{
				FlurlHttp.Clients.WithDefaults(builder => builder
			  .ConfigureInnerHandler(handler =>
			   {				   
					   handler.ServerCertificateCustomValidationCallback = (_, _, _, _) => true;				   
			   }));

				var result = await url
				.WithBasicAuth(PreferenceConstants.ApiUser, PreferenceConstants.ApiPassword)
				.SetQueryParams(new { CashOfficeId = workplaceCode })
				.GetJsonAsync<ApiAnswer>();

				return result;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				return null;
			}
		}
	}
}
