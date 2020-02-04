﻿// <auto-generated />
using GestionLocalidades.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GestionLocalidades.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200203032639_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GestionLocalidades.Data.Models.Localidades", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.Property<int>("ProvinciaId");

                    b.HasKey("Id");

                    b.HasIndex("ProvinciaId");

                    b.ToTable("Localidades");
                });

            modelBuilder.Entity("GestionLocalidades.Data.Models.Paises", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Paises");
                });

            modelBuilder.Entity("GestionLocalidades.Data.Models.Provincias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.Property<int>("PaisId");

                    b.HasKey("Id");

                    b.HasIndex("PaisId");

                    b.ToTable("Provincias");
                });

            modelBuilder.Entity("GestionLocalidades.Data.Models.Localidades", b =>
                {
                    b.HasOne("GestionLocalidades.Data.Models.Provincias", "Provincias")
                        .WithMany("Localidades")
                        .HasForeignKey("ProvinciaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GestionLocalidades.Data.Models.Provincias", b =>
                {
                    b.HasOne("GestionLocalidades.Data.Models.Paises", "Pais")
                        .WithMany("Provincias")
                        .HasForeignKey("PaisId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
