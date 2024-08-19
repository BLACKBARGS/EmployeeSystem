using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerLibrary.Data.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branches_Departments_DepartmentId",
                table: "Branches");

            migrationBuilder.DropForeignKey(
                name: "FK_Branches_GeneralDepartments_GeneralDepartmentId",
                table: "Branches");

            migrationBuilder.DropIndex(
                name: "IX_Branches_GeneralDepartmentId",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "GeneralDepartmentId",
                table: "Branches");

            migrationBuilder.AddColumn<DateTime>(
                name: "PunishmentDate",
                table: "Sanctions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Branches",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Branches_Departments_DepartmentId",
                table: "Branches",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branches_Departments_DepartmentId",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "PunishmentDate",
                table: "Sanctions");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Branches",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "GeneralDepartmentId",
                table: "Branches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Branches_GeneralDepartmentId",
                table: "Branches",
                column: "GeneralDepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Branches_Departments_DepartmentId",
                table: "Branches",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Branches_GeneralDepartments_GeneralDepartmentId",
                table: "Branches",
                column: "GeneralDepartmentId",
                principalTable: "GeneralDepartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
