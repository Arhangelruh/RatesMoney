using RatesMoney.Services;

public class FileCopier
{
	public async Task CopyFilesAsync()
	{
		string localFolderPath = @"~\Images\";
		var advertisingModel = await AppConfiguration.GetAdvertisingSettings();
		var remoteFolderPath = advertisingModel.FolderPath;

		// Создать локальную папку, если она не существует
		if (!Directory.Exists(localFolderPath))
		{
			Directory.CreateDirectory(localFolderPath);
		}
		else
		{
			Directory.Delete(localFolderPath, true);
			Directory.CreateDirectory(localFolderPath);
		}

		if (Directory.Exists(remoteFolderPath))
		{
			// Получить список файлов из удаленной папки
			var files = Directory.GetFiles(remoteFolderPath, "*.png");

			// Скачивать и сохранять каждый файл
			foreach (var file in files)
			{
				await Task.Run(() =>
				{
					File.Copy(file, localFolderPath);
				});
			}
		}

	}
}
