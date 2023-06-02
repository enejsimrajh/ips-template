﻿// <auto-generated />
using System;
using Core.DALEF.ContextFactory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230602120306_Identity")]
    partial class Identity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Core.DAL.Models.SYSetting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateChanged")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateTimeValue")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DecimalValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("LevelValue")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Module")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("StringValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserChangedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserCreatedID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("SYSetting");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d81229a0-cf63-46c0-87f4-59db2ee37256"),
                            Active = true,
                            DateChanged = new DateTime(1800, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateCreated = new DateTime(1800, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DecimalValue = 0m,
                            Level = 1,
                            Module = "SY",
                            Name = "DataSchemaVersion",
                            StringValue = "SchemaVersion.V1_0_0",
                            Type = "System.String",
                            UserChangedID = new Guid("89b87015-b687-4cad-a553-f911cf2e6fcf"),
                            UserCreatedID = new Guid("89b87015-b687-4cad-a553-f911cf2e6fcf")
                        });
                });

            modelBuilder.Entity("IPSTemplate.Dal.Models.Identity.TEIdentityRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Role", "Identity");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fcb01c05-f06b-4a3e-b08d-34540ac91b22"),
                            ConcurrencyStamp = "04aaa4c4-015c-47bd-84e3-f660c83eec34",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = new Guid("ed57c3a7-d092-4c10-b608-23d66a63c261"),
                            ConcurrencyStamp = "47febb0e-091b-49aa-9ba0-ecf94e815713",
                            Name = "Member",
                            NormalizedName = "MEMBER"
                        });
                });

            modelBuilder.Entity("IPSTemplate.Dal.Models.Identity.TEIdentityUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordResetToken")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ResetTokenExpireUtc")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("User", "Identity");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                            AccessFailedCount = 0,
                            Active = true,
                            ConcurrencyStamp = "04aaa4c4-015c-47bd-84e3-f660c83eec34",
                            Email = "admin@ipstemplate.org",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "Administrator",
                            NormalizedEmail = "ADMIN@IPSTEMPLATE.ORG",
                            NormalizedUserName = "ADMINISTRATOR",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "25f7786d-61d3-4db3-b8d9-d47e103f1f30",
                            TwoFactorEnabled = false,
                            UserName = "Administrator"
                        },
                        new
                        {
                            Id = new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                            AccessFailedCount = 0,
                            Active = true,
                            ConcurrencyStamp = "47febb0e-091b-49aa-9ba0-ecf94e815713",
                            Email = "member@ipstemplate.org",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "Member",
                            NormalizedEmail = "MEMBER@IPSTEMPLATE.ORG",
                            NormalizedUserName = "MEMBER",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cfd940dd-cbba-47be-8817-410bfb562a1a",
                            TwoFactorEnabled = false,
                            UserName = "Member"
                        });
                });

            modelBuilder.Entity("IPSTemplate.Dal.Models.TEEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Attribute1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateChanged")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<Guid>("UserChangedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserCreatedID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("TEEntity");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c041f416-41e6-419e-b832-7e67c6c35fda"),
                            Active = true,
                            Attribute1 = "This is a seed record.",
                            DateChanged = new DateTime(1800, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateCreated = new DateTime(1800, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserChangedID = new Guid("89b87015-b687-4cad-a553-f911cf2e6fcf"),
                            UserCreatedID = new Guid("89b87015-b687-4cad-a553-f911cf2e6fcf")
                        },
                        new
                        {
                            Id = new Guid("50366dd5-49e5-4cc4-a06d-5ec6f4c0805e"),
                            Active = true,
                            Attribute1 = "This is a dummy record.",
                            DateChanged = new DateTime(1800, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateCreated = new DateTime(1800, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserChangedID = new Guid("89b87015-b687-4cad-a553-f911cf2e6fcf"),
                            UserCreatedID = new Guid("89b87015-b687-4cad-a553-f911cf2e6fcf")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaim", "Identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaim", "Identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogin", "Identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRole", "Identity");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("a4455c52-cd74-4230-b647-30c717f4d164"),
                            RoleId = new Guid("fcb01c05-f06b-4a3e-b08d-34540ac91b22")
                        },
                        new
                        {
                            UserId = new Guid("ddcb65c5-3170-48be-bc9a-7bc89f741286"),
                            RoleId = new Guid("ed57c3a7-d092-4c10-b608-23d66a63c261")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserToken", "Identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("IPSTemplate.Dal.Models.Identity.TEIdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("IPSTemplate.Dal.Models.Identity.TEIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("IPSTemplate.Dal.Models.Identity.TEIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("IPSTemplate.Dal.Models.Identity.TEIdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("IPSTemplate.Dal.Models.Identity.TEIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("IPSTemplate.Dal.Models.Identity.TEIdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
