﻿// <auto-generated />
using MCSeeds.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MCSeeds.Migrations
{
    [DbContext(typeof(MCSeedContext))]
    [Migration("20190711175710_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MCSeeds.models.seed", b =>
                {
                    b.Property<int>("SeedID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("ImageID");

                    b.Property<string>("SeedValue");

                    b.Property<string>("Title");

                    b.Property<int>("versionID");

                    b.HasKey("SeedID");

                    b.ToTable("Seeds");
                });
#pragma warning restore 612, 618
        }
    }
}