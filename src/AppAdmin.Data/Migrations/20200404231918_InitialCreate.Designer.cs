﻿// <auto-generated />
using System;
using AppAdmin.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppAdmin.Data.Migrations
{
    [DbContext(typeof(AppAdminContext))]
    [Migration("20200404231918_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("AppAdmin.Domain.Administradora", b =>
                {
                    b.Property<int>("AdministradoraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("AdministradoraId");

                    b.ToTable("Administradoras");
                });

            modelBuilder.Entity("AppAdmin.Domain.Assunto", b =>
                {
                    b.Property<int>("AssuntoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("TipoAssunto")
                        .HasColumnType("INTEGER");

                    b.HasKey("AssuntoId");

                    b.ToTable("Assuntos");
                });

            modelBuilder.Entity("AppAdmin.Domain.Condominio", b =>
                {
                    b.Property<int>("CondominioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AdministradoraId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("CondominioId");

                    b.HasIndex("AdministradoraId");

                    b.ToTable("Condominios");
                });

            modelBuilder.Entity("AppAdmin.Domain.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CondominioId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("TipoUsuario")
                        .HasColumnType("INTEGER");

                    b.HasKey("UsuarioId");

                    b.HasIndex("CondominioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("AppAdmin.Domain.Condominio", b =>
                {
                    b.HasOne("AppAdmin.Domain.Administradora", "Administradora")
                        .WithMany("Condominios")
                        .HasForeignKey("AdministradoraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppAdmin.Domain.Usuario", b =>
                {
                    b.HasOne("AppAdmin.Domain.Condominio", "Condominio")
                        .WithMany()
                        .HasForeignKey("CondominioId");
                });
#pragma warning restore 612, 618
        }
    }
}
