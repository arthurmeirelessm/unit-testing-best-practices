using Newtonsoft.Json;

namespace api_architecture_bestpracties.Models
{
    public class ErrorResponse
    {
        [JsonProperty("error")]
        public Error Error { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }
}
