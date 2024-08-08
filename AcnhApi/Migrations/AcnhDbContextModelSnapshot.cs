﻿// <auto-generated />
using AcnhApi.DataAccessors.AcnhDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AcnhApi.Migrations
{
    [DbContext(typeof(AcnhDbContext))]
    partial class AcnhDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AcnhApi.DataAccessors.Entities.Fish", b =>
                {
                    b.Property<string>("FishId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("FishAvailabilityHours00")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityHours01")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityHours02")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityHours03")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityHours04")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityHours05")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityHours06")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityHours07")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityHours08")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityHours09")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityHours10")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityHours11")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityHours12")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityHours13")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityHours14")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityHours15")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityHours16")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityHours17")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityHours18")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityHours19")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityHours20")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityHours21")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityHours22")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityHours23")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityMonth01")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityMonth02")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityMonth03")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityMonth04")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityMonth05")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityMonth06")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityMonth07")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityMonth08")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityMonth09")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityMonth10")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityMonth11")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("FishAvailabilityMonth12")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FishImageUri")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FishLocation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FishName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("FishId");

                    b.ToTable("Fishes", (string)null);
                });

            modelBuilder.Entity("AcnhApi.DataAccessors.Entities.User", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("FishUser", b =>
                {
                    b.Property<string>("FishId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("FishId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("FishUser");
                });

            modelBuilder.Entity("FishUser", b =>
                {
                    b.HasOne("AcnhApi.DataAccessors.Entities.Fish", null)
                        .WithMany()
                        .HasForeignKey("FishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AcnhApi.DataAccessors.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
