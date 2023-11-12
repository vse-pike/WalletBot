﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WalletBot.Data;

#nullable disable

namespace WalletBot.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WalletBot.Data.DataModels.CommitModel", b =>
                {
                    b.Property<string>("CommitId")
                        .HasColumnType("text");

                    b.Property<DateOnly>("AddedDate")
                        .HasColumnType("date");

                    b.Property<string>("IncomeId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Value")
                        .HasColumnType("numeric");

                    b.HasKey("CommitId");

                    b.HasIndex("IncomeId");

                    b.ToTable("Commits");
                });

            modelBuilder.Entity("WalletBot.Data.DataModels.IncomeModel", b =>
                {
                    b.Property<string>("IncomeId")
                        .HasColumnType("text");

                    b.Property<DateOnly>("CreationDate")
                        .HasColumnType("date");

                    b.Property<int>("CurrencyCode")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isArchived")
                        .HasColumnType("boolean");

                    b.HasKey("IncomeId");

                    b.HasIndex("UserId");

                    b.ToTable("Incomes");
                });

            modelBuilder.Entity("WalletBot.Data.DataModels.UserModel", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WalletBot.Data.DataModels.CommitModel", b =>
                {
                    b.HasOne("WalletBot.Data.DataModels.IncomeModel", "Income")
                        .WithMany("Commits")
                        .HasForeignKey("IncomeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Income");
                });

            modelBuilder.Entity("WalletBot.Data.DataModels.IncomeModel", b =>
                {
                    b.HasOne("WalletBot.Data.DataModels.UserModel", "User")
                        .WithMany("Incomes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WalletBot.Data.DataModels.IncomeModel", b =>
                {
                    b.Navigation("Commits");
                });

            modelBuilder.Entity("WalletBot.Data.DataModels.UserModel", b =>
                {
                    b.Navigation("Incomes");
                });
#pragma warning restore 612, 618
        }
    }
}
