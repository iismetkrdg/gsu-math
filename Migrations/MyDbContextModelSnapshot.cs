﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace gsumath.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("gsu_math.Models.Bilgi", b =>
                {
                    b.Property<int>("BilgiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Başlık")
                        .HasColumnType("TEXT");

                    b.Property<string>("Metin")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tür")
                        .HasColumnType("TEXT");

                    b.HasKey("BilgiId");

                    b.ToTable("Bilgi");
                });

            modelBuilder.Entity("gsu_math.Models.Duyuru", b =>
                {
                    b.Property<int>("DuyuruId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Baslik")
                        .HasColumnType("TEXT");

                    b.Property<string>("Foto")
                        .HasColumnType("TEXT");

                    b.Property<string>("Metin")
                        .HasColumnType("TEXT");

                    b.HasKey("DuyuruId");

                    b.ToTable("Duyuru");
                });

            modelBuilder.Entity("gsu_math.Models.ForumBaslik", b =>
                {
                    b.Property<int>("ForumBaslikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AtCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Baslik")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("slug")
                        .HasColumnType("TEXT");

                    b.HasKey("ForumBaslikId");

                    b.ToTable("ForumBaslik");
                });

            modelBuilder.Entity("gsu_math.Models.ForumCevap", b =>
                {
                    b.Property<int>("ForumCevapId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BegeniSayisi")
                        .HasColumnType("TEXT");

                    b.Property<int>("ForumBaslikId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Metin")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ForumCevapId");

                    b.ToTable("ForumCevap");
                });

            modelBuilder.Entity("gsu_math.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AdSoyad")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AtCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConfirmPwd")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Is_admin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
