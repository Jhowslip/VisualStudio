﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Models;

namespace WebApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191102034824_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApi.Models.Produto", b =>
                {
                    b.Property<int>("ID_PRODUTO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DESC_PRODUTO")
                        .HasColumnType("nvarchar(44)")
                        .HasMaxLength(44);

                    b.Property<double?>("EST_PRODUTO")
                        .HasColumnType("float");

                    b.Property<double?>("VAL_PRODUTO")
                        .HasColumnType("float");

                    b.HasKey("ID_PRODUTO");

                    b.ToTable("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
