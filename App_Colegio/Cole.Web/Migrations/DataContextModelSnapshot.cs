﻿// <auto-generated />
using System;
using Cole.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cole.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cole.Web.Data.Entities.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Abono")
                        .HasColumnType("decimal(12,2)");

                    b.Property<string>("Concepto")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<DateTime>("FechaVencimiento");

                    b.Property<int>("IdCiclo");

                    b.Property<int>("LLaveRef");

                    b.Property<int>("Persona_Id");

                    b.Property<string>("Plantel")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("Recargo")
                        .HasColumnType("decimal(12,2)");

                    b.Property<decimal>("Saldo")
                        .HasColumnType("decimal(12,2)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(12,2)");

                    b.HasKey("Id");

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("Cole.Web.Data.Entities.Grupo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("NameGrupo")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Persona_Id");

                    b.Property<string>("TipoGrupo")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Grupos");
                });

            modelBuilder.Entity("Cole.Web.Data.Entities.Pago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Abono")
                        .HasColumnType("decimal(12,2)");

                    b.Property<string>("Banco")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("Descuento")
                        .HasColumnType("decimal(12,2)");

                    b.Property<bool>("Estatus");

                    b.Property<string>("Factura")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("FechaAbono");

                    b.Property<string>("Folio")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("Importe")
                        .HasColumnType("decimal(12,2)");

                    b.Property<int>("LLaveRef_Enc");

                    b.Property<decimal>("Recargo")
                        .HasColumnType("decimal(12,2)");

                    b.Property<string>("Referencia")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Serie_Factura")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("TipoPago")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("TotalAbono")
                        .HasColumnType("decimal(12,2)");

                    b.HasKey("Id");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("Cole.Web.Data.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido_Materno")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Apellido_Paterno")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Clave_Familia")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Clave_Plantel")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Grado")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Grupo")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Nivel")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Persona_Id");

                    b.Property<string>("Plantel")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Cole.Web.Data.Entities.Tutor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido_Materno")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Apellido_Paterno")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Clave_Familia")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Parentesco")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("Persona_Id");

                    b.Property<bool>("Tutor_Principal")
                        .HasMaxLength(20);

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Tutors");
                });

            modelBuilder.Entity("Cole.Web.Data.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Clave_Familia");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<int>("Persona_Id");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Cole.Web.Data.Entities.Tutor", b =>
                {
                    b.HasOne("Cole.Web.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Cole.Web.Data.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Cole.Web.Data.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Cole.Web.Data.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Cole.Web.Data.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
