﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tacotitos.BD.Context;

#nullable disable

namespace Tacotitos.Migrations
{
    [DbContext(typeof(TacotitosContext))]
    [Migration("20231120180802_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Tacotitos.src.modelo.cliente.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<bool>("BajaSino")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CuandoSeActualizo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CuandoSeElimino")
                        .HasColumnType("datetime2");

                    b.Property<string>("Domicilio")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("NombreCompleto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Tacotitos.src.modelo.detalleIngrediente.DetalleIngrediente", b =>
                {
                    b.Property<int>("IdDetalle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDetalle"));

                    b.Property<bool>("BajaSino")
                        .HasColumnType("bit");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<DateTime>("CuandoSeActualizo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CuandoSeCreo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CuandoSeElimino")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdIngrediente")
                        .HasColumnType("int");

                    b.Property<int>("IdTaco")
                        .HasColumnType("int");

                    b.Property<double>("PrecioUnitario")
                        .HasColumnType("float");

                    b.HasKey("IdDetalle");

                    b.HasIndex("IdIngrediente");

                    b.HasIndex("IdTaco");

                    b.ToTable("DetallesIngredientes");
                });

            modelBuilder.Entity("Tacotitos.src.modelo.ingrediente.Ingrediente", b =>
                {
                    b.Property<int>("IdIngrediente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdIngrediente"));

                    b.Property<bool>("BajaSino")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CuandoSeActualizo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CuandoSeElimino")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdTipoIngrediente")
                        .HasColumnType("int");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.HasKey("IdIngrediente");

                    b.HasIndex("IdTipoIngrediente");

                    b.ToTable("Ingredientes");
                });

            modelBuilder.Entity("Tacotitos.src.modelo.pedido.Pedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPedido"));

                    b.Property<bool>("BajaSino")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CuandoSeActualizo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CuandoSeCreo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CuandoSeElimino")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.HasKey("IdPedido");

                    b.HasIndex("IdCliente");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("Tacotitos.src.modelo.taco.ListDetalleIngre", b =>
                {
                    b.Property<int>("IdTaco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTaco"));

                    b.Property<bool>("BajaSino")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CuandoSeActualizo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CuandoSeCreo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CuandoSeElimino")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdPedido")
                        .HasColumnType("int");

                    b.HasKey("IdTaco");

                    b.HasIndex("IdPedido");

                    b.ToTable("Tacos");
                });

            modelBuilder.Entity("Tacotitos.src.modelo.tiposIngredientes.TipoIngrediente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("BajaSino")
                        .HasColumnType("bit");

                    b.Property<int>("CantidadMax")
                        .HasColumnType("int");

                    b.Property<DateTime>("CuandoSeActualizo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CuandoSeElimino")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TiposIngredientes");
                });

            modelBuilder.Entity("Tacotitos.src.modelo.detalleIngrediente.DetalleIngrediente", b =>
                {
                    b.HasOne("Tacotitos.src.modelo.ingrediente.Ingrediente", "ingrediente")
                        .WithMany("DetalleIngrediente")
                        .HasForeignKey("IdIngrediente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tacotitos.src.modelo.taco.ListDetalleIngre", "taco")
                        .WithMany("Ingredientes")
                        .HasForeignKey("IdTaco")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ingrediente");

                    b.Navigation("taco");
                });

            modelBuilder.Entity("Tacotitos.src.modelo.ingrediente.Ingrediente", b =>
                {
                    b.HasOne("Tacotitos.src.modelo.tiposIngredientes.TipoIngrediente", "tipoIngrediente")
                        .WithMany("Ingredientes")
                        .HasForeignKey("IdTipoIngrediente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("tipoIngrediente");
                });

            modelBuilder.Entity("Tacotitos.src.modelo.pedido.Pedido", b =>
                {
                    b.HasOne("Tacotitos.src.modelo.cliente.Cliente", "cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cliente");
                });

            modelBuilder.Entity("Tacotitos.src.modelo.taco.ListDetalleIngre", b =>
                {
                    b.HasOne("Tacotitos.src.modelo.pedido.Pedido", "pedido")
                        .WithMany("Tacos")
                        .HasForeignKey("IdPedido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pedido");
                });

            modelBuilder.Entity("Tacotitos.src.modelo.cliente.Cliente", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Tacotitos.src.modelo.ingrediente.Ingrediente", b =>
                {
                    b.Navigation("DetalleIngrediente");
                });

            modelBuilder.Entity("Tacotitos.src.modelo.pedido.Pedido", b =>
                {
                    b.Navigation("Tacos");
                });

            modelBuilder.Entity("Tacotitos.src.modelo.taco.ListDetalleIngre", b =>
                {
                    b.Navigation("Ingredientes");
                });

            modelBuilder.Entity("Tacotitos.src.modelo.tiposIngredientes.TipoIngrediente", b =>
                {
                    b.Navigation("Ingredientes");
                });
#pragma warning restore 612, 618
        }
    }
}
