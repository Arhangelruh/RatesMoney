using RatesMoney.Constants;
using RatesMoney.Models;

namespace RatesMoney.Services
{
	public class AppConfiguration
	{
		public static async Task SaveAdvertisingSettings(AdvertisingSettings model)
		{
			await Task.Run(() =>
			{
				if (model != null)
				{
					if (model.FolderPath != null)
					{
						Preferences.Default.Set(PreferenceConstants.AdvertisingFolder, model.FolderPath);
					}
					if (model.Login != null)
					{
						Preferences.Default.Set(PreferenceConstants.AdvertisingLogin, model.Login);
					}
					if (model.Password != null)
					{
						Preferences.Default.Set(PreferenceConstants.AdvertisingPassword, model.Password);
					}
				}
			});

        }

		public static async Task<AdvertisingSettings> GetAdvertisingSettings() 
		{

			return await Task.Run(() =>
			{
				string getFolder = Preferences.Default.Get(PreferenceConstants.AdvertisingFolder, "");
				string getLogin = Preferences.Default.Get(PreferenceConstants.AdvertisingLogin, "");

				AdvertisingSettings model = new AdvertisingSettings
				{
					FolderPath = getFolder,
					Login = getLogin
				};

				return model;
			});
			
		}

        public static async Task SetWorkplaceCode(int code)
        {            
            await Task.Run(() =>
                Preferences.Default.Set(PreferenceConstants.WorkplaceCode, code)            
          );
        }

        public static async Task<int> GetWorkplaceCode()
		{			
			return await Task.Run(() =>{
			   int code = Preferences.Default.Get(PreferenceConstants.WorkplaceCode, PreferenceConstants.NullWorkplaceCode);
                return code;
            }
		  );	
		}

        public static async Task SetApiSettings(ApiModel api)
        {
            await Task.Run(() =>
                Preferences.Default.Set(PreferenceConstants.APIService, api.ApiPath)
          );
        }

        public static async Task<ApiModel> GetApiSettings()
        {
            return await Task.Run(() => {
                string ApiUrl = Preferences.Default.Get(PreferenceConstants.APIService, "");
				ApiModel api = new ApiModel { ApiPath = ApiUrl };
                return api;
            }
          );
        }
    }
}
