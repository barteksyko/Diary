using System.Data.Entity.ModelConfiguration;
using WpfApp1.Models.Domains;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfApp1.Models.Configurations
{
    public class GroupConfiguration : EntityTypeConfiguration<Group>
    {
        public GroupConfiguration()
        {
            ToTable("dbo.Groups");
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.Name).HasMaxLength(20).IsRequired();
        }
    }
}
