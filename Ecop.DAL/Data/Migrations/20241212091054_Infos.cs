using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecop.PL.Data.Migrations
{
    /// <inheritdoc />
    public partial class Infos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "922a9ac4-70b2-49bd-b6f2-8901e99b9326", "77672ab1-9fc3-4d1f-beec-825e1991bc43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fdcd7773-2894-4e98-8327-66d017bccd14", "c6b1ffe4-9ef5-43b0-a560-de9fdf0e1a61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fc36ce6f-9de8-47f3-82ba-a51d772e3dc7", "7dec9742-e64a-49ad-9234-0a740e238282" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0d4cddad-9d3a-41b2-8abb-250804d0283a", "f6681f13-27b2-40d1-a7f2-40c9c8c52ade" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e3023d91-5901-4d21-92e1-b4368edcbdfd", "cabdf74c-46a3-4ce4-a2f3-d93d1ede9907" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "09b7f8bb-ac54-42e0-9d55-0c3ca5f65cc2", "b8adfad8-ab9b-45e5-b7aa-4be8439fec6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "249f9a64-9eaa-4951-83b8-4eee13e26bae", "9e0411d0-d39e-4571-b59a-f6b9366ed4a7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2e780f50-e0cc-4d06-9b9f-c3c68c952ea0", "ca0ceca8-6d55-4e6d-98d2-746a48b174a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f5f56445-c71a-4d04-8ff0-08979330f852", "bb6fdd2d-1d0c-423d-a366-5b18c3853e98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "12190b7e-d29d-4206-9579-95855b3bd2dd", "d41dc6cd-14f0-492c-9dea-cf2da7bf155d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8bb61a4c-2b65-4e0f-8d79-a6efa56faf8c", "de8986ba-a6c4-4cfb-b805-f91f059906ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b5d39259-29ee-46aa-a29b-32a9ebb19807", "55d1733e-d06a-4807-b0f5-f9ccde2a69ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8c16fc78-edc5-4253-8296-adb50644c230", "c33f4c95-9fb7-4c30-8cc9-934a30f66a3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1f112869-efb7-4c18-8713-463d6c2b505a", "a6e14028-90d6-4a1a-a23d-c530c7b6e759" });
        }
    }
}
