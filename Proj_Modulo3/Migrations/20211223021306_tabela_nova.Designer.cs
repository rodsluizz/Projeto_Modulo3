﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proj_Modulo3.Models;

#nullable disable

namespace Proj_Modulo3.Migrations
{
    [DbContext(typeof(contexto))]
    [Migration("20211223021306_tabela_nova")]
    partial class tabela_nova
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Proj_Modulo3.Models.destinos", b =>
                {
                    b.Property<int>("id_destino")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_destino"), 1L, 1);

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("local_viagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("valor")
                        .HasColumnType("real");

                    b.HasKey("id_destino");

                    b.ToTable("destinos");
                });

            modelBuilder.Entity("Proj_Modulo3.Models.promocoes", b =>
                {
                    b.Property<int>("id_promocoes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_promocoes"), 1L, 1);

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("local_viagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("preco_antigo")
                        .HasColumnType("real");

                    b.Property<float>("preco_atual")
                        .HasColumnType("real");

                    b.HasKey("id_promocoes");

                    b.ToTable("promocoes");
                });
#pragma warning restore 612, 618
        }
    }
}