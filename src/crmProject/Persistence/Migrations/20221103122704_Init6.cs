using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class Init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personnel_Department_DepartmentId",
                table: "Personnel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personnel",
                table: "Personnel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.RenameTable(
                name: "Personnel",
                newName: "Personnels");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Departments");

            migrationBuilder.RenameIndex(
                name: "IX_Personnel_IdentityNumber",
                table: "Personnels",
                newName: "IX_Personnels_IdentityNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Personnel_Email",
                table: "Personnels",
                newName: "IX_Personnels_Email");

            migrationBuilder.RenameIndex(
                name: "IX_Personnel_DepartmentId",
                table: "Personnels",
                newName: "IX_Personnels_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Department_DepartmentName",
                table: "Departments",
                newName: "IX_Departments_DepartmentName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personnels",
                table: "Personnels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Personnels_Departments_DepartmentId",
                table: "Personnels",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personnels_Departments_DepartmentId",
                table: "Personnels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personnels",
                table: "Personnels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.RenameTable(
                name: "Personnels",
                newName: "Personnel");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Department");

            migrationBuilder.RenameIndex(
                name: "IX_Personnels_IdentityNumber",
                table: "Personnel",
                newName: "IX_Personnel_IdentityNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Personnels_Email",
                table: "Personnel",
                newName: "IX_Personnel_Email");

            migrationBuilder.RenameIndex(
                name: "IX_Personnels_DepartmentId",
                table: "Personnel",
                newName: "IX_Personnel_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_DepartmentName",
                table: "Department",
                newName: "IX_Department_DepartmentName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personnel",
                table: "Personnel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Personnel_Department_DepartmentId",
                table: "Personnel",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
