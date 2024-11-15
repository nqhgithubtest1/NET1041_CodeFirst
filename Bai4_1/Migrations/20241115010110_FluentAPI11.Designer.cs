﻿// <auto-generated />
using System;
using Bai4_1.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bai4_1.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20241115010110_FluentAPI11")]
    partial class FluentAPI11
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bai4_1.Models.ChuNhan", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("DongVatID")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DongVatID")
                        .IsUnique();

                    b.ToTable("ChuNhan");
                });

            modelBuilder.Entity("Bai4_1.Models.DiaChi", b =>
                {
                    b.Property<int>("DiaChiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiaChiID"));

                    b.Property<string>("QuanHuyen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SinhVienID")
                        .HasColumnType("int");

                    b.Property<string>("SoNha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThanhPho")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("XaPhuong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DiaChiID");

                    b.ToTable("DiaChis");
                });

            modelBuilder.Entity("Bai4_1.Models.DongVat", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("DongVat");
                });

            modelBuilder.Entity("Bai4_1.Models.Laptop", b =>
                {
                    b.Property<int>("LaptopID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LaptopID"));

                    b.Property<int>("SinhVienID")
                        .HasColumnType("int");

                    b.Property<string>("TenLaptop")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LaptopID");

                    b.HasIndex("SinhVienID");

                    b.ToTable("Laptop");
                });

            modelBuilder.Entity("Bai4_1.Models.LopHoc", b =>
                {
                    b.Property<int>("LopHocID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LopHocID"));

                    b.Property<string>("TenLopHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LopHocID");

                    b.ToTable("LopHoc");
                });

            modelBuilder.Entity("Bai4_1.Models.SinhVien", b =>
                {
                    b.Property<int>("SinhVienID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("SinhVienID");

                    b.ToTable("SinhViens");
                });

            modelBuilder.Entity("LopHocSinhVien", b =>
                {
                    b.Property<int>("LopHocsLopHocID")
                        .HasColumnType("int");

                    b.Property<int>("SinhViensSinhVienID")
                        .HasColumnType("int");

                    b.HasKey("LopHocsLopHocID", "SinhViensSinhVienID");

                    b.HasIndex("SinhViensSinhVienID");

                    b.ToTable("LopHocSinhVien");
                });

            modelBuilder.Entity("Bai4_1.Models.ChuNhan", b =>
                {
                    b.HasOne("Bai4_1.Models.DongVat", "DongVat")
                        .WithOne("ChuNhan")
                        .HasForeignKey("Bai4_1.Models.ChuNhan", "DongVatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DongVat");
                });

            modelBuilder.Entity("Bai4_1.Models.Laptop", b =>
                {
                    b.HasOne("Bai4_1.Models.SinhVien", "SinhVien")
                        .WithMany("Laptops")
                        .HasForeignKey("SinhVienID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SinhVien");
                });

            modelBuilder.Entity("Bai4_1.Models.SinhVien", b =>
                {
                    b.HasOne("Bai4_1.Models.DiaChi", "DiaChi")
                        .WithOne("SinhVien")
                        .HasForeignKey("Bai4_1.Models.SinhVien", "SinhVienID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DiaChi");
                });

            modelBuilder.Entity("LopHocSinhVien", b =>
                {
                    b.HasOne("Bai4_1.Models.LopHoc", null)
                        .WithMany()
                        .HasForeignKey("LopHocsLopHocID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bai4_1.Models.SinhVien", null)
                        .WithMany()
                        .HasForeignKey("SinhViensSinhVienID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bai4_1.Models.DiaChi", b =>
                {
                    b.Navigation("SinhVien")
                        .IsRequired();
                });

            modelBuilder.Entity("Bai4_1.Models.DongVat", b =>
                {
                    b.Navigation("ChuNhan")
                        .IsRequired();
                });

            modelBuilder.Entity("Bai4_1.Models.SinhVien", b =>
                {
                    b.Navigation("Laptops");
                });
#pragma warning restore 612, 618
        }
    }
}