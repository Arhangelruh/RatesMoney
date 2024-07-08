using RatesMoney.Constants;
using RatesMoney.Models;

namespace RatesMoney.Services
{
	public class AdvertisingConfiguration
	{
		public void SaveAdvertisingSettings(AdvertisingSettings model)
		{ 			
			if (model != null)
			{
				if (model.FolderPath != null) {
					Preferences.Default.Set(PreferenceConstants.AdvertisingFolder, model.FolderPath);
				}
				if (model.Login !=null ) {
					Preferences.Default.Set(PreferenceConstants.AdvertisingLogin, model.Login);
				}
				if (model.Password != null)
				{
					Preferences.Default.Set(PreferenceConstants.AdvertisingPassword, model.Password);
				}
			}
		}
	}
}
