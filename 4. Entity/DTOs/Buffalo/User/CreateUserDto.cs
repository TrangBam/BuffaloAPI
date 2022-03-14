using Newtonsoft.Json;
using System;

namespace DTOs.Buffalo.User
{
    public class CreateUserDto
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("day_of_birth")]
        public DateTime DayOfBirth { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }
}
