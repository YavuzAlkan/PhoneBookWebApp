using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Context.Migrations
{
    public partial class UpdateContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Contact",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Contact",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb90dc29-c9cd-49e5-9f45-532b3c066b87",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a98518a-2807-44f0-aa7d-6e4e864475e3", "AQAAAAEAACcQAAAAEO6TU41Dj03jL08r7Kbe6+Nt9dr3XZ8sCNjn3TQUXnqwo9yBjsa4ywyoD+CDbbt3QA==", "40f4a0ee-9f4c-4ae3-a0a1-d4773ee382fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db2fa01f-4054-4439-84d1-58020cb7bfe1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2401c843-931e-4ae7-9217-127c42c507fa", "AQAAAAEAACcQAAAAEEp6ul/bnzmsmk7mUuup7D+3UIwmHG2nc4fOSotQ099IxfBxFXA3GAvoFFR2hadTfg==", "72fbf285-3bf7-40e6-8128-e81063c428c6" });

            migrationBuilder.CreateIndex(
                name: "IX_Contact_PhoneNumber",
                table: "Contact",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contact_UserId1",
                table: "Contact",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_AspNetUsers_UserId1",
                table: "Contact",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_AspNetUsers_UserId1",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_PhoneNumber",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_UserId1",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Contact");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb90dc29-c9cd-49e5-9f45-532b3c066b87",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "875b4736-2e6b-4ffe-ad32-a5644927c46e", "AQAAAAEAACcQAAAAEBVqo/Bby0mFoUTqGpMJc/PUcsriZaU5CL2p0ItHqvVMJLUS3tJjxuB15psaC+oEig==", "1ef0b563-6f81-45a0-8c40-53ca441cf57b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db2fa01f-4054-4439-84d1-58020cb7bfe1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4e36629-302e-4c4c-9b58-f35310ba0722", "AQAAAAEAACcQAAAAENdQuQ14fNkafU30fvsseWS28K0GLpbb9c14Efm4EZgHyyMUsFswkVyG6dlSj6ManA==", "592dad0f-e886-4cca-a2b4-65849b622a20" });
        }
    }
}
