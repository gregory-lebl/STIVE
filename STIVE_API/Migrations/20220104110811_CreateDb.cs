using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace STIVE_API.Migrations
{
    public partial class CreateDb : Migration
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
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Stock",
                columns: table => new
                {
                    StockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Limit = table.Column<int>(type: "int", nullable: false),
                    Provision = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.StockId);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    AnneeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CapacityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CepageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FamilyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StockId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Article_Capacity_CapacityId",
                        column: x => x.CapacityId,
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
                        name: "FK_Article_Family_FamilyId",
                        column: x => x.FamilyId,
                        principalTable: "Family",
                        principalColumn: "FamilyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Article_Stock_StockId",
                        column: x => x.StockId,
                        principalTable: "Stock",
                        principalColumn: "StockId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Article_Supplier_SupplierId",
                        column: x => x.SupplierId,
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

            migrationBuilder.InsertData(
                table: "Annee",
                columns: new[] { "AnneeId", "Number" },
                values: new object[,]
                {
                    { new Guid("c1a6c3bb-ac27-4813-884a-2fc42598e55f"), 2010 },
                    { new Guid("52378546-5246-45c4-8269-6d2fc300880f"), 2011 },
                    { new Guid("c1f6cf58-5933-4bcf-82aa-9bc396d093d2"), 2012 },
                    { new Guid("e9f181db-2ca6-4ec6-9b5f-75d445c508a6"), 2013 },
                    { new Guid("b9a7c085-42aa-41ee-b352-1b51b3cd73aa"), 2014 },
                    { new Guid("c82d2d0a-a93f-450a-9bf8-bc8481f14d4a"), 2015 },
                    { new Guid("084f36fe-f9cb-41f8-8331-dc91c5de3629"), 2016 },
                    { new Guid("ed2019f7-91dd-4c8c-a18e-8a80eeac278c"), 2017 },
                    { new Guid("9db19ed3-ef3e-41f9-aad4-8935e522f5cc"), 2018 },
                    { new Guid("a9761754-bb5b-41f6-91dc-ef9113955d11"), 2019 },
                    { new Guid("6ffa1956-80ea-455d-8ef7-9a148cd63a03"), 2020 },
                    { new Guid("b3e362eb-5f91-4cae-a2bd-66c88b210838"), 2021 }
                });

            migrationBuilder.InsertData(
                table: "Capacity",
                columns: new[] { "CapacityId", "BottleCapacity" },
                values: new object[,]
                {
                    { new Guid("ea5293b2-42ab-49e1-aaa7-c08b5c7e279b"), 37.5 },
                    { new Guid("930b60dc-1bd8-408c-a2f0-05db84cce46f"), 75.0 }
                });

            migrationBuilder.InsertData(
                table: "Cepage",
                columns: new[] { "CepageId", "Name", "Origin" },
                values: new object[,]
                {
                    { new Guid("0238c22a-ba09-42a9-be9f-9a16ffb401c4"), "Chardonnay", "France" },
                    { new Guid("dcd8ea04-642c-4106-9dda-a8ebb563f474"), "Sauvignon", "France" },
                    { new Guid("57be4b1e-93d4-4c0d-829c-f7c677d532ac"), "Pinot Noir", "Allemagne" },
                    { new Guid("dcb281d5-fea8-417e-ad0f-884b8037a50f"), "Riesling", "France" },
                    { new Guid("02c61c60-6881-49de-aa56-159f40f0903b"), "Gewurztraminer", "France" },
                    { new Guid("ca68f062-e8fc-4890-9d00-2f4d463d8309"), "Merlot noir", "France" },
                    { new Guid("309c0610-497a-475c-a077-dcfc5dccab24"), "Mauzac rosé", "France" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "Cp", "CustomerReference", "Email", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("dcb58c9f-2d91-45c5-8662-22c6bc0fc7a5"), "123 rue des chats", "CroquetteLand", "000009", "D4MU6W3VTB9N", "gregory.lbl@gmail.com", "Gregory", "LEBLOND", "123", "0631258641" },
                    { new Guid("8d0e7981-0abf-4a68-9960-a4ee1a9eab0d"), "1 chemin des alisiers 67700 Saverne", "Saverne", "67700", "8LSMA21JCF2V", "luciole.trp@gmail.com", "Lucile", "TRIPIER", "123", "0699318613" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Address", "City", "Cp", "Email", "EmployeNumber", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("d25e3f5b-e73b-416b-a69c-34ea9231c942"), "57 Boulevard Gambetta", "Evreux", "27000", "francois.dupont@yahoo.com", "LG5XTGCC3L", "François", "DUPONT", "123", "0635241896" },
                    { new Guid("7e1666a1-1d9d-44f1-b2da-c37e2de90868"), "3 Grande rue", "Rouen", "76000", "mariam.el@gmail.com", "B4GBFWYR3J", "Mariam", "EL-ALLALI", "123", "0698574123" },
                    { new Guid("a4a8d744-845d-402c-b9f0-fc5d5905abfe"), "3 Rue du Bout au Roussel", "Champenard", "27600", "jeremy.petit@outlook.com", "619W24GYTQ", "Jeremy", "PETIT", "123", "0652341254" },
                    { new Guid("3d4d2b16-b68d-4e74-ba96-3b84ec9e802e"), "21 Rue Victor Hugo", "Evreux", "27000", "francine.dupont@gmail.com", "6MIKFQND5V", "Francine", "DUPONT", "123", "0632547896" }
                });

            migrationBuilder.InsertData(
                table: "Family",
                columns: new[] { "FamilyId", "Name" },
                values: new object[,]
                {
                    { new Guid("8221f2b1-ea4b-49a1-a79b-dfa8cf56562f"), "Mousseux" },
                    { new Guid("6ea98eed-de1e-41d5-8365-648c55e94f18"), "Rosé" },
                    { new Guid("869572a3-97ed-4052-a5da-2d104cec0e00"), "Vin rouge" },
                    { new Guid("34c93c2f-5aa5-4513-8e27-3ad9e3ffa5f3"), "Muscat" },
                    { new Guid("561adae5-d99d-4fee-8091-9ce52f8adabd"), "Vin cuit" },
                    { new Guid("55c05e1e-b858-47d8-8fca-f0dee30365e6"), "Vin blanc" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "StatusId", "Name" },
                values: new object[,]
                {
                    { new Guid("38bea2dc-87d2-40d5-8f9e-a85f5ea9f7e7"), "Livrée" },
                    { new Guid("9ff36dbc-2528-44cd-a296-2a19cdc2431c"), "En cours d'approvisionnement" },
                    { new Guid("cc980872-fcd9-44da-9063-b794492dec76"), "Terminée" },
                    { new Guid("f7254d9d-3bf3-42ea-a2b4-b5daeb7071ca"), "En préparation" },
                    { new Guid("7dcf3b2e-532d-4c9e-9ca2-f999f28b1a60"), "En cours d'acheminement" },
                    { new Guid("96c620bb-11e9-46fc-a012-d778c8b887fc"), "j'ai volé votre bouteille, merci, bisous, de Greg." },
                    { new Guid("aa76db49-4fbd-4c59-96b1-56051b3b6311"), "Vérification en cours" },
                    { new Guid("69068c14-1938-448d-a644-f92e96bd3494"), "Archivée" },
                    { new Guid("9bf51dcc-c6e7-48ca-ba79-b3ea1265b3ca"), "En cours de traitement" }
                });

            migrationBuilder.InsertData(
                table: "Stock",
                columns: new[] { "StockId", "Limit", "Provision", "Quantity" },
                values: new object[,]
                {
                    { new Guid("f8c0c856-081b-4920-ade9-348e4a81ce5c"), 20, 100, 50 },
                    { new Guid("45821a59-b724-40f4-a25d-a3238b2ddc66"), 1, 5, 2 },
                    { new Guid("79c64d52-5413-427f-82d3-0d3a274bf394"), 5, 15, 10 }
                });

            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "SupplierId", "Address", "City", "Cp", "Name", "PhoneNumber", "Siret" },
                values: new object[] { new Guid("a78e8a26-7ffb-4f8b-adbb-cf9e8e1596fd"), "14 Rue Louis Ruquier", "Sotteville-lès-Rouen", "76300", "La Centrale des Vins", "02 35 73 03 93", "38862771300067" });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "AnneeId", "CapacityId", "CepageId", "Description", "FamilyId", "Name", "Picture", "Ref", "StockId", "SupplierId", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("b23fb87c-58d7-4cdd-a005-6ca61ab3bf9e"), new Guid("c1a6c3bb-ac27-4813-884a-2fc42598e55f"), new Guid("930b60dc-1bd8-408c-a2f0-05db84cce46f"), new Guid("0238c22a-ba09-42a9-be9f-9a16ffb401c4"), "Description à venir", new Guid("6ea98eed-de1e-41d5-8365-648c55e94f18"), "Bouteille de vin", null, "152DER147DFM9", new Guid("79c64d52-5413-427f-82d3-0d3a274bf394"), new Guid("a78e8a26-7ffb-4f8b-adbb-cf9e8e1596fd"), 5.5999999999999996 },
                    { new Guid("7019cfca-d792-4937-9b77-0ce6ca222560"), new Guid("b3e362eb-5f91-4cae-a2bd-66c88b210838"), new Guid("ea5293b2-42ab-49e1-aaa7-c08b5c7e279b"), new Guid("309c0610-497a-475c-a077-dcfc5dccab24"), "Description à venir", new Guid("8221f2b1-ea4b-49a1-a79b-dfa8cf56562f"), "Bouteille de bordeau", null, "452SER197DRP9", new Guid("f8c0c856-081b-4920-ade9-348e4a81ce5c"), new Guid("a78e8a26-7ffb-4f8b-adbb-cf9e8e1596fd"), 3.5 }
                });

            migrationBuilder.InsertData(
                table: "ClientOrder",
                columns: new[] { "ClientOrderId", "CustomerId", "Date", "HTPrice", "Reference", "StatusId", "TTCPrice" },
                values: new object[,]
                {
                    { new Guid("4bcb4d67-f8ba-43a4-ba0e-bb94bd673246"), new Guid("8d0e7981-0abf-4a68-9960-a4ee1a9eab0d"), new DateTime(2022, 1, 4, 11, 8, 10, 827, DateTimeKind.Utc).AddTicks(2125), 0.0, "TEST123456", new Guid("aa76db49-4fbd-4c59-96b1-56051b3b6311"), 0.0 },
                    { new Guid("52ef1b6d-ea90-4959-b76b-fa4bb1a017e3"), new Guid("dcb58c9f-2d91-45c5-8662-22c6bc0fc7a5"), new DateTime(2022, 1, 4, 11, 8, 10, 827, DateTimeKind.Utc).AddTicks(2436), 0.0, "TEST234567", new Guid("aa76db49-4fbd-4c59-96b1-56051b3b6311"), 0.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Article_AnneeId",
                table: "Article",
                column: "AnneeId");

            migrationBuilder.CreateIndex(
                name: "IX_Article_CapacityId",
                table: "Article",
                column: "CapacityId");

            migrationBuilder.CreateIndex(
                name: "IX_Article_CepageId",
                table: "Article",
                column: "CepageId");

            migrationBuilder.CreateIndex(
                name: "IX_Article_FamilyId",
                table: "Article",
                column: "FamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_Article_StockId",
                table: "Article",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_Article_SupplierId",
                table: "Article",
                column: "SupplierId");

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
                name: "Stock");

            migrationBuilder.DropTable(
                name: "Supplier");
        }
    }
}
