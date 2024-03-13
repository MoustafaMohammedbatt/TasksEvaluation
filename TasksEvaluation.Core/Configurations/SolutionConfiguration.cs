using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksEvaluation.Core.Entities.Business;

namespace TasksEvaluation.Core.Configurations
{
    public class SolutionConfiguration : IEntityTypeConfiguration<Solution>
    {
        public void Configure(EntityTypeBuilder<Solution> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(sol => sol.Notes).IsRequired();

            builder.HasOne(sol => sol.Student)
               .WithMany(st => st.Solutions)
               .HasForeignKey(sol => sol.StudentId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
