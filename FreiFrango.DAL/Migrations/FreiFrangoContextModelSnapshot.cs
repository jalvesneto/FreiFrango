// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FreiFrango.DAL.Migrations
{
    [DbContext(typeof(FreiFrangoContext))]
    partial class FreiFrangoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FreiFrango.DAL.Models.BuyLater", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("BuyLater");
                });

            modelBuilder.Entity("FreiFrango.DAL.Models.Cart", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("FreiFrango.DAL.Models.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ConcludeAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FreiFrango.DAL.Models.Produto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsByKg")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("FreiFrango.DAL.Models.ProdutosOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long?>("BuyLaterId")
                        .HasColumnType("bigint");

                    b.Property<long?>("CartId")
                        .HasColumnType("bigint");

                    b.Property<long>("IdProduto")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsByKg")
                        .HasColumnType("tinyint(1)");

                    b.Property<long?>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BuyLaterId");

                    b.HasIndex("CartId");

                    b.HasIndex("OrderId");

                    b.ToTable("ProdutosOrder");
                });

            modelBuilder.Entity("FreiFrango.DAL.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FreiFrango.DAL.Models.ProdutosOrder", b =>
                {
                    b.HasOne("FreiFrango.DAL.Models.BuyLater", null)
                        .WithMany("Produtos")
                        .HasForeignKey("BuyLaterId");

                    b.HasOne("FreiFrango.DAL.Models.Cart", null)
                        .WithMany("Produtos")
                        .HasForeignKey("CartId");

                    b.HasOne("FreiFrango.DAL.Models.Order", null)
                        .WithMany("ListProducts")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("FreiFrango.DAL.Models.BuyLater", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("FreiFrango.DAL.Models.Cart", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("FreiFrango.DAL.Models.Order", b =>
                {
                    b.Navigation("ListProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
