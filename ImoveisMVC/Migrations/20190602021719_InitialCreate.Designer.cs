﻿// <auto-generated />
using ImoveisMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ImoveisMVC.Migrations
{
    [DbContext(typeof(SolutionContext))]
    [Migration("20190602021719_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ImoveisMVC.Models.ImovelModel", b =>
                {
                    b.Property<int>("IdImovel")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BroImovel")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("CEPImovel")
                        .IsRequired();

                    b.Property<string>("CddImovel")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("DscImovel")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("NumQrtImovel");

                    b.Property<int>("NumVagImovel");

                    b.Property<string>("RuaImovel")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("TipImovel")
                        .IsRequired()
                        .HasMaxLength(1);

                    b.Property<string>("UFImovel")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<decimal>("VlrImovel");

                    b.HasKey("IdImovel");

                    b.ToTable("Imovel");
                });
#pragma warning restore 612, 618
        }
    }
}
