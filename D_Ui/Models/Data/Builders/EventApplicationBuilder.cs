using D_Ui.Models.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace D_Ui.Models.Data.Builders
{
    public class EventApplicationBuilder
    {
        public EventApplicationBuilder(EntityTypeBuilder<EventApplication> builder)
        {
            builder.HasKey(t => t.Id);
            builder.HasOne(s => s.Event).WithMany(s => s.EventApplications).HasForeignKey(s => s.EventId).OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.ClientSetNull);
        }
    }
}
