﻿using System.Data.Entity.ModelConfiguration;
using WpfApp1.Models.Domains;

namespace WpfApp1.Models.Configurations
{
    public class StudentConfiguration : EntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
        {
            ToTable("dbo.Students");
            HasKey(x => x.Id);
            Property(x => x.FirstName).HasMaxLength(100).IsRequired();
            Property(x => x.LastName).HasMaxLength(100).IsRequired();
        }
    }
}
