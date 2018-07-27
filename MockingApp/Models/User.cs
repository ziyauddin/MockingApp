using Newtonsoft.Json;

namespace MockingApp.Models
{
    public class User
    {
        [JsonProperty("UserName")]
        public string UserName { get; set; }

        [JsonProperty("Password")]
        public string Password { get; set; }
    }
}
