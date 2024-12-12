using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecop.PL.Data.Migrations
{
    /// <inheritdoc />
    public partial class Info : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "12bc4997-d6fb-42ca-981b-23be8f2c8415", "3d579c8c-4c8d-427a-9de6-198a30a974a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "97a314e1-3d7f-432d-aa54-1d722191d74e", "3ae8bea2-07b1-4f5c-b3d5-8adde8f95e2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2d3c09ab-b33f-4679-8a38-37359670a14f", "d756f7cd-2f09-42e7-84d8-eb9ea2b85226" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6a691eb5-3354-4d62-95c7-2bf7806f3426", "393797cc-b7a7-47e6-b8d2-e4739a57c604" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fcaa285f-958c-4ce9-b7dd-25a782b22c3f", "c05ef06f-37e8-4f6d-8284-54f7166ab451" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "80783a8f-49a1-49fb-a75b-c2edd4782c51", "19fce6e3-923c-4db7-9869-06b8d7c7397c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "541c746d-8d0b-4357-9b35-e7ce840b8343", "f3f9cbd5-d806-4243-a728-83a0295c7229" });
        }
    }
}
