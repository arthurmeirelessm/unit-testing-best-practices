using api_architecture_bestpracties.Enuns;
using Newtonsoft.Json;

namespace api_architecture_bestpracties.Models
{
    public class UserModel : BaseModel
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
        public int Age { get; set; }

        public TypeUser TypeUser { get; set; }

        public string Password { get; set; }
    }
}
