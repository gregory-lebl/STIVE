using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace STIVE_API.Migrations
{
    public partial class createDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_Annee_AnneeId1",
                table: "Article");

            migrationBuilder.DropForeignKey(
                name: "FK_Article_Capacity_CapacityId1",
                table: "Article");

            migrationBuilder.DropForeignKey(
                name: "FK_Article_Cepage_CepageId1",
                table: "Article");

            migrationBuilder.DropForeignKey(
                name: "FK_Article_Family_FamilyId1",
                table: "Article");

            migrationBuilder.DropForeignKey(
                name: "FK_Article_Supplier_SupplierId1",
                table: "Article");

            migrationBuilder.DropIndex(
                name: "IX_Article_AnneeId1",
                table: "Article");

            migrationBuilder.DropIndex(
                name: "IX_Article_CapacityId1",
                table: "Article");

            migrationBuilder.DropIndex(
                name: "IX_Article_CepageId1",
                table: "Article");

            migrationBuilder.DropIndex(
                name: "IX_Article_FamilyId1",
                table: "Article");

            migrationBuilder.DropIndex(
                name: "IX_Article_SupplierId1",
                table: "Article");

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("0df9015f-adf9-41ea-ac45-7b5d2018c897"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("63e4eb17-4e35-4f0d-a38f-df81bc950473"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("764cd196-8a02-4853-b7d5-f218fde81145"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("926c80bb-9cb0-488e-83df-3fccbb7e713b"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("96227d7a-0afb-481a-ba5a-46e0de6989b6"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("a4f0ac8f-1bf2-4d38-8fea-115d7a993315"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("b6b09797-f033-48e1-80e6-ee02c94ac731"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("bd9fcfe7-ef9a-47b6-9697-e8685178dcb1"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("c34dd3fa-4862-4123-b07b-baaf8fac89a5"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("cd9a6276-a0ba-497f-955b-41b1827daec9"));

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("5e4004a9-63a7-4a3b-b514-c0cd65608bfe"));

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("cb270d40-0a21-4a94-ada9-ee1aba9df29c"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("36c57b07-edab-4ed5-974b-73570fd6c9db"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("416fa7b9-ec8f-43cd-ae7d-1300bcd3b0b1"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("a6658b70-b4a9-4c42-bee2-f97aa9d6c28c"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("c36bf241-624c-43a6-a5bf-7fb3ed7f38d1"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("cab72940-c2df-456d-bcea-6a3eaa3b5187"));

            migrationBuilder.DeleteData(
                table: "ClientOrder",
                keyColumn: "ClientOrderId",
                keyValue: new Guid("15ba98fe-e5ed-4658-84c9-ad7a0be8814f"));

            migrationBuilder.DeleteData(
                table: "ClientOrder",
                keyColumn: "ClientOrderId",
                keyValue: new Guid("e296e86d-0e05-44cd-bedf-e20a771371b3"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("2c550678-eeb2-48f4-b007-ece1a4eda682"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("4cc04b75-03ed-4e2a-a0c9-2bb39dc15e91"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("9eb414a3-d752-4e17-a3aa-1f3b71825213"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("a92685dc-bd7c-4d54-90f2-44eab2772738"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("07fbf3f3-1b7b-4817-bf90-0f5727ad29a5"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("177ea6b0-0549-4505-96ae-8842d42a0c9b"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("87e572ff-3020-464a-b17b-e12921289938"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("b012c94b-4173-4821-8708-f996dbd17ebb"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("00043d72-92f4-4c05-86b6-64b5a52b1ffb"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("5b8a2209-1389-43f7-86d3-70564e96202c"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("615ee3dc-b9fc-4b82-aafe-ed3d3aaaec4c"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("731a831c-183d-49e8-a416-d5df47f5ad53"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("81cf26b2-e141-4839-9adb-e753b5c112f7"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("90e2b117-8808-4b65-ac21-56783f094461"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("9fa281a7-2fb8-47e1-b89b-fc0bde1a164d"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("fa3e23ac-e929-4a66-b33b-334135134fa3"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("3b648b81-59f7-45a0-b381-b65015b15295"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("ce55680e-2525-4a7e-8982-2be152174cb3"));

            migrationBuilder.DeleteData(
                table: "Capacity",
                keyColumn: "CapacityId",
                keyValue: new Guid("4990bf1e-107f-46ab-abfb-760afaa03288"));

            migrationBuilder.DeleteData(
                table: "Capacity",
                keyColumn: "CapacityId",
                keyValue: new Guid("5cb373ab-490e-478f-a7a3-a82b24728515"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("a114a73c-8421-473a-8a0f-e4aad580e579"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("af79be29-5e24-4def-823c-365386d0867f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("9c33e8ac-14c1-4b1b-927f-c7bfd46ce9b7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("e1713f5b-37d1-4084-b3dd-63fc685c02c9"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("eb031d7a-3d9e-45ca-a45f-ce1c01279214"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("fd6dbe0a-7402-476d-af03-948b85ab51bd"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("0a145546-df81-461a-b58b-0d0b4724183e"));

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "SupplierId",
                keyValue: new Guid("9b0b6d9e-8941-4b27-8420-c428ff21c493"));

            migrationBuilder.DropColumn(
                name: "AnneeId1",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "CapacityId1",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "CepageId1",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "FamilyId1",
                table: "Article");

            migrationBuilder.DropColumn(
                name: "SupplierId1",
                table: "Article");

            migrationBuilder.InsertData(
                table: "Annee",
                columns: new[] { "AnneeId", "Number" },
                values: new object[,]
                {
                    { new Guid("271bdaed-2e13-4227-b59e-edc2e24121be"), 2010 },
                    { new Guid("5bff7bac-b669-44d2-a02b-cdacc247cf72"), 2011 },
                    { new Guid("2a69cdff-6a4a-469d-a976-dec57a6da12f"), 2012 },
                    { new Guid("7159868b-2231-435a-901f-9f0c4bbbf795"), 2013 },
                    { new Guid("a101f38b-763e-49a5-ab02-cb1ff8e20f31"), 2014 },
                    { new Guid("49654645-c7dd-4dbf-90fb-ed2252ca4a3b"), 2015 },
                    { new Guid("e5da836f-33d7-4d0d-814b-12a6acb66f91"), 2016 },
                    { new Guid("9b35357a-d743-4ed5-baf9-227718d7fd2c"), 2017 },
                    { new Guid("17c12c12-d6a2-4021-bdae-abeed821fde1"), 2018 },
                    { new Guid("26d8c7db-4db3-4e22-8826-d8a0e639b8f0"), 2019 },
                    { new Guid("5c281f79-f82e-4221-baa0-f862bd2feafe"), 2020 },
                    { new Guid("a3b0988a-eb4d-4316-b9b9-0fb786dbe060"), 2021 }
                });

            migrationBuilder.InsertData(
                table: "Capacity",
                columns: new[] { "CapacityId", "BottleCapacity" },
                values: new object[,]
                {
                    { new Guid("0c907ea5-d1ec-4f3d-9bcc-75f6009191fe"), 37.5 },
                    { new Guid("7b5b650c-809b-460e-a64f-b9e8f3386fc3"), 75.0 }
                });

            migrationBuilder.InsertData(
                table: "Cepage",
                columns: new[] { "CepageId", "Name", "Origin" },
                values: new object[,]
                {
                    { new Guid("992b704d-ba28-4451-a1be-794b8fc3fd1b"), "Chardonnay", "France" },
                    { new Guid("e61df157-b336-4584-83fe-d9c4a6e966cb"), "Sauvignon", "France" },
                    { new Guid("24f9f0ff-b196-47bc-beef-c63e8002d883"), "Pinot Noir", "Allemagne" },
                    { new Guid("46f4004b-81e1-4272-a207-938fe9a180f0"), "Riesling", "France" },
                    { new Guid("c532455e-aa24-46a8-b157-d5b444697128"), "Gewurztraminer", "France" },
                    { new Guid("f59787fa-1a92-4664-a890-2e5b56a70883"), "Merlot noir", "France" },
                    { new Guid("1914778c-d734-41b2-a900-681cea892b7e"), "Mauzac rosé", "France" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Adress", "City", "Cp", "CustomerReference", "Email", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("72a733d9-f16f-4374-888c-75a0134aca2a"), "123 rue des chats", "CroquetteLand", "000009", "DKUE5ZMV2EHW", "gregory.lbl@gmail.com", "Gregory", "LEBLOND", "123", "0631258641" },
                    { new Guid("27b5d3bf-5c64-4253-8242-f4f1d7c236c9"), "1 chemin des alisiers 67700 Saverne", "Saverne", "67700", "8KRIN4LK11K2", "luciole.trp@gmail.com", "Lucile", "TRIPIER", "123", "0699318613" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Adress", "City", "Cp", "Email", "EmployeNumber", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("ddb535af-defb-4057-9cb4-2aa075035451"), "57 Boulevard Gambetta", "Evreux", "27000", "francois.dupont@yahoo.com", "G0CEOTOWFB", "François", "DUPONT", "123", "0635241896" },
                    { new Guid("82d73d70-7ca8-4003-81cd-86cbf1ae953e"), "3 Grande rue", "Rouen", "76000", "mariam.el@gmail.com", "ADJIVLQ6QL", "Mariam", "EL-ALLALI", "123", "0698574123" },
                    { new Guid("653af4c6-4bea-4e55-904d-1d90a008722c"), "3 Rue du Bout au Roussel", "Champenard", "27600", "jeremy.petit@outlook.com", "93Z9R94F6M", "Jeremy", "PETIT", "123", "0652341254" },
                    { new Guid("45d6be72-c326-4132-8c85-4c0121d64351"), "21 Rue Victor Hugo", "Evreux", "27000", "francine.dupont@gmail.com", "KKYFRFLAP2", "Francine", "DUPONT", "123", "0632547896" }
                });

            migrationBuilder.InsertData(
                table: "Family",
                columns: new[] { "FamilyId", "Name" },
                values: new object[,]
                {
                    { new Guid("2cb1ef22-1ef4-4457-a015-bce70279956a"), "Mousseux" },
                    { new Guid("b1b46d3c-a127-4553-a53e-f0085a57c92e"), "Vin blanc" },
                    { new Guid("015de04e-caaf-46c4-a2a1-16031f59e20f"), "Vin rouge" },
                    { new Guid("dd08f3d3-1869-4276-abff-6ba4f103b2db"), "Muscat" },
                    { new Guid("d88a7a2b-0f5f-4722-98fa-340ef8d961ee"), "Vin cuit" },
                    { new Guid("58093a9a-47ae-4ce6-9c6c-1cf4455377df"), "Rosé" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "StatusId", "Name" },
                values: new object[,]
                {
                    { new Guid("9adb66a1-3773-44a3-8130-03461d69e03f"), "En préparation" },
                    { new Guid("38cb352c-fba1-4701-aab8-a0094a82bec7"), "En cours d'approvisionnement" },
                    { new Guid("ebeba30a-202e-4491-95e5-6a8776289bfe"), "j'ai volé votre bouteille, merci, bisous, de Greg." },
                    { new Guid("5131969c-1526-4fd6-8f28-8beb015a0d1c"), "Livrée" },
                    { new Guid("2b8f3a48-5f2f-4ed7-808a-6307aa2f9d64"), "Archivée" },
                    { new Guid("563d25ef-972d-40d9-9caa-6c006c98193e"), "Terminée" },
                    { new Guid("0f2b36da-c749-4510-9629-935c124eda57"), "Vérification en cours" },
                    { new Guid("d07033b0-174f-4363-aa06-0afb591d00e4"), "En cours de traitement" },
                    { new Guid("09bee351-723e-4a53-951a-223518824869"), "En cours d'acheminement" }
                });

            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "SupplierId", "Adress", "City", "Cp", "Name", "PhoneNumber", "Siret" },
                values: new object[] { new Guid("bc222923-04ee-44da-8412-5e9a666fb969"), "14 Rue Louis Ruquier", "Sotteville-lès-Rouen", "76300", "La Centrale des Vins", "02 35 73 03 93", "38862771300067" });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "AnneeId", "CapacityId", "CepageId", "Description", "FamilyId", "Name", "Picture", "Ref", "SupplierId", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("7a65a5cd-adab-4d7a-91a5-4eb4b4684ff1"), new Guid("271bdaed-2e13-4227-b59e-edc2e24121be"), new Guid("7b5b650c-809b-460e-a64f-b9e8f3386fc3"), new Guid("992b704d-ba28-4451-a1be-794b8fc3fd1b"), "Description à venir", new Guid("58093a9a-47ae-4ce6-9c6c-1cf4455377df"), "Bouteille de vin", null, "152DER147DFM9", new Guid("bc222923-04ee-44da-8412-5e9a666fb969"), 5.5999999999999996 },
                    { new Guid("c0a5d5e0-185b-42e6-9551-d66a15fcf42b"), new Guid("a3b0988a-eb4d-4316-b9b9-0fb786dbe060"), new Guid("0c907ea5-d1ec-4f3d-9bcc-75f6009191fe"), new Guid("1914778c-d734-41b2-a900-681cea892b7e"), "Description à venir", new Guid("2cb1ef22-1ef4-4457-a015-bce70279956a"), "Bouteille de bordeau", null, "452SER197DRP9", new Guid("bc222923-04ee-44da-8412-5e9a666fb969"), 3.5 }
                });

            migrationBuilder.InsertData(
                table: "ClientOrder",
                columns: new[] { "ClientOrderId", "CustomerId", "Date", "HTPrice", "Reference", "StatusId", "TTCPrice" },
                values: new object[,]
                {
                    { new Guid("bf9dc1bb-5234-4d46-b819-f143c7dcafc5"), new Guid("27b5d3bf-5c64-4253-8242-f4f1d7c236c9"), new DateTime(2021, 12, 17, 13, 52, 1, 63, DateTimeKind.Utc).AddTicks(6300), 0.0, "TEST123456", new Guid("0f2b36da-c749-4510-9629-935c124eda57"), 0.0 },
                    { new Guid("28e468db-562a-4ee5-8e5c-ff9c373e67f6"), new Guid("72a733d9-f16f-4374-888c-75a0134aca2a"), new DateTime(2021, 12, 17, 13, 52, 1, 63, DateTimeKind.Utc).AddTicks(7025), 0.0, "TEST234567", new Guid("0f2b36da-c749-4510-9629-935c124eda57"), 0.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("17c12c12-d6a2-4021-bdae-abeed821fde1"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("26d8c7db-4db3-4e22-8826-d8a0e639b8f0"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("2a69cdff-6a4a-469d-a976-dec57a6da12f"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("49654645-c7dd-4dbf-90fb-ed2252ca4a3b"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("5bff7bac-b669-44d2-a02b-cdacc247cf72"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("5c281f79-f82e-4221-baa0-f862bd2feafe"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("7159868b-2231-435a-901f-9f0c4bbbf795"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("9b35357a-d743-4ed5-baf9-227718d7fd2c"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("a101f38b-763e-49a5-ab02-cb1ff8e20f31"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("e5da836f-33d7-4d0d-814b-12a6acb66f91"));

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("7a65a5cd-adab-4d7a-91a5-4eb4b4684ff1"));

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("c0a5d5e0-185b-42e6-9551-d66a15fcf42b"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("24f9f0ff-b196-47bc-beef-c63e8002d883"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("46f4004b-81e1-4272-a207-938fe9a180f0"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("c532455e-aa24-46a8-b157-d5b444697128"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("e61df157-b336-4584-83fe-d9c4a6e966cb"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("f59787fa-1a92-4664-a890-2e5b56a70883"));

            migrationBuilder.DeleteData(
                table: "ClientOrder",
                keyColumn: "ClientOrderId",
                keyValue: new Guid("28e468db-562a-4ee5-8e5c-ff9c373e67f6"));

            migrationBuilder.DeleteData(
                table: "ClientOrder",
                keyColumn: "ClientOrderId",
                keyValue: new Guid("bf9dc1bb-5234-4d46-b819-f143c7dcafc5"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("45d6be72-c326-4132-8c85-4c0121d64351"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("653af4c6-4bea-4e55-904d-1d90a008722c"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("82d73d70-7ca8-4003-81cd-86cbf1ae953e"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("ddb535af-defb-4057-9cb4-2aa075035451"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("015de04e-caaf-46c4-a2a1-16031f59e20f"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("b1b46d3c-a127-4553-a53e-f0085a57c92e"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("d88a7a2b-0f5f-4722-98fa-340ef8d961ee"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("dd08f3d3-1869-4276-abff-6ba4f103b2db"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("09bee351-723e-4a53-951a-223518824869"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("2b8f3a48-5f2f-4ed7-808a-6307aa2f9d64"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("38cb352c-fba1-4701-aab8-a0094a82bec7"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("5131969c-1526-4fd6-8f28-8beb015a0d1c"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("563d25ef-972d-40d9-9caa-6c006c98193e"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("9adb66a1-3773-44a3-8130-03461d69e03f"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("d07033b0-174f-4363-aa06-0afb591d00e4"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("ebeba30a-202e-4491-95e5-6a8776289bfe"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("271bdaed-2e13-4227-b59e-edc2e24121be"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("a3b0988a-eb4d-4316-b9b9-0fb786dbe060"));

            migrationBuilder.DeleteData(
                table: "Capacity",
                keyColumn: "CapacityId",
                keyValue: new Guid("0c907ea5-d1ec-4f3d-9bcc-75f6009191fe"));

            migrationBuilder.DeleteData(
                table: "Capacity",
                keyColumn: "CapacityId",
                keyValue: new Guid("7b5b650c-809b-460e-a64f-b9e8f3386fc3"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("1914778c-d734-41b2-a900-681cea892b7e"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("992b704d-ba28-4451-a1be-794b8fc3fd1b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("27b5d3bf-5c64-4253-8242-f4f1d7c236c9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("72a733d9-f16f-4374-888c-75a0134aca2a"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("2cb1ef22-1ef4-4457-a015-bce70279956a"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("58093a9a-47ae-4ce6-9c6c-1cf4455377df"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("0f2b36da-c749-4510-9629-935c124eda57"));

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "SupplierId",
                keyValue: new Guid("bc222923-04ee-44da-8412-5e9a666fb969"));

            migrationBuilder.AddColumn<Guid>(
                name: "AnneeId1",
                table: "Article",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CapacityId1",
                table: "Article",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CepageId1",
                table: "Article",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FamilyId1",
                table: "Article",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SupplierId1",
                table: "Article",
                type: "uniqueidentifier",
                nullable: true);

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
                name: "IX_Article_AnneeId1",
                table: "Article",
                column: "AnneeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Article_CapacityId1",
                table: "Article",
                column: "CapacityId1");

            migrationBuilder.CreateIndex(
                name: "IX_Article_CepageId1",
                table: "Article",
                column: "CepageId1");

            migrationBuilder.CreateIndex(
                name: "IX_Article_FamilyId1",
                table: "Article",
                column: "FamilyId1");

            migrationBuilder.CreateIndex(
                name: "IX_Article_SupplierId1",
                table: "Article",
                column: "SupplierId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Annee_AnneeId1",
                table: "Article",
                column: "AnneeId1",
                principalTable: "Annee",
                principalColumn: "AnneeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Capacity_CapacityId1",
                table: "Article",
                column: "CapacityId1",
                principalTable: "Capacity",
                principalColumn: "CapacityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Cepage_CepageId1",
                table: "Article",
                column: "CepageId1",
                principalTable: "Cepage",
                principalColumn: "CepageId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Family_FamilyId1",
                table: "Article",
                column: "FamilyId1",
                principalTable: "Family",
                principalColumn: "FamilyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Supplier_SupplierId1",
                table: "Article",
                column: "SupplierId1",
                principalTable: "Supplier",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
