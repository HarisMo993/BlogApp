﻿// <auto-generated />
using System;
using Blog.Api.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Blog.Api.Migrations
{
    [DbContext(typeof(BlogContext))]
    partial class BlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Blog.Api.Database.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("tags")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Body = "The app is simple to use, and will help you decide on your best furniture fit.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.",
                            Slug = "augmented-reality-ios-application",
                            Title = "Augmented Reality iOS Application",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            tags = "[\"iOS\",\"AR\"]"
                        },
                        new
                        {
                            Id = 2,
                            Body = "The app is simple to use, and will help you decide on your best furniture fit.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.",
                            Slug = "augmented-reality-ios-application-2",
                            Title = "Augmented Reality iOS Application 2",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            tags = "[\"iOS\",\"AR\"]"
                        },
                        new
                        {
                            Id = 3,
                            Body = "The app is simple to use, and will help you decide on your best furniture fit.",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.",
                            Slug = "augmented-reality-ios-application-3",
                            Title = "Augmented Reality iOS Application 3",
                            UpdateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            tags = "[\"iOS\",\"AR\",\"Gazzda\"]"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}