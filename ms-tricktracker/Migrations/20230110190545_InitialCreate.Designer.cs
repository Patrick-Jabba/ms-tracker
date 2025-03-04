﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ms_tracker.Context;

#nullable disable

namespace mstracker.Migrations
{
    [DbContext(typeof(TrackerContext))]
    [Migration("20230110190545_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ms_tracker.Models.Projeto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Projetos");
                });

            modelBuilder.Entity("ms_tracker.Models.Tarefa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("DuracaoEmSegundos")
                        .HasColumnType("integer");

                    b.Property<int>("ProjetoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProjetoId");

                    b.ToTable("Tarefas");
                });

            modelBuilder.Entity("ms_tracker.Models.Tarefa", b =>
                {
                    b.HasOne("ms_tracker.Models.Projeto", "Projeto")
                        .WithMany("Tarefas")
                        .HasForeignKey("ProjetoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Projeto");
                });

            modelBuilder.Entity("ms_tracker.Models.Projeto", b =>
                {
                    b.Navigation("Tarefas");
                });
#pragma warning restore 612, 618
        }
    }
}
