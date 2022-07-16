using Newtonsoft.Json;

namespace api_architecture_bestpracties.Models.Responses
{
    public class UserCreatedResponse : ErrorResponse
    {
        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("occupation ")]
        public string Occupation { get; set; }

        [JsonProperty("messageResponse")]
        public string MessageResponse { get; set; }
    }
}
