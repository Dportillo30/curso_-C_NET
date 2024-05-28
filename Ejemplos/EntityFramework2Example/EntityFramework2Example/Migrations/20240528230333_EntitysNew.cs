using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework2Example.Migrations
{
    public partial class EntitysNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Canciones",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Canciones",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AlbumId",
                table: "Canciones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AuthorId1",
                table: "Canciones",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuthorId2",
                table: "Canciones",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    AlbumId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.AlbumId);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Canciones_AlbumId",
                table: "Canciones",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Canciones_AuthorId1",
                table: "Canciones",
                column: "AuthorId1");

            migrationBuilder.CreateIndex(
                name: "IX_Canciones_AuthorId2",
                table: "Canciones",
                column: "AuthorId2");

            migrationBuilder.AddForeignKey(
                name: "FK_Canciones_Albums_AlbumId",
                table: "Canciones",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "AlbumId",
                onDelete: ReferentialAction.Cascade);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Canciones_Albums_AlbumId",
                table: "Canciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Canciones_Authors_AuthorId1",
                table: "Canciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Canciones_Authors_AuthorId2",
                table: "Canciones");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Canciones_AlbumId",
                table: "Canciones");

            migrationBuilder.DropIndex(
                name: "IX_Canciones_AuthorId1",
                table: "Canciones");

            migrationBuilder.DropIndex(
                name: "IX_Canciones_AuthorId2",
                table: "Canciones");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Canciones");

            migrationBuilder.DropColumn(
                name: "AuthorId1",
                table: "Canciones");

            migrationBuilder.DropColumn(
                name: "AuthorId2",
                table: "Canciones");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Canciones",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Canciones",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);
        }
    }
}
