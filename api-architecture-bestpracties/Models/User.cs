namespace api_architecture_bestpracties.Models
{
    public class User : BaseModel
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public string Password { get; set; }
    }
}
