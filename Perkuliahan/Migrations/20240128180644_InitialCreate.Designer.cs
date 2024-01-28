﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Perkuliahan.Data;

#nullable disable

namespace Perkuliahan.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240128180644_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Perkuliahan.Models.Entities.Dosen", b =>
                {
                    b.Property<string>("Nip")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Nama_Dosen")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Nip");

                    b.ToTable("Dosens");
                });

            modelBuilder.Entity("Perkuliahan.Models.Entities.Kuliah", b =>
                {
                    b.Property<int>("KuliahId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KuliahId"));

                    b.Property<string>("Kode_MK")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("Nilai")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Nim")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("Nip")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("KuliahId");

                    b.ToTable("Kuliahs");
                });

            modelBuilder.Entity("Perkuliahan.Models.Entities.Mahasiswa", b =>
                {
                    b.Property<string>("Nim")
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("Alamat")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Jenis_Kelamin")
                        .HasColumnType("int");

                    b.Property<string>("Nama_Mhs")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("Tgl_lahir")
                        .HasColumnType("datetime2");

                    b.HasKey("Nim");

                    b.ToTable("Mahasiswas");
                });

            modelBuilder.Entity("Perkuliahan.Models.Entities.MataKuliah", b =>
                {
                    b.Property<string>("Kode_MK")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("Nama_MK")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("Sks")
                        .HasColumnType("int");

                    b.HasKey("Kode_MK");

                    b.ToTable("MataKuliahs");
                });
#pragma warning restore 612, 618
        }
    }
}
