namespace RatesMoney.Services
{
	public class Configuration
	{
		public Task SaveWorkplaceCode(int workplace)
		{
			Preferences.Default.Set("Workplace_code", workplace);	
			return Task.CompletedTask;
		}
	}
}
