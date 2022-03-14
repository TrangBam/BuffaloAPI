using Newtonsoft.Json;
using System;

namespace DTOs.Buffalo.User
{
    public class UserDto
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("day_of_birth")]
        public DateTime DayOfBirth { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }
}
