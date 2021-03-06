// <auto-generated />
using System;
using LojaApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LojaApp.Migrations
{
    [DbContext(typeof(LojaContext))]
    partial class LojaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0-preview.7.21378.4");

            modelBuilder.Entity("LojaApp.Data.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("LojaApp.Data.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoriaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Valor")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("LojaApp.Data.Produto", b =>
                {
                    b.HasOne("LojaApp.Data.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaId");

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("LojaApp.Data.Categoria", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
