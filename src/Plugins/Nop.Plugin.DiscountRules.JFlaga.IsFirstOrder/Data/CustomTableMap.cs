using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nop.Data.Mapping;
using Nop.Plugin.DiscountRules.JFlaga.IsFirstOrder.Domains;

namespace Nop.Plugin.DiscountRules.JFlaga.IsFirstOrder.Data
{
    public partial class CustomTableMap : NopEntityTypeConfiguration<CustomTable>
    {
        public override void Configure(EntityTypeBuilder<CustomTable> builder)
        {
            builder.ToTable(nameof(CustomTable));

            builder.HasKey(rcoh => rcoh.Id);
        }
    }
}
