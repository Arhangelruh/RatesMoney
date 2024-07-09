using System.ComponentModel.DataAnnotations;

namespace RatesMoney.Models
{
    public class ApiModel
    {
        /// <summary>
        /// Url address to API.
        /// </summary>
        [Url(ErrorMessage = "Необходимо ввести url")]
        public string? ApiPath { get; set; }
    }
}
