using Entities.Buffalo;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace EntityFrameworkCore.Contexts
{
    public static class DbInitializer
    {
        public static void Initialize(AlcareDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            context.Users.Add(new User
            {
                Id = Guid.NewGuid(),
                Name = "Nguyễn Đình Bình",
                DayOfBirth = Convert.ToDateTime("1997/06/28"),
                Address = "35 Núi Thành, Hòa Thuận Đông, Hải Châu, Đà Nẵng",
            });

            context.SaveChanges();
        }

        public static string EncryptPassword(string passsword)
        {
            return Convert.ToBase64String(SHA1.Create().ComputeHash(Encoding.ASCII.GetBytes(passsword)));
        }
    }
}
