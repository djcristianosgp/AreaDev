﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using area_api.Context;

#nullable disable

namespace area_api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220809131154_AjusteIndex")]
    partial class AjusteIndex
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("area_api.Models.Cadastros.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("categoriaid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CategoriaId"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean")
                        .HasColumnName("ativo");

                    b.Property<DateTime>("Datacadastro")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("datacadastro");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("descricao");

                    b.HasKey("CategoriaId");

                    b.HasIndex(new[] { "Descricao" }, "categoria_index01")
                        .IsUnique();

                    b.ToTable("categoria");
                });

            modelBuilder.Entity("area_api.Models.Cadastros.Marca", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("marcaid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MarcaId"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean")
                        .HasColumnName("ativo");

                    b.Property<DateTime>("Datacadastro")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("datacadastro");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("descricao");

                    b.HasKey("MarcaId");

                    b.HasIndex(new[] { "Descricao" }, "marca_index01")
                        .IsUnique();

                    b.ToTable("marca");
                });

            modelBuilder.Entity("area_api.Models.Cadastros.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("produtoid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProdutoId"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean")
                        .HasColumnName("ativo");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("integer")
                        .HasColumnName("categoriaid");

                    b.Property<string>("CodigoGtin")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("codigogtin");

                    b.Property<DateTime>("Datacadastro")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("datacadastro");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("descricao");

                    b.Property<int>("MarcaId")
                        .HasColumnType("integer")
                        .HasColumnName("marcaid");

                    b.Property<decimal>("Preco")
                        .HasColumnType("numeric(10,2)")
                        .HasColumnName("preco");

                    b.HasKey("ProdutoId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("MarcaId");

                    b.HasIndex(new[] { "Descricao" }, "produto_index01")
                        .IsUnique();

                    b.ToTable("produto");
                });

            modelBuilder.Entity("area_api.Models.Cadastros.Produto", b =>
                {
                    b.HasOne("area_api.Models.Cadastros.Categoria", "Categoria")
                        .WithMany("Produto")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("area_api.Models.Cadastros.Marca", "Marca")
                        .WithMany("Produto")
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("area_api.Models.Cadastros.Categoria", b =>
                {
                    b.Navigation("Produto");
                });

            modelBuilder.Entity("area_api.Models.Cadastros.Marca", b =>
                {
                    b.Navigation("Produto");
                });
#pragma warning restore 612, 618
        }
    }
}
