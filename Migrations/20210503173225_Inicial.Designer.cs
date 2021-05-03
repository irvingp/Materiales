﻿// <auto-generated />
using System;
using Materiales.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Materiales.Migrations
{
    [DbContext(typeof(MaterialesContext))]
    [Migration("20210503173225_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Materiales.Models.Categoria", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("EstadoCategoria")
                        .HasColumnType("bit");

                    b.Property<string>("NombreCategoria")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCategoria");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Materiales.Models.Materiales", b =>
                {
                    b.Property<int>("IdMaterial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoriaIdCategoria")
                        .HasColumnType("int");

                    b.Property<string>("Descripción")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Existencia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ProveedorIdProveedor")
                        .HasColumnType("int");

                    b.Property<int?>("UnidadMedidaIdUnidadMedida")
                        .HasColumnType("int");

                    b.HasKey("IdMaterial");

                    b.HasIndex("CategoriaIdCategoria");

                    b.HasIndex("ProveedorIdProveedor");

                    b.HasIndex("UnidadMedidaIdUnidadMedida");

                    b.ToTable("Materiales");
                });

            modelBuilder.Entity("Materiales.Models.Proveedor", b =>
                {
                    b.Property<int>("IdProveedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("EstadoProveedor")
                        .HasColumnType("bit");

                    b.Property<string>("NombreProveedor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdProveedor");

                    b.ToTable("Proveedor");
                });

            modelBuilder.Entity("Materiales.Models.UnidadMedida", b =>
                {
                    b.Property<int>("IdUnidadMedida")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abreviatura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EstadoUnidadMedida")
                        .HasColumnType("bit");

                    b.Property<string>("NombreUnidadMedida")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUnidadMedida");

                    b.ToTable("UnidadMedida");
                });

            modelBuilder.Entity("Materiales.Models.Materiales", b =>
                {
                    b.HasOne("Materiales.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaIdCategoria");

                    b.HasOne("Materiales.Models.Proveedor", "Proveedor")
                        .WithMany()
                        .HasForeignKey("ProveedorIdProveedor");

                    b.HasOne("Materiales.Models.UnidadMedida", "UnidadMedida")
                        .WithMany()
                        .HasForeignKey("UnidadMedidaIdUnidadMedida");

                    b.Navigation("Categoria");

                    b.Navigation("Proveedor");

                    b.Navigation("UnidadMedida");
                });
#pragma warning restore 612, 618
        }
    }
}