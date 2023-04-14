using System.Data.Entity.ModelConfiguration;
using WpfApp1.Models.Domains;

namespace WpfApp1.Models.Configurations
{
    public class RatingConfiguration : EntityTypeConfiguration<Rating>
    {
        public RatingConfiguration()
        {
            ToTable("dbo.Ratings");
            HasKey(x => x.Id);
        }
    }
}
