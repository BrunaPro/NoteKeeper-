using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoteKeeper.Migrations
{
    public partial class DeleteAtNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Users_userId",
                table: "Notes");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Notes",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Notes",
                newName: "Updated_at");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Notes",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "delete_at",
                table: "Notes",
                newName: "Delete_at");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Notes",
                newName: "Created_at");

            migrationBuilder.RenameColumn(
                name: "content",
                table: "Notes",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Notes",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Notes_userId",
                table: "Notes",
                newName: "IX_Notes_UserId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated_at",
                table: "Notes",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Delete_at",
                table: "Notes",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Users_UserId",
                table: "Notes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Users_UserId",
                table: "Notes");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Notes",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "Updated_at",
                table: "Notes",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Notes",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Delete_at",
                table: "Notes",
                newName: "delete_at");

            migrationBuilder.RenameColumn(
                name: "Created_at",
                table: "Notes",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Notes",
                newName: "content");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Notes",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Notes_UserId",
                table: "Notes",
                newName: "IX_Notes_userId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "Notes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "delete_at",
                table: "Notes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Users_userId",
                table: "Notes",
                column: "userId",
                principalTable: "Users",
                principalColumn: "id");
        }
    }
}
