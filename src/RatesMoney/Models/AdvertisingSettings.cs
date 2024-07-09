using System.ComponentModel.DataAnnotations;

namespace RatesMoney.Models
{
    public class AdvertisingSettings
    {
        /// <summary>
        /// Path to folder with images.
        /// </summary>
        [Required(ErrorMessage = "Поле обязательно для заполнения")]
		public string FolderPath { get; set; }

        /// <summary>
        /// User login.
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// User password.
        /// </summary>
        public string Password { get; set; }
    }
}
