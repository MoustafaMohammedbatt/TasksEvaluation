using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksEvaluation.Core.Entities.Business;

namespace TasksEvaluation.Core.Configurations
{
    public class EvaluationGradeConfiguration : IEntityTypeConfiguration<EvaluationGrade>
    {
        public void Configure(EntityTypeBuilder<EvaluationGrade> builder)
        {

            builder.HasOne(s => s.Solution)
              .WithOne(g => g.Grade)
              .HasForeignKey<Solution>(g => g.GradeId)
              .IsRequired()
              .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
