using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace STIVE_API.Migrations
{
    public partial class NullAllowedOnArticleFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "SupplierId",
                table: "Article",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "FamilyId",
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
                    { new Guid("0e31b9d5-0f6f-4e31-8f35-3137631cf874"), 2010 },
                    { new Guid("36a79427-e5ee-43d7-861c-47a1299b2b8a"), 2011 },
                    { new Guid("7f851983-c435-4381-bc36-5f7df23d22a2"), 2012 },
                    { new Guid("58d9e42a-58a5-4a5f-bc10-eaf1ab78dc59"), 2013 },
                    { new Guid("e5e0a374-0014-4afd-a345-3f8e05291750"), 2014 },
                    { new Guid("cfec00e9-c202-47a6-bac1-df7960d31668"), 2015 },
                    { new Guid("1ade3c52-af16-4eb9-bec8-f7d194700ad1"), 2016 },
                    { new Guid("53dbadff-3f8b-4473-9dac-e964ce1b1c40"), 2017 },
                    { new Guid("1ebf5007-c499-412e-85c3-9bd13cd5cad5"), 2018 },
                    { new Guid("82e39525-04ba-44e9-938e-1f420cdf9932"), 2019 },
                    { new Guid("2018865b-2431-433a-9f61-2d78a91c15d7"), 2020 },
                    { new Guid("531c468e-a902-4f91-9f8a-690ebe982bb7"), 2021 }
                });

            migrationBuilder.InsertData(
                table: "Capacity",
                columns: new[] { "CapacityId", "BottleCapacity" },
                values: new object[,]
                {
                    { new Guid("d335ab3f-060f-4546-b99b-4c160d3d1605"), 37.5 },
                    { new Guid("228982d7-54f4-49e8-b51e-f1a24708a516"), 75.0 }
                });

            migrationBuilder.InsertData(
                table: "Cepage",
                columns: new[] { "CepageId", "Name", "Origin" },
                values: new object[,]
                {
                    { new Guid("b6dae65e-5d42-4fc5-9002-4e9a1d02dd4e"), "Chardonnay", "France" },
                    { new Guid("b28535a7-e148-4936-9fc4-6983c1d68d1a"), "Sauvignon", "France" },
                    { new Guid("1cde1913-dc30-45db-b890-0439e79a5a7d"), "Pinot Noir", "Allemagne" },
                    { new Guid("8f5cbf93-a3dd-4962-95c3-fdd1aef92f08"), "Riesling", "France" },
                    { new Guid("f3fde950-1278-46d1-a528-c7ac40050f18"), "Gewurztraminer", "France" },
                    { new Guid("4e8c6f7a-8bc9-44e5-bbaf-31522b97bbcf"), "Merlot noir", "France" },
                    { new Guid("866b6e9c-7516-484e-a3bb-5efbe267bcb7"), "Mauzac rosé", "France" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Adress", "City", "Cp", "CustomerReference", "Email", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("beb8d433-e602-42e9-bf66-dc9c504dc089"), "123 rue des chats", "CroquetteLand", "000009", "J3M29Z8QEVPN", "gregory.lbl@gmail.com", "Gregory", "LEBLOND", "123", "0631258641" },
                    { new Guid("2c9018ec-7dbf-4fb4-9bfb-c08ea2612e89"), "1 chemin des alisiers 67700 Saverne", "Saverne", "67700", "7Q97H17CH27Y", "luciole.trp@gmail.com", "Lucile", "TRIPIER", "123", "0699318613" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Adress", "City", "Cp", "Email", "EmployeNumber", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("9c21b765-6eae-4e23-ae55-ed73a6121bbe"), "57 Boulevard Gambetta", "Evreux", "27000", "francois.dupont@yahoo.com", "5OOU5DNQ3H", "François", "DUPONT", "123", "0635241896" },
                    { new Guid("cd7887ae-3047-4ffd-bb4a-bc300fbec03c"), "3 Grande rue", "Rouen", "76000", "mariam.el@gmail.com", "XWG57ZBRYT", "Mariam", "EL-ALLALI", "123", "0698574123" },
                    { new Guid("38adb6c6-9a77-4caf-8cca-4be88cec0a75"), "3 Rue du Bout au Roussel", "Champenard", "27600", "jeremy.petit@outlook.com", "4IQEFEG52Z", "Jeremy", "PETIT", "123", "0652341254" },
                    { new Guid("ef8d008c-b7ca-473c-b63f-0f8b06436813"), "21 Rue Victor Hugo", "Evreux", "27000", "francine.dupont@gmail.com", "EPKWMZ9PBX", "Francine", "DUPONT", "123", "0632547896" }
                });

            migrationBuilder.InsertData(
                table: "Family",
                columns: new[] { "FamilyId", "Name" },
                values: new object[,]
                {
                    { new Guid("92ace882-49d0-4c3a-85a8-3d97e92741f0"), "Mousseux" },
                    { new Guid("eacbadce-24b3-4dfd-bfe4-6d1114a0fca7"), "Vin blanc" },
                    { new Guid("84f153bf-55b6-416e-999c-9f4b953946c5"), "Vin rouge" },
                    { new Guid("33795b31-db6e-4b6a-9551-14e246c4f50c"), "Muscat" },
                    { new Guid("719902d7-1266-457b-ba18-63a0d7bf0b77"), "Vin cuit" },
                    { new Guid("169ce541-e98b-4636-9bc4-872e9fef2287"), "Rosé" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "StatusId", "Name" },
                values: new object[,]
                {
                    { new Guid("53f54a4e-f93f-4595-88e1-95e400a441a7"), "En préparation" },
                    { new Guid("68a119b4-e2a9-4b22-99cc-249b7f1c2e44"), "En cours d'approvisionnement" },
                    { new Guid("c78979e9-926b-4002-aab5-049ff6f24cf6"), "j'ai volé votre bouteille, merci, bisous, de Greg." },
                    { new Guid("ea202294-faf7-49ae-9b00-35f33ed1b126"), "Livrée" },
                    { new Guid("4d50847d-ee93-4586-9210-160c0aa9991f"), "Archivée" },
                    { new Guid("9397ecd4-7ba4-4e87-82ea-4c8d24f81457"), "Terminée" },
                    { new Guid("1fac6542-3b52-4c80-abcf-7abcc25f7954"), "Vérification en cours" },
                    { new Guid("053080a9-23a2-4ab7-add3-218ba8162242"), "En cours de traitement" },
                    { new Guid("5c6652b2-1984-4de1-933f-9817738e316c"), "En cours d'acheminement" }
                });

            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "SupplierId", "Adress", "City", "Cp", "Name", "PhoneNumber", "Siret" },
                values: new object[] { new Guid("c83f33f3-c384-4da4-bc1b-99fded268020"), "14 Rue Louis Ruquier", "Sotteville-lès-Rouen", "76300", "La Centrale des Vins", "02 35 73 03 93", "38862771300067" });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "AnneeId", "CapacityId", "CepageId", "Description", "FamilyId", "Name", "Picture", "Ref", "SupplierId", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("1e839b50-2416-4f2d-8884-93c890fa73f2"), new Guid("0e31b9d5-0f6f-4e31-8f35-3137631cf874"), new Guid("228982d7-54f4-49e8-b51e-f1a24708a516"), new Guid("b6dae65e-5d42-4fc5-9002-4e9a1d02dd4e"), "Description à venir", new Guid("169ce541-e98b-4636-9bc4-872e9fef2287"), "Bouteille de vin", null, "152DER147DFM9", new Guid("c83f33f3-c384-4da4-bc1b-99fded268020"), 5.5999999999999996 },
                    { new Guid("10e7fc36-ea7f-4140-b968-9a34986dbe0a"), new Guid("531c468e-a902-4f91-9f8a-690ebe982bb7"), new Guid("d335ab3f-060f-4546-b99b-4c160d3d1605"), new Guid("866b6e9c-7516-484e-a3bb-5efbe267bcb7"), "Description à venir", new Guid("92ace882-49d0-4c3a-85a8-3d97e92741f0"), "Bouteille de bordeau", null, "452SER197DRP9", new Guid("c83f33f3-c384-4da4-bc1b-99fded268020"), 3.5 }
                });

            migrationBuilder.InsertData(
                table: "ClientOrder",
                columns: new[] { "ClientOrderId", "CustomerId", "Date", "HTPrice", "Reference", "StatusId", "TTCPrice" },
                values: new object[,]
                {
                    { new Guid("7e2e3c62-d479-4ad0-88dd-108ada5c6279"), new Guid("2c9018ec-7dbf-4fb4-9bfb-c08ea2612e89"), new DateTime(2022, 1, 3, 10, 1, 2, 582, DateTimeKind.Utc).AddTicks(1203), 0.0, "TEST123456", new Guid("1fac6542-3b52-4c80-abcf-7abcc25f7954"), 0.0 },
                    { new Guid("12adcaa7-1b5a-41c2-9f30-4439a191488d"), new Guid("beb8d433-e602-42e9-bf66-dc9c504dc089"), new DateTime(2022, 1, 3, 10, 1, 2, 582, DateTimeKind.Utc).AddTicks(1513), 0.0, "TEST234567", new Guid("1fac6542-3b52-4c80-abcf-7abcc25f7954"), 0.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("1ade3c52-af16-4eb9-bec8-f7d194700ad1"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("1ebf5007-c499-412e-85c3-9bd13cd5cad5"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("2018865b-2431-433a-9f61-2d78a91c15d7"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("36a79427-e5ee-43d7-861c-47a1299b2b8a"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("53dbadff-3f8b-4473-9dac-e964ce1b1c40"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("58d9e42a-58a5-4a5f-bc10-eaf1ab78dc59"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("7f851983-c435-4381-bc36-5f7df23d22a2"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("82e39525-04ba-44e9-938e-1f420cdf9932"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("cfec00e9-c202-47a6-bac1-df7960d31668"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("e5e0a374-0014-4afd-a345-3f8e05291750"));

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("10e7fc36-ea7f-4140-b968-9a34986dbe0a"));

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("1e839b50-2416-4f2d-8884-93c890fa73f2"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("1cde1913-dc30-45db-b890-0439e79a5a7d"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("4e8c6f7a-8bc9-44e5-bbaf-31522b97bbcf"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("8f5cbf93-a3dd-4962-95c3-fdd1aef92f08"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("b28535a7-e148-4936-9fc4-6983c1d68d1a"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("f3fde950-1278-46d1-a528-c7ac40050f18"));

            migrationBuilder.DeleteData(
                table: "ClientOrder",
                keyColumn: "ClientOrderId",
                keyValue: new Guid("12adcaa7-1b5a-41c2-9f30-4439a191488d"));

            migrationBuilder.DeleteData(
                table: "ClientOrder",
                keyColumn: "ClientOrderId",
                keyValue: new Guid("7e2e3c62-d479-4ad0-88dd-108ada5c6279"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("38adb6c6-9a77-4caf-8cca-4be88cec0a75"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("9c21b765-6eae-4e23-ae55-ed73a6121bbe"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("cd7887ae-3047-4ffd-bb4a-bc300fbec03c"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("ef8d008c-b7ca-473c-b63f-0f8b06436813"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("33795b31-db6e-4b6a-9551-14e246c4f50c"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("719902d7-1266-457b-ba18-63a0d7bf0b77"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("84f153bf-55b6-416e-999c-9f4b953946c5"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("eacbadce-24b3-4dfd-bfe4-6d1114a0fca7"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("053080a9-23a2-4ab7-add3-218ba8162242"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("4d50847d-ee93-4586-9210-160c0aa9991f"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("53f54a4e-f93f-4595-88e1-95e400a441a7"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("5c6652b2-1984-4de1-933f-9817738e316c"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("68a119b4-e2a9-4b22-99cc-249b7f1c2e44"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("9397ecd4-7ba4-4e87-82ea-4c8d24f81457"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("c78979e9-926b-4002-aab5-049ff6f24cf6"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("ea202294-faf7-49ae-9b00-35f33ed1b126"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("0e31b9d5-0f6f-4e31-8f35-3137631cf874"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("531c468e-a902-4f91-9f8a-690ebe982bb7"));

            migrationBuilder.DeleteData(
                table: "Capacity",
                keyColumn: "CapacityId",
                keyValue: new Guid("228982d7-54f4-49e8-b51e-f1a24708a516"));

            migrationBuilder.DeleteData(
                table: "Capacity",
                keyColumn: "CapacityId",
                keyValue: new Guid("d335ab3f-060f-4546-b99b-4c160d3d1605"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("866b6e9c-7516-484e-a3bb-5efbe267bcb7"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("b6dae65e-5d42-4fc5-9002-4e9a1d02dd4e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("2c9018ec-7dbf-4fb4-9bfb-c08ea2612e89"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("beb8d433-e602-42e9-bf66-dc9c504dc089"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("169ce541-e98b-4636-9bc4-872e9fef2287"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("92ace882-49d0-4c3a-85a8-3d97e92741f0"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("1fac6542-3b52-4c80-abcf-7abcc25f7954"));

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "SupplierId",
                keyValue: new Guid("c83f33f3-c384-4da4-bc1b-99fded268020"));

            migrationBuilder.AlterColumn<Guid>(
                name: "SupplierId",
                table: "Article",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "FamilyId",
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
        }
    }
}
