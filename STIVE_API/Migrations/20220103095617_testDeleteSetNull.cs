using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace STIVE_API.Migrations
{
    public partial class testDeleteSetNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_Annee_AnneeId",
                table: "Article");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "CepageId",
                table: "Article",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "CapacityId",
                table: "Article",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "AnneeId",
                table: "Article",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Annee",
                columns: new[] { "AnneeId", "Number" },
                values: new object[,]
                {
                    { new Guid("6be03856-f9c4-4534-86d3-22475e554c85"), 2010 },
                    { new Guid("1a312469-ca73-4c72-970a-ed00081634b4"), 2011 },
                    { new Guid("d6a0eca7-603e-495a-ac10-d1c9c2e2e130"), 2012 },
                    { new Guid("a47db76a-37f3-4f9b-8191-a958161c2975"), 2013 },
                    { new Guid("3f06f824-f3cf-4298-8da8-bea58bc6322a"), 2014 },
                    { new Guid("3bd076f5-ad0a-43ac-95cf-ffd6c2c9bb2e"), 2015 },
                    { new Guid("ba116877-ec84-4cb6-9d03-e51da6328522"), 2016 },
                    { new Guid("2d2333ed-3175-4de5-8f3a-3ed346e7c2e4"), 2017 },
                    { new Guid("c0f29beb-14d2-4271-97f9-637aa5032587"), 2018 },
                    { new Guid("e4ba0631-1ebc-4146-abab-966bebb7dbc6"), 2019 },
                    { new Guid("76a90406-f789-4c48-8085-e0f2b1c848aa"), 2020 },
                    { new Guid("190a8821-5afa-4d1b-800e-87d50ad049a0"), 2021 }
                });

            migrationBuilder.InsertData(
                table: "Capacity",
                columns: new[] { "CapacityId", "BottleCapacity" },
                values: new object[,]
                {
                    { new Guid("fa5ec0b1-ff64-4055-93d9-09934fe68050"), 37.5 },
                    { new Guid("6a1140bc-232d-4b79-9f35-9fc86756e5fd"), 75.0 }
                });

            migrationBuilder.InsertData(
                table: "Cepage",
                columns: new[] { "CepageId", "Name", "Origin" },
                values: new object[,]
                {
                    { new Guid("3a8c1ec5-2a13-4ad1-9a7f-949c0b34d04f"), "Chardonnay", "France" },
                    { new Guid("ff304109-18c8-4595-856f-5d2318daa77b"), "Sauvignon", "France" },
                    { new Guid("79695e24-83fa-43f5-8741-6b76bd244349"), "Pinot Noir", "Allemagne" },
                    { new Guid("2d112c5e-cf26-4f3e-bf3d-07dc4b767062"), "Riesling", "France" },
                    { new Guid("e71ec35a-710d-4522-90a2-23000d66f912"), "Gewurztraminer", "France" },
                    { new Guid("6c9d2be6-2384-4f15-b1f5-49f14351b58b"), "Merlot noir", "France" },
                    { new Guid("d08b1746-ec42-4299-a131-d4cb77e139bc"), "Mauzac rosé", "France" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Adress", "City", "Cp", "CustomerReference", "Email", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("bf41aa26-965b-4219-9505-31c1f8e5a0ea"), "123 rue des chats", "CroquetteLand", "000009", "7BTWBBNCXCLX", "gregory.lbl@gmail.com", "Gregory", "LEBLOND", "123", "0631258641" },
                    { new Guid("5367f7e7-78f3-47be-83cd-e660a2bed3e3"), "1 chemin des alisiers 67700 Saverne", "Saverne", "67700", "FFRIE3A72FLJ", "luciole.trp@gmail.com", "Lucile", "TRIPIER", "123", "0699318613" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Adress", "City", "Cp", "Email", "EmployeNumber", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("26f67a74-e43b-44d1-b982-6f7013ba8144"), "57 Boulevard Gambetta", "Evreux", "27000", "francois.dupont@yahoo.com", "GIZVZ0NC0R", "François", "DUPONT", "123", "0635241896" },
                    { new Guid("3c12d81d-dc5d-4c07-9613-afb5231ad6d1"), "3 Grande rue", "Rouen", "76000", "mariam.el@gmail.com", "F3OFC2OPBR", "Mariam", "EL-ALLALI", "123", "0698574123" },
                    { new Guid("aa63a796-0a70-406a-8882-f1748cffd1ef"), "3 Rue du Bout au Roussel", "Champenard", "27600", "jeremy.petit@outlook.com", "6UT1JJQQDL", "Jeremy", "PETIT", "123", "0652341254" },
                    { new Guid("319ec578-2856-46e7-ba0e-c67d268cc2ea"), "21 Rue Victor Hugo", "Evreux", "27000", "francine.dupont@gmail.com", "BRPQA4IBNN", "Francine", "DUPONT", "123", "0632547896" }
                });

            migrationBuilder.InsertData(
                table: "Family",
                columns: new[] { "FamilyId", "Name" },
                values: new object[,]
                {
                    { new Guid("dfdd68d5-613e-487e-a870-e49a440b869e"), "Mousseux" },
                    { new Guid("1aa5b5ce-56c7-45e1-a56d-265a8e7b6c9c"), "Vin blanc" },
                    { new Guid("b1f5a4d6-9764-4c5f-b25b-6cf4c7dc7d9b"), "Vin rouge" },
                    { new Guid("1b53644a-ead1-456d-9cf7-de41bff335e6"), "Muscat" },
                    { new Guid("9433da18-8302-470f-a2d9-4cf66b5c55c9"), "Vin cuit" },
                    { new Guid("2935a39f-ad93-4da1-b51d-c591343e0aa6"), "Rosé" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "StatusId", "Name" },
                values: new object[,]
                {
                    { new Guid("13803abd-52ad-4f39-9b0f-9f7ad844261e"), "En préparation" },
                    { new Guid("36995554-68ac-4055-aa74-9697e3937409"), "En cours d'approvisionnement" },
                    { new Guid("13dc14a7-51be-4d27-b52c-6068915d6042"), "j'ai volé votre bouteille, merci, bisous, de Greg." },
                    { new Guid("d463f193-fd35-4be2-8d0c-cac920b0e6ec"), "Livrée" },
                    { new Guid("3478bc93-3590-4908-b5be-4eb47aff5c7f"), "Archivée" },
                    { new Guid("98400fab-9298-4152-b32d-241e4adb8f7e"), "Terminée" },
                    { new Guid("cd08ae98-4963-4e7c-a689-b1d67f39323b"), "Vérification en cours" },
                    { new Guid("fa6760b9-97be-4e4f-bfa1-16ee3e6a9036"), "En cours de traitement" },
                    { new Guid("0ae7e177-4df0-4404-8e98-2ba7e3f87338"), "En cours d'acheminement" }
                });

            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "SupplierId", "Adress", "City", "Cp", "Name", "PhoneNumber", "Siret" },
                values: new object[] { new Guid("2c3d4e8b-46b7-44ae-a2b5-e1c19bf33f02"), "14 Rue Louis Ruquier", "Sotteville-lès-Rouen", "76300", "La Centrale des Vins", "02 35 73 03 93", "38862771300067" });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "AnneeId", "CapacityId", "CepageId", "Description", "FamilyId", "Name", "Picture", "Ref", "SupplierId", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("9955b349-69e1-4bc1-8e12-f9c2c42715b1"), new Guid("6be03856-f9c4-4534-86d3-22475e554c85"), new Guid("6a1140bc-232d-4b79-9f35-9fc86756e5fd"), new Guid("3a8c1ec5-2a13-4ad1-9a7f-949c0b34d04f"), "Description à venir", new Guid("2935a39f-ad93-4da1-b51d-c591343e0aa6"), "Bouteille de vin", null, "152DER147DFM9", new Guid("2c3d4e8b-46b7-44ae-a2b5-e1c19bf33f02"), 5.5999999999999996 },
                    { new Guid("29ef26fa-f385-40b8-aa77-6858dda5eb8d"), new Guid("190a8821-5afa-4d1b-800e-87d50ad049a0"), new Guid("fa5ec0b1-ff64-4055-93d9-09934fe68050"), new Guid("d08b1746-ec42-4299-a131-d4cb77e139bc"), "Description à venir", new Guid("dfdd68d5-613e-487e-a870-e49a440b869e"), "Bouteille de bordeau", null, "452SER197DRP9", new Guid("2c3d4e8b-46b7-44ae-a2b5-e1c19bf33f02"), 3.5 }
                });

            migrationBuilder.InsertData(
                table: "ClientOrder",
                columns: new[] { "ClientOrderId", "CustomerId", "Date", "HTPrice", "Reference", "StatusId", "TTCPrice" },
                values: new object[,]
                {
                    { new Guid("c6bdb5d8-033e-402d-ba03-22c4c1ce269a"), new Guid("5367f7e7-78f3-47be-83cd-e660a2bed3e3"), new DateTime(2022, 1, 3, 9, 56, 16, 563, DateTimeKind.Utc).AddTicks(3611), 0.0, "TEST123456", new Guid("cd08ae98-4963-4e7c-a689-b1d67f39323b"), 0.0 },
                    { new Guid("7aa3d14d-89a0-414e-8fa9-9d7547be52b6"), new Guid("bf41aa26-965b-4219-9505-31c1f8e5a0ea"), new DateTime(2022, 1, 3, 9, 56, 16, 563, DateTimeKind.Utc).AddTicks(4087), 0.0, "TEST234567", new Guid("cd08ae98-4963-4e7c-a689-b1d67f39323b"), 0.0 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Annee_AnneeId",
                table: "Article",
                column: "AnneeId",
                principalTable: "Annee",
                principalColumn: "AnneeId",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_Annee_AnneeId",
                table: "Article");

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("1a312469-ca73-4c72-970a-ed00081634b4"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("2d2333ed-3175-4de5-8f3a-3ed346e7c2e4"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("3bd076f5-ad0a-43ac-95cf-ffd6c2c9bb2e"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("3f06f824-f3cf-4298-8da8-bea58bc6322a"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("76a90406-f789-4c48-8085-e0f2b1c848aa"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("a47db76a-37f3-4f9b-8191-a958161c2975"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("ba116877-ec84-4cb6-9d03-e51da6328522"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("c0f29beb-14d2-4271-97f9-637aa5032587"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("d6a0eca7-603e-495a-ac10-d1c9c2e2e130"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("e4ba0631-1ebc-4146-abab-966bebb7dbc6"));

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("29ef26fa-f385-40b8-aa77-6858dda5eb8d"));

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("9955b349-69e1-4bc1-8e12-f9c2c42715b1"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("2d112c5e-cf26-4f3e-bf3d-07dc4b767062"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("6c9d2be6-2384-4f15-b1f5-49f14351b58b"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("79695e24-83fa-43f5-8741-6b76bd244349"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("e71ec35a-710d-4522-90a2-23000d66f912"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("ff304109-18c8-4595-856f-5d2318daa77b"));

            migrationBuilder.DeleteData(
                table: "ClientOrder",
                keyColumn: "ClientOrderId",
                keyValue: new Guid("7aa3d14d-89a0-414e-8fa9-9d7547be52b6"));

            migrationBuilder.DeleteData(
                table: "ClientOrder",
                keyColumn: "ClientOrderId",
                keyValue: new Guid("c6bdb5d8-033e-402d-ba03-22c4c1ce269a"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("26f67a74-e43b-44d1-b982-6f7013ba8144"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("319ec578-2856-46e7-ba0e-c67d268cc2ea"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("3c12d81d-dc5d-4c07-9613-afb5231ad6d1"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("aa63a796-0a70-406a-8882-f1748cffd1ef"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("1aa5b5ce-56c7-45e1-a56d-265a8e7b6c9c"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("1b53644a-ead1-456d-9cf7-de41bff335e6"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("9433da18-8302-470f-a2d9-4cf66b5c55c9"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("b1f5a4d6-9764-4c5f-b25b-6cf4c7dc7d9b"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("0ae7e177-4df0-4404-8e98-2ba7e3f87338"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("13803abd-52ad-4f39-9b0f-9f7ad844261e"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("13dc14a7-51be-4d27-b52c-6068915d6042"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("3478bc93-3590-4908-b5be-4eb47aff5c7f"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("36995554-68ac-4055-aa74-9697e3937409"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("98400fab-9298-4152-b32d-241e4adb8f7e"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("d463f193-fd35-4be2-8d0c-cac920b0e6ec"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("fa6760b9-97be-4e4f-bfa1-16ee3e6a9036"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("190a8821-5afa-4d1b-800e-87d50ad049a0"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("6be03856-f9c4-4534-86d3-22475e554c85"));

            migrationBuilder.DeleteData(
                table: "Capacity",
                keyColumn: "CapacityId",
                keyValue: new Guid("6a1140bc-232d-4b79-9f35-9fc86756e5fd"));

            migrationBuilder.DeleteData(
                table: "Capacity",
                keyColumn: "CapacityId",
                keyValue: new Guid("fa5ec0b1-ff64-4055-93d9-09934fe68050"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("3a8c1ec5-2a13-4ad1-9a7f-949c0b34d04f"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("d08b1746-ec42-4299-a131-d4cb77e139bc"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("5367f7e7-78f3-47be-83cd-e660a2bed3e3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("bf41aa26-965b-4219-9505-31c1f8e5a0ea"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("2935a39f-ad93-4da1-b51d-c591343e0aa6"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("dfdd68d5-613e-487e-a870-e49a440b869e"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("cd08ae98-4963-4e7c-a689-b1d67f39323b"));

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "SupplierId",
                keyValue: new Guid("2c3d4e8b-46b7-44ae-a2b5-e1c19bf33f02"));

            migrationBuilder.AlterColumn<Guid>(
                name: "CepageId",
                table: "Article",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CapacityId",
                table: "Article",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AnneeId",
                table: "Article",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Annee_AnneeId",
                table: "Article",
                column: "AnneeId",
                principalTable: "Annee",
                principalColumn: "AnneeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
