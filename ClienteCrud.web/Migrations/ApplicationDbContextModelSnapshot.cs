﻿// <auto-generated />
using System;
using ClienteCrud.web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClienteCrud.web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClienteCrud.web.Models.Entities.Cliente", b =>
                {
                    b.Property<int>("CLI_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CLI_ID"));

                    b.Property<bool>("CLI_ATIVO")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CLI_DATANASCIMENTO")
                        .HasColumnType("datetime2");

                    b.Property<string>("CLI_NOME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CLI_ID");

                    b.ToTable("Clientes");
                });
#pragma warning restore 612, 618
        }
    }
}
