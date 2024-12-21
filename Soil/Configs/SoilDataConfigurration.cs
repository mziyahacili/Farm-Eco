using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Soil.Models;

namespace Soil.Configs;

public class SoilDataConfiguration : IEntityTypeConfiguration<SoilData>
{
    public void Configure(EntityTypeBuilder<SoilData> builder)
    {
        // Table Name
        builder.ToTable("SoilDatas");
        
        builder.HasKey(sd => sd.SceneId);

        // Properties
        builder.Property(sd => sd.SceneId)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(sd => sd.ViewId)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(sd => sd.Date)
            .IsRequired();

        builder.Property(sd => sd.Cloud)
            .HasMaxLength(50)
            .IsRequired(false); // Optional

        builder.Property(sd => sd.Q1).IsRequired();
        builder.Property(sd => sd.Q3).IsRequired();
        builder.Property(sd => sd.Max).IsRequired();
        builder.Property(sd => sd.Min).IsRequired();
        builder.Property(sd => sd.P10).IsRequired();
        builder.Property(sd => sd.P90).IsRequired();
        builder.Property(sd => sd.Std).IsRequired();
        builder.Property(sd => sd.Median).IsRequired();
        builder.Property(sd => sd.Average).IsRequired();
        builder.Property(sd => sd.Variance).IsRequired();
        builder.Property(sd => sd.Ctime10).IsRequired();

        // Conversion for Notes (List<string>)
        builder.Property(sd => sd.Notes)
            .HasConversion(
                v => v == null ? null : string.Join(",", v), // Handle null values
                v => string.IsNullOrEmpty(v) ? new List<string>() : v.Split(",", System.StringSplitOptions.None).ToList()
            )
            .HasColumnType("nvarchar(max)"); // Explicitly define type for large data
    }
}