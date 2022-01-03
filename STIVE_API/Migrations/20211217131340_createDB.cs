using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace STIVE_API.Migrations
{
    public partial class createDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Annee",
                columns: table => new
                {
                    AnneeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Annee", x => x.AnneeId);
                });

            migrationBuilder.CreateTable(
                name: "Capacity",
                columns: table => new
                {
                    CapacityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BottleCapacity = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Capacity", x => x.CapacityId);
                });

            migrationBuilder.CreateTable(
                name: "Cepage",
                columns: table => new
                {
                    CepageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cepage", x => x.CepageId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Family",
                columns: table => new
                {
                    FamilyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Family", x => x.FamilyId);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Siret = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "ClientOrder",
                columns: table => new
                {
                    ClientOrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HTPrice = table.Column<double>(type: "float", nullable: false),
                    TTCPrice = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientOrder", x => x.ClientOrderId);
                    table.ForeignKey(
                        name: "FK_ClientOrder_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientOrder_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnneeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnneeId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CapacityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CapacityId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CepageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CepageId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FamilyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FamilyId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupplierId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ref = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    Picture = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Article_Annee_AnneeId",
                        column: x => x.AnneeId,
                        principalTable: "Annee",
                        principalColumn: "AnneeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Article_Annee_AnneeId1",
                        column: x => x.AnneeId1,
                        principalTable: "Annee",
                        principalColumn: "AnneeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Article_Capacity_CapacityId",
                        column: x => x.CapacityId,
                        principalTable: "Capacity",
                        principalColumn: "CapacityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Article_Capacity_CapacityId1",
                        column: x => x.CapacityId1,
                        principalTable: "Capacity",
                        principalColumn: "CapacityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Article_Cepage_CepageId",
                        column: x => x.CepageId,
                        principalTable: "Cepage",
                        principalColumn: "CepageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Article_Cepage_CepageId1",
                        column: x => x.CepageId1,
                        principalTable: "Cepage",
                        principalColumn: "CepageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Article_Family_FamilyId",
                        column: x => x.FamilyId,
                        principalTable: "Family",
                        principalColumn: "FamilyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Article_Family_FamilyId1",
                        column: x => x.FamilyId1,
                        principalTable: "Family",
                        principalColumn: "FamilyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Article_Supplier_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Supplier",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Article_Supplier_SupplierId1",
                        column: x => x.SupplierId1,
                        principalTable: "Supplier",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArticleRow",
                columns: table => new
                {
                    ArticleRowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ClientOrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleRow", x => x.ArticleRowId);
                    table.ForeignKey(
                        name: "FK_ArticleRow_Article_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Article",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleRow_ClientOrder_ClientOrderId",
                        column: x => x.ClientOrderId,
                        principalTable: "ClientOrder",
                        principalColumn: "ClientOrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrder",
                columns: table => new
                {
                    PurshaseOrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TTCPrice = table.Column<double>(type: "float", nullable: false),
                    HTPrice = table.Column<double>(type: "float", nullable: false),
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrder", x => x.PurshaseOrderId);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Article_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Article",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Supplier_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Supplier",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    StockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Limit = table.Column<int>(type: "int", nullable: false),
                    Provision = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.StockId);
                    table.ForeignKey(
                        name: "FK_Stock_Article_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Article",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Annee",
                columns: new[] { "AnneeId", "Number" },
                values: new object[,]
                {
                    { new Guid("ce55680e-2525-4a7e-8982-2be152174cb3"), 2010 },
                    { new Guid("0df9015f-adf9-41ea-ac45-7b5d2018c897"), 2011 },
                    { new Guid("b6b09797-f033-48e1-80e6-ee02c94ac731"), 2012 },
                    { new Guid("764cd196-8a02-4853-b7d5-f218fde81145"), 2013 },
                    { new Guid("bd9fcfe7-ef9a-47b6-9697-e8685178dcb1"), 2014 },
                    { new Guid("63e4eb17-4e35-4f0d-a38f-df81bc950473"), 2015 },
                    { new Guid("a4f0ac8f-1bf2-4d38-8fea-115d7a993315"), 2016 },
                    { new Guid("96227d7a-0afb-481a-ba5a-46e0de6989b6"), 2017 },
                    { new Guid("c34dd3fa-4862-4123-b07b-baaf8fac89a5"), 2018 },
                    { new Guid("926c80bb-9cb0-488e-83df-3fccbb7e713b"), 2019 },
                    { new Guid("cd9a6276-a0ba-497f-955b-41b1827daec9"), 2020 },
                    { new Guid("3b648b81-59f7-45a0-b381-b65015b15295"), 2021 }
                });

            migrationBuilder.InsertData(
                table: "Capacity",
                columns: new[] { "CapacityId", "BottleCapacity" },
                values: new object[,]
                {
                    { new Guid("5cb373ab-490e-478f-a7a3-a82b24728515"), 37.5 },
                    { new Guid("4990bf1e-107f-46ab-abfb-760afaa03288"), 75.0 }
                });

            migrationBuilder.InsertData(
                table: "Cepage",
                columns: new[] { "CepageId", "Name", "Origin" },
                values: new object[,]
                {
                    { new Guid("a114a73c-8421-473a-8a0f-e4aad580e579"), "Chardonnay", "France" },
                    { new Guid("416fa7b9-ec8f-43cd-ae7d-1300bcd3b0b1"), "Sauvignon", "France" },
                    { new Guid("36c57b07-edab-4ed5-974b-73570fd6c9db"), "Pinot Noir", "Allemagne" },
                    { new Guid("a6658b70-b4a9-4c42-bee2-f97aa9d6c28c"), "Riesling", "France" },
                    { new Guid("c36bf241-624c-43a6-a5bf-7fb3ed7f38d1"), "Gewurztraminer", "France" },
                    { new Guid("cab72940-c2df-456d-bcea-6a3eaa3b5187"), "Merlot noir", "France" },
                    { new Guid("af79be29-5e24-4def-823c-365386d0867f"), "Mauzac rosé", "France" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Adress", "City", "Cp", "CustomerReference", "Email", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("e1713f5b-37d1-4084-b3dd-63fc685c02c9"), "123 rue des chats", "CroquetteLand", "000009", "V5QT1PK7XBVL", "gregory.lbl@gmail.com", "Gregory", "LEBLOND", "123", "0631258641" },
                    { new Guid("9c33e8ac-14c1-4b1b-927f-c7bfd46ce9b7"), "1 chemin des alisiers 67700 Saverne", "Saverne", "67700", "V2CP8CZAVGZ9", "luciole.trp@gmail.com", "Lucile", "TRIPIER", "123", "0699318613" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Adress", "City", "Cp", "Email", "EmployeNumber", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("a92685dc-bd7c-4d54-90f2-44eab2772738"), "57 Boulevard Gambetta", "Evreux", "27000", "francois.dupont@yahoo.com", "NF4O44XBH3", "François", "DUPONT", "123", "0635241896" },
                    { new Guid("2c550678-eeb2-48f4-b007-ece1a4eda682"), "3 Grande rue", "Rouen", "76000", "mariam.el@gmail.com", "003KVRLJ1P", "Mariam", "EL-ALLALI", "123", "0698574123" },
                    { new Guid("9eb414a3-d752-4e17-a3aa-1f3b71825213"), "3 Rue du Bout au Roussel", "Champenard", "27600", "jeremy.petit@outlook.com", "F8I5QSH1OR", "Jeremy", "PETIT", "123", "0652341254" },
                    { new Guid("4cc04b75-03ed-4e2a-a0c9-2bb39dc15e91"), "21 Rue Victor Hugo", "Evreux", "27000", "francine.dupont@gmail.com", "5H8VQA022W", "Francine", "DUPONT", "123", "0632547896" }
                });

            migrationBuilder.InsertData(
                table: "Family",
                columns: new[] { "FamilyId", "Name" },
                values: new object[,]
                {
                    { new Guid("eb031d7a-3d9e-45ca-a45f-ce1c01279214"), "Mousseux" },
                    { new Guid("177ea6b0-0549-4505-96ae-8842d42a0c9b"), "Vin blanc" },
                    { new Guid("87e572ff-3020-464a-b17b-e12921289938"), "Vin rouge" },
                    { new Guid("b012c94b-4173-4821-8708-f996dbd17ebb"), "Muscat" },
                    { new Guid("07fbf3f3-1b7b-4817-bf90-0f5727ad29a5"), "Vin cuit" },
                    { new Guid("fd6dbe0a-7402-476d-af03-948b85ab51bd"), "Rosé" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "StatusId", "Name" },
                values: new object[,]
                {
                    { new Guid("5b8a2209-1389-43f7-86d3-70564e96202c"), "En préparation" },
                    { new Guid("90e2b117-8808-4b65-ac21-56783f094461"), "En cours d'approvisionnement" },
                    { new Guid("fa3e23ac-e929-4a66-b33b-334135134fa3"), "j'ai volé votre bouteille, merci, bisous, de Greg." },
                    { new Guid("00043d72-92f4-4c05-86b6-64b5a52b1ffb"), "Livrée" },
                    { new Guid("81cf26b2-e141-4839-9adb-e753b5c112f7"), "Archivée" },
                    { new Guid("9fa281a7-2fb8-47e1-b89b-fc0bde1a164d"), "Terminée" },
                    { new Guid("0a145546-df81-461a-b58b-0d0b4724183e"), "Vérification en cours" },
                    { new Guid("731a831c-183d-49e8-a416-d5df47f5ad53"), "En cours de traitement" },
                    { new Guid("615ee3dc-b9fc-4b82-aafe-ed3d3aaaec4c"), "En cours d'acheminement" }
                });

            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "SupplierId", "Adress", "City", "Cp", "Name", "PhoneNumber", "Siret" },
                values: new object[] { new Guid("9b0b6d9e-8941-4b27-8420-c428ff21c493"), "14 Rue Louis Ruquier", "Sotteville-lès-Rouen", "76300", "La Centrale des Vins", "02 35 73 03 93", "38862771300067" });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "AnneeId", "AnneeId1", "CapacityId", "CapacityId1", "CepageId", "CepageId1", "Description", "FamilyId", "FamilyId1", "Name", "Picture", "Ref", "SupplierId", "SupplierId1", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("cb270d40-0a21-4a94-ada9-ee1aba9df29c"), new Guid("ce55680e-2525-4a7e-8982-2be152174cb3"), null, new Guid("4990bf1e-107f-46ab-abfb-760afaa03288"), null, new Guid("a114a73c-8421-473a-8a0f-e4aad580e579"), null, "Description à venir", new Guid("fd6dbe0a-7402-476d-af03-948b85ab51bd"), null, "Bouteille de vin", null, "152DER147DFM9", new Guid("9b0b6d9e-8941-4b27-8420-c428ff21c493"), null, 5.5999999999999996 },
                    { new Guid("5e4004a9-63a7-4a3b-b514-c0cd65608bfe"), new Guid("3b648b81-59f7-45a0-b381-b65015b15295"), null, new Guid("5cb373ab-490e-478f-a7a3-a82b24728515"), null, new Guid("af79be29-5e24-4def-823c-365386d0867f"), null, "Description à venir", new Guid("eb031d7a-3d9e-45ca-a45f-ce1c01279214"), null, "Bouteille de bordeau", null, "452SER197DRP9", new Guid("9b0b6d9e-8941-4b27-8420-c428ff21c493"), null, 3.5 }
                });

            migrationBuilder.InsertData(
                table: "ClientOrder",
                columns: new[] { "ClientOrderId", "CustomerId", "Date", "HTPrice", "Reference", "StatusId", "TTCPrice" },
                values: new object[,]
                {
                    { new Guid("15ba98fe-e5ed-4658-84c9-ad7a0be8814f"), new Guid("9c33e8ac-14c1-4b1b-927f-c7bfd46ce9b7"), new DateTime(2021, 12, 17, 13, 13, 40, 303, DateTimeKind.Utc).AddTicks(8738), 0.0, "TEST123456", new Guid("0a145546-df81-461a-b58b-0d0b4724183e"), 0.0 },
                    { new Guid("e296e86d-0e05-44cd-bedf-e20a771371b3"), new Guid("e1713f5b-37d1-4084-b3dd-63fc685c02c9"), new DateTime(2021, 12, 17, 13, 13, 40, 303, DateTimeKind.Utc).AddTicks(9085), 0.0, "TEST234567", new Guid("0a145546-df81-461a-b58b-0d0b4724183e"), 0.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Article_AnneeId",
                table: "Article",
                column: "AnneeId");

            migrationBuilder.CreateIndex(
                name: "IX_Article_AnneeId1",
                table: "Article",
                column: "AnneeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Article_CapacityId",
                table: "Article",
                column: "CapacityId");

            migrationBuilder.CreateIndex(
                name: "IX_Article_CapacityId1",
                table: "Article",
                column: "CapacityId1");

            migrationBuilder.CreateIndex(
                name: "IX_Article_CepageId",
                table: "Article",
                column: "CepageId");

            migrationBuilder.CreateIndex(
                name: "IX_Article_CepageId1",
                table: "Article",
                column: "CepageId1");

            migrationBuilder.CreateIndex(
                name: "IX_Article_FamilyId",
                table: "Article",
                column: "FamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_Article_FamilyId1",
                table: "Article",
                column: "FamilyId1");

            migrationBuilder.CreateIndex(
                name: "IX_Article_SupplierId",
                table: "Article",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Article_SupplierId1",
                table: "Article",
                column: "SupplierId1");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleRow_ArticleId",
                table: "ArticleRow",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleRow_ClientOrderId",
                table: "ArticleRow",
                column: "ClientOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientOrder_CustomerId",
                table: "ClientOrder",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientOrder_StatusId",
                table: "ClientOrder",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_ArticleId",
                table: "PurchaseOrder",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_SupplierId",
                table: "PurchaseOrder",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_ArticleId",
                table: "Stock",
                column: "ArticleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleRow");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "PurchaseOrder");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropTable(
                name: "ClientOrder");

            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Annee");

            migrationBuilder.DropTable(
                name: "Capacity");

            migrationBuilder.DropTable(
                name: "Cepage");

            migrationBuilder.DropTable(
                name: "Family");

            migrationBuilder.DropTable(
                name: "Supplier");
        }
    }
}
