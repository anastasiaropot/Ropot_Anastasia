// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ropot_Anastasia.Data;

#nullable disable

namespace Ropot_Anastasia.Migrations
{
    [DbContext(typeof(Ropot_AnastasiaContext))]
    [Migration("20230118202712_nnn")]
    partial class nnn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Ropot_Anastasia.Models.Examen", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("DataExamen")
                        .HasColumnType("datetime2");

                    b.Property<string>("Materie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profesor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProfesorCursID")
                        .HasColumnType("int");

                    b.Property<decimal>("Sala")
                        .HasColumnType("decimal(3,0)");

                    b.HasKey("ID");

                    b.HasIndex("ProfesorCursID");

                    b.ToTable("Examen");
                });

            modelBuilder.Entity("Ropot_Anastasia.Models.ProfesorCurs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Nume_ProfesorCurs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ProfesorCurs");
                });

            modelBuilder.Entity("Ropot_Anastasia.Models.Examen", b =>
                {
                    b.HasOne("Ropot_Anastasia.Models.ProfesorCurs", "ProfesorCurs")
                        .WithMany("Examene")
                        .HasForeignKey("ProfesorCursID");

                    b.Navigation("ProfesorCurs");
                });

            modelBuilder.Entity("Ropot_Anastasia.Models.ProfesorCurs", b =>
                {
                    b.Navigation("Examene");
                });
#pragma warning restore 612, 618
        }
    }
}
