using RatesMoney.Constants;
using RatesMoney.ViewModels;

namespace RatesMoney.Services
{
	public class GetRates
	{
		public async Task<List<RateViewModel>> GetAllRatesAsync()
		{
			List<RateViewModel> currencies = [];

			var apiAnswer = await ApiService.GetCurrentRatesAsync();
			if (apiAnswer != null)
			{
				foreach (var rate in RateAPIConstant.rates)
				{
					var buyRate = apiAnswer.CashExchangeRates.FirstOrDefault(r => r.FromCurrency == rate && r.RateOperationType == RateAPIConstant.BuyType);
					if (buyRate != null)
					{						
						var sellRate = apiAnswer.CashExchangeRates.FirstOrDefault(r => r.ToCurrency == rate && r.RateOperationType == RateAPIConstant.SellType);
						if (sellRate != null)
						{
							currencies.Add(new RateViewModel
							{
								FromCurrency = buyRate.FromCurrency,
								ToCurrency = buyRate.ToCurrency,
								BuyRate = buyRate.Rate,
								SellRate = sellRate.Rate,
								Units = buyRate.Units,
								RateType = RateConstant.ChangeType
							});
						}
					}
				}				
					foreach (var converseRate in RateAPIConstant.converseRates)
					{				
				    	var rates = converseRate.Split("/");
					    var fromCurrency = rates[0];
					    var toCurrency = rates[1];
					    
					    var currency = apiAnswer
						.CashExchangeRates
						.FirstOrDefault(r=>r.FromCurrency == fromCurrency && r.ToCurrency == toCurrency && r.RateOperationType == RateAPIConstant.ConvertType);

					  if (currency != null)
					  {
						var reverseCurrency = apiAnswer
							.CashExchangeRates
							.FirstOrDefault(r => r.FromCurrency == toCurrency && r.ToCurrency == fromCurrency && r.RateOperationType == RateAPIConstant.ConvertType);
						if (reverseCurrency != null)
						{
							currencies.Add(new RateViewModel
							{
								FromCurrency = currency.FromCurrency,
								ToCurrency = currency.ToCurrency,
								BuyRate = currency.Rate,
								SellRate = reverseCurrency.Rate,
								Units = currency.Units,
								RateType = RateConstant.ConverseType
							});
						}
					  }
					}								
			}
			return currencies;
		}
	}
}
