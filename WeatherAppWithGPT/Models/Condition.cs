using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WeatherAppWithGPT.Models
{
    public class Condition
    {
        [Key]
        public int Id { get; set; }

        [JsonProperty("text")]
        [Required]
        public string Text { get; set; }

        [JsonProperty("icon")]
        [Required]
        public string Icon { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }
}
