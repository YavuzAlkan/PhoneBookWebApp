using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Context.Migrations
{
    public partial class updateseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb90dc29-c9cd-49e5-9f45-532b3c066b87",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a267429-5988-456e-9ddb-a3ae99c9bd9d", "AQAAAAEAACcQAAAAECILXtxUOlwi8z2ZlbDJlByYOE3NzuERPrC9Al39HQ4lIx/rE8X1hddt1Wmb+9n1fQ==", "f048462e-24cc-4654-859e-142102e1fc85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db2fa01f-4054-4439-84d1-58020cb7bfe1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9532655-5e2b-4bf5-886a-56e3fed34b82", "AQAAAAEAACcQAAAAEPkweM9ML8VFBz9/8QCAQhvRb+47qBgrjt1mOslOikpSjg408w9wFD/958XYYdd4xw==", "7b66209f-89ac-4a47-b5b6-5d04dd82e608" });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "Id", "FirstName", "IsActive", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 4, "Mehmet", true, "Ak", "+905627588457" },
                    { 5, "Fatma", true, "Gül", "+905326944523" },
                    { 6, "Ali", true, "Yeşil", "+905627588458" },
                    { 7, "Emine", true, "Mavi", "+905326944524" },
                    { 8, "Veli", true, "Kırmızı", "+905627588459" },
                    { 9, "Ahmet", true, "Turuncu", "+905326944525" },
                    { 10, "Zeynep", true, "Pembe", "+905627588460" },
                    { 11, "Mustafa", true, "Mor", "+905326944526" },
                    { 12, "Rabia", true, "Kahverengi", "+905627588461" },
                    { 13, "İsmail", true, "Beyaz", "+905326944527" },
                    { 14, "Ayhan", true, "Gri", "+905627588462" },
                    { 15, "Serpil", true, "Sarı", "+905326944528" },
                    { 16, "Gülten", true, "Turkuaz", "+905627588463" },
                    { 17, "Hakan", true, "Kum", "+905326944529" },
                    { 18, "Merve", true, "Gökyüzü", "+905627588464" },
                    { 19, "Can", true, "Deniz", "+905326944530" },
                    { 20, "Ceren", true, "Yeşim", "+905627588465" },
                    { 21, "Bora", true, "Tuna", "+905326944531" },
                    { 22, "Duygu", true, "Güneş", "+905627588466" },
                    { 23, "Barış", true, "Ay", "+905326944532" },
                    { 24, "Selin", true, "Yıldız", "+905627588467" },
                    { 25, "Onur", true, "Kuzey", "+905326944533" },
                    { 26, "Nazan", true, "Güney", "+905627588468" },
                    { 27, "Kerem", true, "Doğu", "+905326944534" },
                    { 28, "Deniz", true, "Batı", "+905627588469" },
                    { 29, "Ceyda", true, "Gül", "+905326944535" },
                    { 30, "Fırat", true, "Savaş", "+905627588470" },
                    { 31, "Aylin", true, "Derya", "+905326944536" },
                    { 32, "Arda", true, "Deniz", "+905627588471" },
                    { 33, "Sinem", true, "Ege", "+905326944537" },
                    { 34, "Oğuz", true, "Koray", "+905627588472" },
                    { 35, "Seda", true, "Nil", "+905326944538" },
                    { 36, "Hüseyin", true, "Rüzgar", "+905627588473" },
                    { 37, "Nilgün", true, "Duman", "+905326944539" },
                    { 38, "Metin", true, "Işık", "+905627588474" },
                    { 39, "Pelin", true, "Ateş", "+905326944540" },
                    { 40, "Erhan", true, "Toprak", "+905627588475" },
                    { 41, "Yasemin", true, "Dağ", "+905326944541" },
                    { 42, "Gökhan", true, "Çimen", "+905627588476" },
                    { 43, "Şebnem", true, "Bahar", "+905326944542" }
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "Id", "FirstName", "IsActive", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 44, "Eren", true, "Orman", "+905627588477" },
                    { 45, "Nihan", true, "Küçük", "+905326944543" },
                    { 46, "Kemal", true, "Büyük", "+905627588478" },
                    { 47, "Burcu", true, "Kaya", "+905326944544" },
                    { 48, "Cem", true, "Göl", "+905627588479" },
                    { 49, "Murat", true, "Arslan", "+905326944545" },
                    { 50, "Sibel", true, "Kartal", "+905627588480" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb90dc29-c9cd-49e5-9f45-532b3c066b87",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76356a67-a3fe-4187-a4b7-aa8fe63f38e8", "AQAAAAEAACcQAAAAEJUP7zGNthrXh5xDWvBRHwLH+Tp5OVibaVoR2g2XQvXiciTP+bxjm8T/zZlsZSQZ6g==", "23cb3afc-16b1-4269-8f4e-758aa2c02607" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db2fa01f-4054-4439-84d1-58020cb7bfe1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46bc46c2-07ea-42ae-8d2c-725bb0158b00", "AQAAAAEAACcQAAAAEPzqM6CpqoTmOBRLu8a0Q7pwiDXRUpxrW+EiDyzarQOrdLGde1krUeZ0nWugKKmDLw==", "e9b6f318-b943-4961-93e9-fa7e8cf252a0" });
        }
    }
}
