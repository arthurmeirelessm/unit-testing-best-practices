using Newtonsoft.Json;
using System;

namespace api_architecture_bestpracties.Models
{
    public class BaseModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updateAt")]
        public DateTime UpdateAt { get; set; }

    }
}
