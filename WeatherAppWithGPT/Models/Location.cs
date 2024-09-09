using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WeatherAppWithGPT.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }

        [JsonProperty("name")]
        [Required]
        public string Name { get; set; }

        [JsonProperty("region")]
        [Required]
        public string Region { get; set; }

        [JsonProperty("country")]
        [Required]
        public string Country { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("tz_id")]
        [Required]
        public string TzId { get; set; }

        [JsonProperty("localtime_epoch")]
        public long LocaltimeEpoch { get; set; }

        [JsonProperty("localtime")]
        public string Localtime { get; set; }

        // Navigation property for related current weather data
        public Current Current { get; set; }
    }
}
