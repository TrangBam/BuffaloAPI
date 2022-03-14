using Entities.Buffalo;
using Entities.AlcareConfigurations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.ReactConfigurations
{
    public class UserConfiguration : EntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).IsRequired(true);
            builder.Property(x => x.DayOfBirth).IsRequired(true);
            builder.Property(x => x.Address).IsRequired(true);
        }
    }
}
