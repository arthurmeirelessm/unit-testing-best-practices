using Newtonsoft.Json;

namespace api_architecture_bestpracties.Models
{
    public class Error
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
