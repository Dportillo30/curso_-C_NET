using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework2Example.Migrations
{
    public partial class fixEntityes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Canciones_Authors_AuthorId1",
                table: "Canciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Canciones_Authors_AuthorId2",
                table: "Canciones");

            migrationBuilder.DropIndex(
                name: "IX_Canciones_AuthorId1",
                table: "Canciones");

            migrationBuilder.DropIndex(
                name: "IX_Canciones_AuthorId2",
                table: "Canciones");

            migrationBuilder.DropColumn(
                name: "AuthorId1",
                table: "Canciones");

            migrationBuilder.DropColumn(
                name: "AuthorId2",
                table: "Canciones");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Canciones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Canciones_AuthorId",
                table: "Canciones",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Canciones_Authors_AuthorId",
                table: "Canciones",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Canciones_Authors_AuthorId",
                table: "Canciones");

            migrationBuilder.DropIndex(
                name: "IX_Canciones_AuthorId",
                table: "Canciones");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Canciones");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId1",
                table: "Canciones",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuthorId2",
                table: "Canciones",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Canciones_AuthorId1",
                table: "Canciones",
                column: "AuthorId1");

            migrationBuilder.CreateIndex(
                name: "IX_Canciones_AuthorId2",
                table: "Canciones",
                column: "AuthorId2");

            migrationBuilder.AddForeignKey(
                name: "FK_Canciones_Authors_AuthorId1",
                table: "Canciones",
                column: "AuthorId1",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Canciones_Authors_AuthorId2",
                table: "Canciones",
                column: "AuthorId2",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
