﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectMVC.Models;

namespace ProjectMVC.Migrations
{
    [DbContext(typeof(SellerContext))]
    partial class SellerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectMVC.Models.Seller", b =>
                {
                    b.Property<string>("Sname")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Companyname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Contactno")
                        .HasColumnType("int");

                    b.Property<string>("Saddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Semail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sid")
                        .HasColumnType("int");

                    b.Property<string>("Spassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Sname");

                    b.ToTable("Sellers");
                });
#pragma warning restore 612, 618
        }
    }
}
