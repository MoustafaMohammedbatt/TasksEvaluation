﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksEvaluation.Core.Entities.Business;

namespace TasksEvaluation.Core.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {


            builder.HasKey(g => g.Id);
            builder.Property(g => g.Title).IsRequired();

            builder.HasOne(g => g.Course)
                   .WithMany(c => c.Groups)
                   .HasForeignKey(g => g.CourseId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
