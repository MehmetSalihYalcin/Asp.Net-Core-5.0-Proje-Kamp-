﻿// <auto-generated />
using System;
using DataAccessLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230319123107_mig11")]
    partial class mig11
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.Concrate.About", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("About_Details1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("About_Details2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("About_Image1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("About_Image2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("About_MapLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("About_Status")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Blog", b =>
                {
                    b.Property<int>("Blog_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Blog_ID"));

                    b.Property<string>("Blog_Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Blog_CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Blog_Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Blog_Status")
                        .HasColumnType("bit");

                    b.Property<string>("Blog_ThumbNailImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Blog_Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Category_ID")
                        .HasColumnType("int");

                    b.HasKey("Blog_ID");

                    b.HasIndex("Category_ID");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Category", b =>
                {
                    b.Property<int>("Category_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Category_ID"));

                    b.Property<string>("Category_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Category_Status")
                        .HasColumnType("bit");

                    b.HasKey("Category_ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Comment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Blog_ID")
                        .HasColumnType("int");

                    b.Property<string>("Comment_Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Comment_Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Comment_Status")
                        .HasColumnType("bit");

                    b.Property<string>("Comment_Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment_UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("Blog_ID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Contact", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Contact_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Contact_Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact_Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Contact_Status")
                        .HasColumnType("bit");

                    b.Property<string>("Contact_Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact_UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Writer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Writer_About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Writer_Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Writer_Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Writer_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Writer_Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Writer_Status")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Writers");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Blog", b =>
                {
                    b.HasOne("EntityLayer.Concrate.Category", "Category")
                        .WithMany()
                        .HasForeignKey("Category_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EntityLayer.Concrate.Comment", b =>
                {
                    b.HasOne("EntityLayer.Concrate.Blog", "Blog")
                        .WithMany()
                        .HasForeignKey("Blog_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });
#pragma warning restore 612, 618
        }
    }
}
