﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using STIVE_API.Data;

namespace STIVE_API.Migrations
{
    [DbContext(typeof(StiveDbContext))]
    [Migration("20211217131340_createDB")]
    partial class createDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("STIVE_API.Data.Models.Articles.Annee", b =>
                {
                    b.Property<Guid>("AnneeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("AnneeId");

                    b.ToTable("Annee");

                    b.HasData(
                        new
                        {
                            AnneeId = new Guid("ce55680e-2525-4a7e-8982-2be152174cb3"),
                            Number = 2010
                        },
                        new
                        {
                            AnneeId = new Guid("0df9015f-adf9-41ea-ac45-7b5d2018c897"),
                            Number = 2011
                        },
                        new
                        {
                            AnneeId = new Guid("b6b09797-f033-48e1-80e6-ee02c94ac731"),
                            Number = 2012
                        },
                        new
                        {
                            AnneeId = new Guid("764cd196-8a02-4853-b7d5-f218fde81145"),
                            Number = 2013
                        },
                        new
                        {
                            AnneeId = new Guid("bd9fcfe7-ef9a-47b6-9697-e8685178dcb1"),
                            Number = 2014
                        },
                        new
                        {
                            AnneeId = new Guid("63e4eb17-4e35-4f0d-a38f-df81bc950473"),
                            Number = 2015
                        },
                        new
                        {
                            AnneeId = new Guid("a4f0ac8f-1bf2-4d38-8fea-115d7a993315"),
                            Number = 2016
                        },
                        new
                        {
                            AnneeId = new Guid("96227d7a-0afb-481a-ba5a-46e0de6989b6"),
                            Number = 2017
                        },
                        new
                        {
                            AnneeId = new Guid("c34dd3fa-4862-4123-b07b-baaf8fac89a5"),
                            Number = 2018
                        },
                        new
                        {
                            AnneeId = new Guid("926c80bb-9cb0-488e-83df-3fccbb7e713b"),
                            Number = 2019
                        },
                        new
                        {
                            AnneeId = new Guid("cd9a6276-a0ba-497f-955b-41b1827daec9"),
                            Number = 2020
                        },
                        new
                        {
                            AnneeId = new Guid("3b648b81-59f7-45a0-b381-b65015b15295"),
                            Number = 2021
                        });
                });

            modelBuilder.Entity("STIVE_API.Data.Models.Articles.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AnneeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AnneeId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CapacityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CapacityId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CepageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CepageId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("FamilyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FamilyId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Ref")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SupplierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SupplierId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("AnneeId");

                    b.HasIndex("AnneeId1");

                    b.HasIndex("CapacityId");

                    b.HasIndex("CapacityId1");

                    b.HasIndex("CepageId");

                    b.HasIndex("CepageId1");

                    b.HasIndex("FamilyId");

                    b.HasIndex("FamilyId1");

                    b.HasIndex("SupplierId");

                    b.HasIndex("SupplierId1");

                    b.ToTable("Article");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cb270d40-0a21-4a94-ada9-ee1aba9df29c"),
                            AnneeId = new Guid("ce55680e-2525-4a7e-8982-2be152174cb3"),
                            CapacityId = new Guid("4990bf1e-107f-46ab-abfb-760afaa03288"),
                            CepageId = new Guid("a114a73c-8421-473a-8a0f-e4aad580e579"),
                            Description = "Description à venir",
                            FamilyId = new Guid("fd6dbe0a-7402-476d-af03-948b85ab51bd"),
                            Name = "Bouteille de vin",
                            Ref = "152DER147DFM9",
                            SupplierId = new Guid("9b0b6d9e-8941-4b27-8420-c428ff21c493"),
                            UnitPrice = 5.5999999999999996
                        },
                        new
                        {
                            Id = new Guid("5e4004a9-63a7-4a3b-b514-c0cd65608bfe"),
                            AnneeId = new Guid("3b648b81-59f7-45a0-b381-b65015b15295"),
                            CapacityId = new Guid("5cb373ab-490e-478f-a7a3-a82b24728515"),
                            CepageId = new Guid("af79be29-5e24-4def-823c-365386d0867f"),
                            Description = "Description à venir",
                            FamilyId = new Guid("eb031d7a-3d9e-45ca-a45f-ce1c01279214"),
                            Name = "Bouteille de bordeau",
                            Ref = "452SER197DRP9",
                            SupplierId = new Guid("9b0b6d9e-8941-4b27-8420-c428ff21c493"),
                            UnitPrice = 3.5
                        });
                });

            modelBuilder.Entity("STIVE_API.Data.Models.Articles.Capacity", b =>
                {
                    b.Property<Guid>("CapacityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("BottleCapacity")
                        .HasColumnType("float");

                    b.HasKey("CapacityId");

                    b.ToTable("Capacity");

                    b.HasData(
                        new
                        {
                            CapacityId = new Guid("4990bf1e-107f-46ab-abfb-760afaa03288"),
                            BottleCapacity = 75.0
                        },
                        new
                        {
                            CapacityId = new Guid("5cb373ab-490e-478f-a7a3-a82b24728515"),
                            BottleCapacity = 37.5
                        });
                });

            modelBuilder.Entity("STIVE_API.Data.Models.Articles.Cepage", b =>
                {
                    b.Property<Guid>("CepageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Origin")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CepageId");

                    b.ToTable("Cepage");

                    b.HasData(
                        new
                        {
                            CepageId = new Guid("a114a73c-8421-473a-8a0f-e4aad580e579"),
                            Name = "Chardonnay",
                            Origin = "France"
                        },
                        new
                        {
                            CepageId = new Guid("416fa7b9-ec8f-43cd-ae7d-1300bcd3b0b1"),
                            Name = "Sauvignon",
                            Origin = "France"
                        },
                        new
                        {
                            CepageId = new Guid("36c57b07-edab-4ed5-974b-73570fd6c9db"),
                            Name = "Pinot Noir",
                            Origin = "Allemagne"
                        },
                        new
                        {
                            CepageId = new Guid("a6658b70-b4a9-4c42-bee2-f97aa9d6c28c"),
                            Name = "Riesling",
                            Origin = "France"
                        },
                        new
                        {
                            CepageId = new Guid("c36bf241-624c-43a6-a5bf-7fb3ed7f38d1"),
                            Name = "Gewurztraminer",
                            Origin = "France"
                        },
                        new
                        {
                            CepageId = new Guid("cab72940-c2df-456d-bcea-6a3eaa3b5187"),
                            Name = "Merlot noir",
                            Origin = "France"
                        },
                        new
                        {
                            CepageId = new Guid("af79be29-5e24-4def-823c-365386d0867f"),
                            Name = "Mauzac rosé",
                            Origin = "France"
                        });
                });

            modelBuilder.Entity("STIVE_API.Data.Models.Articles.Family", b =>
                {
                    b.Property<Guid>("FamilyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FamilyId");

                    b.ToTable("Family");

                    b.HasData(
                        new
                        {
                            FamilyId = new Guid("fd6dbe0a-7402-476d-af03-948b85ab51bd"),
                            Name = "Rosé"
                        },
                        new
                        {
                            FamilyId = new Guid("177ea6b0-0549-4505-96ae-8842d42a0c9b"),
                            Name = "Vin blanc"
                        },
                        new
                        {
                            FamilyId = new Guid("87e572ff-3020-464a-b17b-e12921289938"),
                            Name = "Vin rouge"
                        },
                        new
                        {
                            FamilyId = new Guid("b012c94b-4173-4821-8708-f996dbd17ebb"),
                            Name = "Muscat"
                        },
                        new
                        {
                            FamilyId = new Guid("07fbf3f3-1b7b-4817-bf90-0f5727ad29a5"),
                            Name = "Vin cuit"
                        },
                        new
                        {
                            FamilyId = new Guid("eb031d7a-3d9e-45ca-a45f-ce1c01279214"),
                            Name = "Mousseux"
                        });
                });

            modelBuilder.Entity("STIVE_API.Data.Models.Articles.Stock", b =>
                {
                    b.Property<Guid>("StockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ArticleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Limit")
                        .HasColumnType("int");

                    b.Property<int>("Provision")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("StockId");

                    b.HasIndex("ArticleId");

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("STIVE_API.Data.Models.Orders.ArticleRow", b =>
                {
                    b.Property<Guid>("ArticleRowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ArticleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClientOrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ArticleRowId");

                    b.HasIndex("ArticleId");

                    b.HasIndex("ClientOrderId");

                    b.ToTable("ArticleRow");
                });

            modelBuilder.Entity("STIVE_API.Data.Models.Orders.ClientOrder", b =>
                {
                    b.Property<Guid>("ClientOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("HTPrice")
                        .HasColumnType("float");

                    b.Property<string>("Reference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("TTCPrice")
                        .HasColumnType("float");

                    b.HasKey("ClientOrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("StatusId");

                    b.ToTable("ClientOrder");

                    b.HasData(
                        new
                        {
                            ClientOrderId = new Guid("15ba98fe-e5ed-4658-84c9-ad7a0be8814f"),
                            CustomerId = new Guid("9c33e8ac-14c1-4b1b-927f-c7bfd46ce9b7"),
                            Date = new DateTime(2021, 12, 17, 13, 13, 40, 303, DateTimeKind.Utc).AddTicks(8738),
                            HTPrice = 0.0,
                            Reference = "TEST123456",
                            StatusId = new Guid("0a145546-df81-461a-b58b-0d0b4724183e"),
                            TTCPrice = 0.0
                        },
                        new
                        {
                            ClientOrderId = new Guid("e296e86d-0e05-44cd-bedf-e20a771371b3"),
                            CustomerId = new Guid("e1713f5b-37d1-4084-b3dd-63fc685c02c9"),
                            Date = new DateTime(2021, 12, 17, 13, 13, 40, 303, DateTimeKind.Utc).AddTicks(9085),
                            HTPrice = 0.0,
                            Reference = "TEST234567",
                            StatusId = new Guid("0a145546-df81-461a-b58b-0d0b4724183e"),
                            TTCPrice = 0.0
                        });
                });

            modelBuilder.Entity("STIVE_API.Data.Models.Orders.PurchaseOrder", b =>
                {
                    b.Property<Guid>("PurshaseOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ArticleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("HTPrice")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid?>("SupplierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("TTCPrice")
                        .HasColumnType("float");

                    b.HasKey("PurshaseOrderId");

                    b.HasIndex("ArticleId");

                    b.HasIndex("SupplierId");

                    b.ToTable("PurchaseOrder");
                });

            modelBuilder.Entity("STIVE_API.Data.Models.Orders.Status", b =>
                {
                    b.Property<Guid>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusId");

                    b.ToTable("Status");

                    b.HasData(
                        new
                        {
                            StatusId = new Guid("0a145546-df81-461a-b58b-0d0b4724183e"),
                            Name = "Vérification en cours"
                        },
                        new
                        {
                            StatusId = new Guid("9fa281a7-2fb8-47e1-b89b-fc0bde1a164d"),
                            Name = "Terminée"
                        },
                        new
                        {
                            StatusId = new Guid("81cf26b2-e141-4839-9adb-e753b5c112f7"),
                            Name = "Archivée"
                        },
                        new
                        {
                            StatusId = new Guid("00043d72-92f4-4c05-86b6-64b5a52b1ffb"),
                            Name = "Livrée"
                        },
                        new
                        {
                            StatusId = new Guid("90e2b117-8808-4b65-ac21-56783f094461"),
                            Name = "En cours d'approvisionnement"
                        },
                        new
                        {
                            StatusId = new Guid("731a831c-183d-49e8-a416-d5df47f5ad53"),
                            Name = "En cours de traitement"
                        },
                        new
                        {
                            StatusId = new Guid("5b8a2209-1389-43f7-86d3-70564e96202c"),
                            Name = "En préparation"
                        },
                        new
                        {
                            StatusId = new Guid("615ee3dc-b9fc-4b82-aafe-ed3d3aaaec4c"),
                            Name = "En cours d'acheminement"
                        },
                        new
                        {
                            StatusId = new Guid("fa3e23ac-e929-4a66-b33b-334135134fa3"),
                            Name = "j'ai volé votre bouteille, merci, bisous, de Greg."
                        });
                });

            modelBuilder.Entity("STIVE_API.Data.Models.Orders.Supplier", b =>
                {
                    b.Property<Guid>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Siret")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupplierId");

                    b.ToTable("Supplier");

                    b.HasData(
                        new
                        {
                            SupplierId = new Guid("9b0b6d9e-8941-4b27-8420-c428ff21c493"),
                            Adress = "14 Rue Louis Ruquier",
                            City = "Sotteville-lès-Rouen",
                            Cp = "76300",
                            Name = "La Centrale des Vins",
                            PhoneNumber = "02 35 73 03 93",
                            Siret = "38862771300067"
                        });
                });

            modelBuilder.Entity("STIVE_API.Data.Models.Users.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerReference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9c33e8ac-14c1-4b1b-927f-c7bfd46ce9b7"),
                            Adress = "1 chemin des alisiers 67700 Saverne",
                            City = "Saverne",
                            Cp = "67700",
                            CustomerReference = "V2CP8CZAVGZ9",
                            Email = "luciole.trp@gmail.com",
                            FirstName = "Lucile",
                            LastName = "TRIPIER",
                            Password = "123",
                            PhoneNumber = "0699318613"
                        },
                        new
                        {
                            Id = new Guid("e1713f5b-37d1-4084-b3dd-63fc685c02c9"),
                            Adress = "123 rue des chats",
                            City = "CroquetteLand",
                            Cp = "000009",
                            CustomerReference = "V5QT1PK7XBVL",
                            Email = "gregory.lbl@gmail.com",
                            FirstName = "Gregory",
                            LastName = "LEBLOND",
                            Password = "123",
                            PhoneNumber = "0631258641"
                        });
                });

            modelBuilder.Entity("STIVE_API.Data.Models.Users.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2c550678-eeb2-48f4-b007-ece1a4eda682"),
                            Adress = "3 Grande rue",
                            City = "Rouen",
                            Cp = "76000",
                            Email = "mariam.el@gmail.com",
                            EmployeNumber = "003KVRLJ1P",
                            FirstName = "Mariam",
                            LastName = "EL-ALLALI",
                            Password = "123",
                            PhoneNumber = "0698574123"
                        },
                        new
                        {
                            Id = new Guid("a92685dc-bd7c-4d54-90f2-44eab2772738"),
                            Adress = "57 Boulevard Gambetta",
                            City = "Evreux",
                            Cp = "27000",
                            Email = "francois.dupont@yahoo.com",
                            EmployeNumber = "NF4O44XBH3",
                            FirstName = "François",
                            LastName = "DUPONT",
                            Password = "123",
                            PhoneNumber = "0635241896"
                        },
                        new
                        {
                            Id = new Guid("4cc04b75-03ed-4e2a-a0c9-2bb39dc15e91"),
                            Adress = "21 Rue Victor Hugo",
                            City = "Evreux",
                            Cp = "27000",
                            Email = "francine.dupont@gmail.com",
                            EmployeNumber = "5H8VQA022W",
                            FirstName = "Francine",
                            LastName = "DUPONT",
                            Password = "123",
                            PhoneNumber = "0632547896"
                        },
                        new
                        {
                            Id = new Guid("9eb414a3-d752-4e17-a3aa-1f3b71825213"),
                            Adress = "3 Rue du Bout au Roussel",
                            City = "Champenard",
                            Cp = "27600",
                            Email = "jeremy.petit@outlook.com",
                            EmployeNumber = "F8I5QSH1OR",
                            FirstName = "Jeremy",
                            LastName = "PETIT",
                            Password = "123",
                            PhoneNumber = "0652341254"
                        });
                });

            modelBuilder.Entity("STIVE_API.Data.Models.Articles.Article", b =>
                {
                    b.HasOne("STIVE_API.Data.Models.Articles.Annee", null)
                        .WithMany()
                        .HasForeignKey("AnneeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("STIVE_API.Data.Models.Articles.Annee", "Annee")
                        .WithMany()
                        .HasForeignKey("AnneeId1");

                    b.HasOne("STIVE_API.Data.Models.Articles.Capacity", null)
                        .WithMany()
                        .HasForeignKey("CapacityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("STIVE_API.Data.Models.Articles.Capacity", "Capacity")
                        .WithMany()
                        .HasForeignKey("CapacityId1");

                    b.HasOne("STIVE_API.Data.Models.Articles.Cepage", null)
                        .WithMany()
                        .HasForeignKey("CepageId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("STIVE_API.Data.Models.Articles.Cepage", "Cepage")
                        .WithMany()
                        .HasForeignKey("CepageId1");

                    b.HasOne("STIVE_API.Data.Models.Articles.Family", null)
                        .WithMany()
                        .HasForeignKey("FamilyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("STIVE_API.Data.Models.Articles.Family", "Family")
                        .WithMany()
                        .HasForeignKey("FamilyId1");

                    b.HasOne("STIVE_API.Data.Models.Orders.Supplier", null)
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("STIVE_API.Data.Models.Orders.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId1");

                    b.Navigation("Annee");

                    b.Navigation("Capacity");

                    b.Navigation("Cepage");

                    b.Navigation("Family");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("STIVE_API.Data.Models.Articles.Stock", b =>
                {
                    b.HasOne("STIVE_API.Data.Models.Articles.Article", "Article")
                        .WithMany()
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");
                });

            modelBuilder.Entity("STIVE_API.Data.Models.Orders.ArticleRow", b =>
                {
                    b.HasOne("STIVE_API.Data.Models.Articles.Article", "Article")
                        .WithMany()
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("STIVE_API.Data.Models.Orders.ClientOrder", "ClientOrder")
                        .WithMany()
                        .HasForeignKey("ClientOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("ClientOrder");
                });

            modelBuilder.Entity("STIVE_API.Data.Models.Orders.ClientOrder", b =>
                {
                    b.HasOne("STIVE_API.Data.Models.Users.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("STIVE_API.Data.Models.Orders.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("STIVE_API.Data.Models.Orders.PurchaseOrder", b =>
                {
                    b.HasOne("STIVE_API.Data.Models.Articles.Article", "Article")
                        .WithMany()
                        .HasForeignKey("ArticleId");

                    b.HasOne("STIVE_API.Data.Models.Orders.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId");

                    b.Navigation("Article");

                    b.Navigation("Supplier");
                });
#pragma warning restore 612, 618
        }
    }
}