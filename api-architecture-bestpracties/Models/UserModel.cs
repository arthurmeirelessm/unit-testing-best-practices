using api_architecture_bestpracties.Enuns;
using Newtonsoft.Json;

namespace api_architecture_bestpracties.Models
{
    public class UserModel : BaseModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("typeUser")]
        public TypeUser TypeUser { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
