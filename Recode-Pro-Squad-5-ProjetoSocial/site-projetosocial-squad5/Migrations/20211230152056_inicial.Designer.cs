﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using site_projetosocial_squad5.Data;

namespace site_projetosocial_squad5.Migrations
{
    [DbContext(typeof(BDContext))]
    [Migration("20211230152056_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("site_projetosocial_squad5.Models.Cadastro", b =>
                {
                    b.Property<int>("id_cadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("bairro_cadastro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("categoriaNegocio_cadastro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("cep_cadastro")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("cidade_cadastro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("email_cadastro")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("endereco_cadastro")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("idade_cadastro")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("nomeNegocio_cadastro")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("nome_cadatro")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("telefoneNegocio_cadastro")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("telefone_cadastro")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("id_cadastro");

                    b.ToTable("Cadastro");
                });

            modelBuilder.Entity("site_projetosocial_squad5.Models.Produto", b =>
                {
                    b.Property<int>("id_produto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FK_id_cadastro")
                        .HasColumnType("int");

                    b.Property<int>("FK_nome_negocio")
                        .HasColumnType("int");

                    b.Property<string>("descricao_produto")
                        .HasMaxLength(510)
                        .HasColumnType("nvarchar(510)");

                    b.Property<int?>("id_cadastro1")
                        .HasColumnType("int");

                    b.Property<int?>("nomeNegocio_cadastroid_cadastro")
                        .HasColumnType("int");

                    b.Property<string>("nome_produto")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<decimal>("preco_produto")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id_produto");

                    b.HasIndex("id_cadastro1");

                    b.HasIndex("nomeNegocio_cadastroid_cadastro");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("site_projetosocial_squad5.Models.Servico", b =>
                {
                    b.Property<int>("id_servico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FK_id_cadastro")
                        .HasColumnType("int");

                    b.Property<int>("FK_nome_negocio")
                        .HasColumnType("int");

                    b.Property<string>("descricao_servico")
                        .HasMaxLength(510)
                        .HasColumnType("nvarchar(510)");

                    b.Property<int?>("id_cadastro1")
                        .HasColumnType("int");

                    b.Property<int?>("nomeNegocio_cadastroid_cadastro")
                        .HasColumnType("int");

                    b.Property<string>("nome_servico")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<float>("preco_produto")
                        .HasColumnType("real");

                    b.HasKey("id_servico");

                    b.HasIndex("id_cadastro1");

                    b.HasIndex("nomeNegocio_cadastroid_cadastro");

                    b.ToTable("Servicos");
                });

            modelBuilder.Entity("site_projetosocial_squad5.Models.Produto", b =>
                {
                    b.HasOne("site_projetosocial_squad5.Models.Cadastro", "id_cadastro")
                        .WithMany()
                        .HasForeignKey("id_cadastro1");

                    b.HasOne("site_projetosocial_squad5.Models.Cadastro", "nomeNegocio_cadastro")
                        .WithMany()
                        .HasForeignKey("nomeNegocio_cadastroid_cadastro");

                    b.Navigation("id_cadastro");

                    b.Navigation("nomeNegocio_cadastro");
                });

            modelBuilder.Entity("site_projetosocial_squad5.Models.Servico", b =>
                {
                    b.HasOne("site_projetosocial_squad5.Models.Cadastro", "id_cadastro")
                        .WithMany()
                        .HasForeignKey("id_cadastro1");

                    b.HasOne("site_projetosocial_squad5.Models.Cadastro", "nomeNegocio_cadastro")
                        .WithMany()
                        .HasForeignKey("nomeNegocio_cadastroid_cadastro");

                    b.Navigation("id_cadastro");

                    b.Navigation("nomeNegocio_cadastro");
                });
#pragma warning restore 612, 618
        }
    }
}
