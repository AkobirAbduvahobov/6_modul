﻿// <auto-generated />
using System;
using GameStoreWebApp.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GameStoreWebApp.DataAccess.Migrations
{
    [DbContext(typeof(MainContext))]
    [Migration("20240813151913_test9")]
    partial class test9
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GameStoreWebApp.DataAccess.Entities.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<Guid>("PublisherId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("UnitInStock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Key")
                        .IsUnique();

                    b.HasIndex("PublisherId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("GameStoreWebApp.DataAccess.Entities.GameGenre", b =>
                {
                    b.Property<Guid>("GameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GenreId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GameId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("GameGenre");
                });

            modelBuilder.Entity("GameStoreWebApp.DataAccess.Entities.GamePlatform", b =>
                {
                    b.Property<Guid>("GameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlatformId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GameId", "PlatformId");

                    b.HasIndex("PlatformId");

                    b.ToTable("GamePlatform");
                });

            modelBuilder.Entity("GameStoreWebApp.DataAccess.Entities.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid?>("ParentGenreId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("ParentGenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = new Guid("734e884b-6a9f-4e73-8f89-6c5a615c9f19"),
                            Name = "Strategy"
                        },
                        new
                        {
                            Id = new Guid("94f804b0-aec5-4546-be53-2d8a3bd74b2b"),
                            Name = "RPG"
                        },
                        new
                        {
                            Id = new Guid("027bba02-5468-4ed3-b082-12b6d8b4de61"),
                            Name = "Sports"
                        },
                        new
                        {
                            Id = new Guid("dff051f5-5494-4def-bf66-e06e7fe51e4c"),
                            Name = "Races"
                        },
                        new
                        {
                            Id = new Guid("6d4eafb7-e2cc-46c5-803a-1968b78e2806"),
                            Name = "Action"
                        },
                        new
                        {
                            Id = new Guid("2a2e9f07-2fb6-40e9-b708-f5aaa20df0c3"),
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = new Guid("7aa6cd20-e2ce-41a2-949b-8f6625ce0177"),
                            Name = "Puzzle & Skill"
                        },
                        new
                        {
                            Id = new Guid("e5d07714-1fa9-451e-8cd7-4f647f457479"),
                            Name = "RTS",
                            ParentGenreId = new Guid("734e884b-6a9f-4e73-8f89-6c5a615c9f19")
                        },
                        new
                        {
                            Id = new Guid("6d7bf281-b141-4c39-95d9-1c43f607ba6c"),
                            Name = "TBS",
                            ParentGenreId = new Guid("734e884b-6a9f-4e73-8f89-6c5a615c9f19")
                        },
                        new
                        {
                            Id = new Guid("196e69ad-459f-439f-9b32-e7e7c60683b0"),
                            Name = "Rally",
                            ParentGenreId = new Guid("dff051f5-5494-4def-bf66-e06e7fe51e4c")
                        },
                        new
                        {
                            Id = new Guid("dc5bb11c-370e-46ac-be09-30c1eaaad78f"),
                            Name = "Arcade",
                            ParentGenreId = new Guid("dff051f5-5494-4def-bf66-e06e7fe51e4c")
                        },
                        new
                        {
                            Id = new Guid("54d5e711-a13f-4e5d-a3a2-ac34491a9fe9"),
                            Name = "Formula",
                            ParentGenreId = new Guid("dff051f5-5494-4def-bf66-e06e7fe51e4c")
                        },
                        new
                        {
                            Id = new Guid("2be416b2-fd54-43db-a24d-9bfb829ffe42"),
                            Name = "Off-road",
                            ParentGenreId = new Guid("dff051f5-5494-4def-bf66-e06e7fe51e4c")
                        },
                        new
                        {
                            Id = new Guid("8e6473ce-9008-48da-838a-35417c94f8ea"),
                            Name = "FPS",
                            ParentGenreId = new Guid("6d4eafb7-e2cc-46c5-803a-1968b78e2806")
                        },
                        new
                        {
                            Id = new Guid("7306bffe-62be-4d89-80eb-c15d266023cc"),
                            Name = "TPS",
                            ParentGenreId = new Guid("6d4eafb7-e2cc-46c5-803a-1968b78e2806")
                        });
                });

            modelBuilder.Entity("GameStoreWebApp.DataAccess.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("GameStoreWebApp.DataAccess.Entities.OrderGame", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Discount")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderGames");
                });

            modelBuilder.Entity("GameStoreWebApp.DataAccess.Entities.Platform", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Type")
                        .IsUnique();

                    b.ToTable("Platforms");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9f89098d-f089-4735-8b84-c218a76fab33"),
                            Type = "Mobile"
                        },
                        new
                        {
                            Id = new Guid("5fc42436-d9fa-4457-92ae-4ee5694f7d46"),
                            Type = "Browser"
                        },
                        new
                        {
                            Id = new Guid("7c54b04f-7fb4-4ffb-b08f-f23620c1b393"),
                            Type = "Desktop"
                        },
                        new
                        {
                            Id = new Guid("7dd628fb-48fa-4806-a3be-74341f3ab1c6"),
                            Type = "Console"
                        });
                });

            modelBuilder.Entity("GameStoreWebApp.DataAccess.Entities.Publisher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomePage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyName")
                        .IsUnique();

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("GameStoreWebApp.DataAccess.Entities.Game", b =>
                {
                    b.HasOne("GameStoreWebApp.DataAccess.Entities.Publisher", "Publisher")
                        .WithMany("Games")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("GameStoreWebApp.DataAccess.Entities.GameGenre", b =>
                {
                    b.HasOne("GameStoreWebApp.DataAccess.Entities.Game", "Game")
                        .WithMany("GameGenres")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameStoreWebApp.DataAccess.Entities.Genre", "Genre")
                        .WithMany("GameGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("GameStoreWebApp.DataAccess.Entities.GamePlatform", b =>
                {
                    b.HasOne("GameStoreWebApp.DataAccess.Entities.Game", "Game")
                        .WithMany("GamePlatforms")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameStoreWebApp.DataAccess.Entities.Platform", "Platform")
                        .WithMany("GamePlatforms")
                        .HasForeignKey("PlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Platform");
                });

            modelBuilder.Entity("GameStoreWebApp.DataAccess.Entities.Genre", b =>
                {
                    b.HasOne("GameStoreWebApp.DataAccess.Entities.Genre", "ParentGenre")
                        .WithMany("SubGenres")
                        .HasForeignKey("ParentGenreId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("ParentGenre");
                });

            modelBuilder.Entity("GameStoreWebApp.DataAccess.Entities.OrderGame", b =>
                {
                    b.HasOne("GameStoreWebApp.DataAccess.Entities.Order", "Order")
                        .WithMany("OrderGames")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameStoreWebApp.DataAccess.Entities.Game", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("GameStoreWebApp.DataAccess.Entities.Game", b =>
                {
                    b.Navigation("GameGenres");

                    b.Navigation("GamePlatforms");
                });

            modelBuilder.Entity("GameStoreWebApp.DataAccess.Entities.Genre", b =>
                {
                    b.Navigation("GameGenres");

                    b.Navigation("SubGenres");
                });

            modelBuilder.Entity("GameStoreWebApp.DataAccess.Entities.Order", b =>
                {
                    b.Navigation("OrderGames");
                });

            modelBuilder.Entity("GameStoreWebApp.DataAccess.Entities.Platform", b =>
                {
                    b.Navigation("GamePlatforms");
                });

            modelBuilder.Entity("GameStoreWebApp.DataAccess.Entities.Publisher", b =>
                {
                    b.Navigation("Games");
                });
#pragma warning restore 612, 618
        }
    }
}
