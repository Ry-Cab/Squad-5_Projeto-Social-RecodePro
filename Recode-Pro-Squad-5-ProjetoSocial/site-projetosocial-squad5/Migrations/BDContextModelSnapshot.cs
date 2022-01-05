﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using site_projetosocial_squad5.Data;

namespace site_projetosocial_squad5.Migrations
{
    [DbContext(typeof(BDContext))]
    partial class BDContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("site_projetosocial_squad5.Models.Afiliacao", b =>
                {
                    b.Property<int>("id_afiliacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Afiliadaid_afiliada")
                        .HasColumnType("int");

                    b.Property<int>("FK_id_afiliada")
                        .HasColumnType("int");

                    b.Property<int>("FK_id_produtoServico")
                        .HasColumnType("int");

                    b.Property<int?>("ProdutoServicoid_produtoServico")
                        .HasColumnType("int");

                    b.Property<string>("codigo_produtoServico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_afiliacao");

                    b.HasIndex("Afiliadaid_afiliada");

                    b.HasIndex("ProdutoServicoid_produtoServico");

                    b.ToTable("Afiliacao");
                });

            modelBuilder.Entity("site_projetosocial_squad5.Models.Afiliada", b =>
                {
                    b.Property<int>("id_afiliada")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email_afiliada")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("nome_afiliada")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("senha_afiliada")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("sobrenome_afiliada")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("telefone_afiliada")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("id_afiliada");

                    b.ToTable("Afiliada");
                });

            modelBuilder.Entity("site_projetosocial_squad5.Models.Autonoma", b =>
                {
                    b.Property<int>("id_autonoma")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email_autonoma")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("nomeNegocio_autonoma")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("nome_autonoma")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("senha_autonoma")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("sobrenome_autonoma")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("telefone_autonoma")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("id_autonoma");

                    b.ToTable("Autonoma");
                });

            modelBuilder.Entity("site_projetosocial_squad5.Models.ProdutoServico", b =>
                {
                    b.Property<int>("id_produtoServico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FK_id_autonoma")
                        .HasColumnType("int");

                    b.Property<string>("codigo_produtoServico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descricao_produtoServico")
                        .HasMaxLength(510)
                        .HasColumnType("nvarchar(510)");

                    b.Property<int?>("id_autonoma1")
                        .HasColumnType("int");

                    b.Property<string>("nomeNegocio_autonoma")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("nome_produtoServico")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<decimal>("preco_produtoServico")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("tipo_produtoServico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_produtoServico");

                    b.HasIndex("id_autonoma1");

                    b.ToTable("ProdutoServico");
                });

            modelBuilder.Entity("site_projetosocial_squad5.Models.Afiliacao", b =>
                {
                    b.HasOne("site_projetosocial_squad5.Models.Afiliada", "Afiliada")
                        .WithMany()
                        .HasForeignKey("Afiliadaid_afiliada");

                    b.HasOne("site_projetosocial_squad5.Models.ProdutoServico", "ProdutoServico")
                        .WithMany()
                        .HasForeignKey("ProdutoServicoid_produtoServico");

                    b.Navigation("Afiliada");

                    b.Navigation("ProdutoServico");
                });

            modelBuilder.Entity("site_projetosocial_squad5.Models.ProdutoServico", b =>
                {
                    b.HasOne("site_projetosocial_squad5.Models.Autonoma", "id_autonoma")
                        .WithMany()
                        .HasForeignKey("id_autonoma1");

                    b.Navigation("id_autonoma");
                });
#pragma warning restore 612, 618
        }
    }
}
