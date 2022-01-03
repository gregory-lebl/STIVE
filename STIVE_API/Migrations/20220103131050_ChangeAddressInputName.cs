using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace STIVE_API.Migrations
{
    public partial class ChangeAddressInputName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "Employee",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "Customers",
                newName: "Address");

            migrationBuilder.InsertData(
                table: "Annee",
                columns: new[] { "AnneeId", "Number" },
                values: new object[,]
                {
                    { new Guid("72c30a4b-0588-44f2-806e-3ec14d74474e"), 2010 },
                    { new Guid("0aa23500-7964-43c4-b193-7cbe5c14aa3f"), 2011 },
                    { new Guid("ea76c73f-2fbd-4283-9606-6980772ab98b"), 2012 },
                    { new Guid("48b9fba2-19ea-4c8d-939b-1895b3f04185"), 2013 },
                    { new Guid("2932e7e4-4a36-4f06-b162-18febd484c24"), 2014 },
                    { new Guid("661391aa-9372-4b4d-b721-0df3339ec08d"), 2015 },
                    { new Guid("a875f7b8-5ccb-47cc-a5fd-8972cecac76f"), 2016 },
                    { new Guid("2c1c9a0d-5e8f-4902-88d0-5ceeeae44cd8"), 2017 },
                    { new Guid("82f17568-6fc2-4ac4-8b28-ca94adb5f3da"), 2018 },
                    { new Guid("e4ab022e-3e47-4772-857e-e57e0c7cef82"), 2019 },
                    { new Guid("603b6d49-eee1-42b4-8d4f-108857455001"), 2020 },
                    { new Guid("e278a57a-1631-4f77-bf98-da33cdb3a686"), 2021 }
                });

            migrationBuilder.InsertData(
                table: "Capacity",
                columns: new[] { "CapacityId", "BottleCapacity" },
                values: new object[,]
                {
                    { new Guid("5640bc96-9ec9-4e94-9227-2f11ca64ef4f"), 37.5 },
                    { new Guid("a2c7026f-3a21-49fa-967d-8edd5414e4dc"), 75.0 }
                });

            migrationBuilder.InsertData(
                table: "Cepage",
                columns: new[] { "CepageId", "Name", "Origin" },
                values: new object[,]
                {
                    { new Guid("7a2853ea-45ba-4fcd-abfe-27e5050b0742"), "Chardonnay", "France" },
                    { new Guid("ff493a47-fe2c-4bfc-9853-9f8881dfba98"), "Sauvignon", "France" },
                    { new Guid("f193a0fc-15ac-4d38-b277-3508760619cd"), "Pinot Noir", "Allemagne" },
                    { new Guid("0252051a-a00e-4934-873e-5d6aec75c4f8"), "Riesling", "France" },
                    { new Guid("702039a9-5aa4-4558-9db8-fa5bc2302072"), "Gewurztraminer", "France" },
                    { new Guid("573aa12d-7bc4-4e9e-80d2-a049e7357fd8"), "Merlot noir", "France" },
                    { new Guid("b3c5a2fc-10b4-46ea-8fa1-653e2620d8e2"), "Mauzac rosé", "France" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "Cp", "CustomerReference", "Email", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("f19ba76e-395e-476b-82ba-c6e6941ecff4"), "123 rue des chats", "CroquetteLand", "000009", "CCAYOVJ15ETD", "gregory.lbl@gmail.com", "Gregory", "LEBLOND", "123", "0631258641" },
                    { new Guid("808f43fe-edeb-46a8-9521-63143f72aaa4"), "1 chemin des alisiers 67700 Saverne", "Saverne", "67700", "RJEL5WGMXNN2", "luciole.trp@gmail.com", "Lucile", "TRIPIER", "123", "0699318613" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Address", "City", "Cp", "Email", "EmployeNumber", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("d7379fee-70b4-456e-b061-cfdc87339ac7"), "57 Boulevard Gambetta", "Evreux", "27000", "francois.dupont@yahoo.com", "JKFSBQD5KS", "François", "DUPONT", "123", "0635241896" },
                    { new Guid("6f727433-e803-421b-8157-08797253fe23"), "3 Grande rue", "Rouen", "76000", "mariam.el@gmail.com", "1K6VTBC4C6", "Mariam", "EL-ALLALI", "123", "0698574123" },
                    { new Guid("f1fe7f00-3e32-4d25-a783-dd63eea9e949"), "3 Rue du Bout au Roussel", "Champenard", "27600", "jeremy.petit@outlook.com", "10G6S9PV4K", "Jeremy", "PETIT", "123", "0652341254" },
                    { new Guid("1ec323f1-eb80-4dd4-9bc9-7957a065eb41"), "21 Rue Victor Hugo", "Evreux", "27000", "francine.dupont@gmail.com", "1461KGJLGK", "Francine", "DUPONT", "123", "0632547896" }
                });

            migrationBuilder.InsertData(
                table: "Family",
                columns: new[] { "FamilyId", "Name" },
                values: new object[,]
                {
                    { new Guid("69490ec8-c1be-4ed6-b321-1c676a196228"), "Mousseux" },
                    { new Guid("b62e4e57-1ca6-470e-af62-6af7883f7ef8"), "Vin blanc" },
                    { new Guid("a6c6aa54-7149-4e98-a517-9142b857487d"), "Vin rouge" },
                    { new Guid("f92b6bd4-8b86-4ec0-b56f-5ab691850f83"), "Muscat" },
                    { new Guid("8c36ffd8-9b4e-4df6-add6-3d96363638a8"), "Vin cuit" },
                    { new Guid("9c22dfd6-914c-412b-9558-5a4ed819cbba"), "Rosé" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "StatusId", "Name" },
                values: new object[,]
                {
                    { new Guid("30395bda-0fc0-47e8-b0c6-1c7aec6e25f5"), "En préparation" },
                    { new Guid("67e809d4-c85d-4a29-89db-d3bdbc38feab"), "En cours d'approvisionnement" },
                    { new Guid("f93d3524-31e1-4ccd-912d-05fb56255ae7"), "j'ai volé votre bouteille, merci, bisous, de Greg." },
                    { new Guid("ad74b3f6-c851-455b-870b-27b93eb53eb6"), "Livrée" },
                    { new Guid("259e8fe2-469d-4225-84d1-811790c7853a"), "Archivée" },
                    { new Guid("bcc882c8-624c-487d-a1e6-8a6cdf174d04"), "Terminée" },
                    { new Guid("9dbd3fe8-72ab-4874-8e13-36933ab4c743"), "Vérification en cours" },
                    { new Guid("f8db0f33-602e-4e34-ae47-cccb8304e4e7"), "En cours de traitement" },
                    { new Guid("c0ee4508-8519-4cfb-b3c2-68d82030fb8f"), "En cours d'acheminement" }
                });

            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "SupplierId", "Adress", "City", "Cp", "Name", "PhoneNumber", "Siret" },
                values: new object[] { new Guid("546d0d25-3328-46b7-9994-968e9af13e51"), "14 Rue Louis Ruquier", "Sotteville-lès-Rouen", "76300", "La Centrale des Vins", "02 35 73 03 93", "38862771300067" });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "AnneeId", "CapacityId", "CepageId", "Description", "FamilyId", "Name", "Picture", "Ref", "SupplierId", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("2323568f-76e3-4c0d-92aa-c9cea8ec1ba8"), new Guid("72c30a4b-0588-44f2-806e-3ec14d74474e"), new Guid("a2c7026f-3a21-49fa-967d-8edd5414e4dc"), new Guid("7a2853ea-45ba-4fcd-abfe-27e5050b0742"), "Description à venir", new Guid("9c22dfd6-914c-412b-9558-5a4ed819cbba"), "Bouteille de vin", null, "152DER147DFM9", new Guid("546d0d25-3328-46b7-9994-968e9af13e51"), 5.5999999999999996 },
                    { new Guid("e6078a4e-4cc2-42f5-9d1f-906dc2b5cb7b"), new Guid("e278a57a-1631-4f77-bf98-da33cdb3a686"), new Guid("5640bc96-9ec9-4e94-9227-2f11ca64ef4f"), new Guid("b3c5a2fc-10b4-46ea-8fa1-653e2620d8e2"), "Description à venir", new Guid("69490ec8-c1be-4ed6-b321-1c676a196228"), "Bouteille de bordeau", null, "452SER197DRP9", new Guid("546d0d25-3328-46b7-9994-968e9af13e51"), 3.5 }
                });

            migrationBuilder.InsertData(
                table: "ClientOrder",
                columns: new[] { "ClientOrderId", "CustomerId", "Date", "HTPrice", "Reference", "StatusId", "TTCPrice" },
                values: new object[,]
                {
                    { new Guid("54d5e537-e884-490d-9644-ce89dc91b79f"), new Guid("808f43fe-edeb-46a8-9521-63143f72aaa4"), new DateTime(2022, 1, 3, 13, 10, 50, 124, DateTimeKind.Utc).AddTicks(8098), 0.0, "TEST123456", new Guid("9dbd3fe8-72ab-4874-8e13-36933ab4c743"), 0.0 },
                    { new Guid("e88b0ea7-fbca-4b31-9f86-49ba2e4c3255"), new Guid("f19ba76e-395e-476b-82ba-c6e6941ecff4"), new DateTime(2022, 1, 3, 13, 10, 50, 124, DateTimeKind.Utc).AddTicks(8821), 0.0, "TEST234567", new Guid("9dbd3fe8-72ab-4874-8e13-36933ab4c743"), 0.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("0aa23500-7964-43c4-b193-7cbe5c14aa3f"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("2932e7e4-4a36-4f06-b162-18febd484c24"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("2c1c9a0d-5e8f-4902-88d0-5ceeeae44cd8"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("48b9fba2-19ea-4c8d-939b-1895b3f04185"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("603b6d49-eee1-42b4-8d4f-108857455001"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("661391aa-9372-4b4d-b721-0df3339ec08d"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("82f17568-6fc2-4ac4-8b28-ca94adb5f3da"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("a875f7b8-5ccb-47cc-a5fd-8972cecac76f"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("e4ab022e-3e47-4772-857e-e57e0c7cef82"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("ea76c73f-2fbd-4283-9606-6980772ab98b"));

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("2323568f-76e3-4c0d-92aa-c9cea8ec1ba8"));

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: new Guid("e6078a4e-4cc2-42f5-9d1f-906dc2b5cb7b"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("0252051a-a00e-4934-873e-5d6aec75c4f8"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("573aa12d-7bc4-4e9e-80d2-a049e7357fd8"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("702039a9-5aa4-4558-9db8-fa5bc2302072"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("f193a0fc-15ac-4d38-b277-3508760619cd"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("ff493a47-fe2c-4bfc-9853-9f8881dfba98"));

            migrationBuilder.DeleteData(
                table: "ClientOrder",
                keyColumn: "ClientOrderId",
                keyValue: new Guid("54d5e537-e884-490d-9644-ce89dc91b79f"));

            migrationBuilder.DeleteData(
                table: "ClientOrder",
                keyColumn: "ClientOrderId",
                keyValue: new Guid("e88b0ea7-fbca-4b31-9f86-49ba2e4c3255"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("1ec323f1-eb80-4dd4-9bc9-7957a065eb41"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("6f727433-e803-421b-8157-08797253fe23"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("d7379fee-70b4-456e-b061-cfdc87339ac7"));

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: new Guid("f1fe7f00-3e32-4d25-a783-dd63eea9e949"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("8c36ffd8-9b4e-4df6-add6-3d96363638a8"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("a6c6aa54-7149-4e98-a517-9142b857487d"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("b62e4e57-1ca6-470e-af62-6af7883f7ef8"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("f92b6bd4-8b86-4ec0-b56f-5ab691850f83"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("259e8fe2-469d-4225-84d1-811790c7853a"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("30395bda-0fc0-47e8-b0c6-1c7aec6e25f5"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("67e809d4-c85d-4a29-89db-d3bdbc38feab"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("ad74b3f6-c851-455b-870b-27b93eb53eb6"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("bcc882c8-624c-487d-a1e6-8a6cdf174d04"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("c0ee4508-8519-4cfb-b3c2-68d82030fb8f"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("f8db0f33-602e-4e34-ae47-cccb8304e4e7"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("f93d3524-31e1-4ccd-912d-05fb56255ae7"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("72c30a4b-0588-44f2-806e-3ec14d74474e"));

            migrationBuilder.DeleteData(
                table: "Annee",
                keyColumn: "AnneeId",
                keyValue: new Guid("e278a57a-1631-4f77-bf98-da33cdb3a686"));

            migrationBuilder.DeleteData(
                table: "Capacity",
                keyColumn: "CapacityId",
                keyValue: new Guid("5640bc96-9ec9-4e94-9227-2f11ca64ef4f"));

            migrationBuilder.DeleteData(
                table: "Capacity",
                keyColumn: "CapacityId",
                keyValue: new Guid("a2c7026f-3a21-49fa-967d-8edd5414e4dc"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("7a2853ea-45ba-4fcd-abfe-27e5050b0742"));

            migrationBuilder.DeleteData(
                table: "Cepage",
                keyColumn: "CepageId",
                keyValue: new Guid("b3c5a2fc-10b4-46ea-8fa1-653e2620d8e2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("808f43fe-edeb-46a8-9521-63143f72aaa4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("f19ba76e-395e-476b-82ba-c6e6941ecff4"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("69490ec8-c1be-4ed6-b321-1c676a196228"));

            migrationBuilder.DeleteData(
                table: "Family",
                keyColumn: "FamilyId",
                keyValue: new Guid("9c22dfd6-914c-412b-9558-5a4ed819cbba"));

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "StatusId",
                keyValue: new Guid("9dbd3fe8-72ab-4874-8e13-36933ab4c743"));

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "SupplierId",
                keyValue: new Guid("546d0d25-3328-46b7-9994-968e9af13e51"));

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Employee",
                newName: "Adress");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Customers",
                newName: "Adress");

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
    }
}
