using Entities.Interfaces;
using System;

namespace Entities.Buffalo
{
    public class User : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime DayOfBirth { get; set; }

        public string Address { get; set; }
    }
}
