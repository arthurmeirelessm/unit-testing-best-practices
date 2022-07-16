using Newtonsoft.Json;

namespace api_architecture_bestpracties.Models
{
    public class ErrorResponse
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

    }
}
