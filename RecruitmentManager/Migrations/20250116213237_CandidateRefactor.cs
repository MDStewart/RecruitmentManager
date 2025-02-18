using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecruitmentManager.Migrations
{
    /// <inheritdoc />
    public partial class CandidateRefactor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "Education",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Candidates");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Candidates",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "TwoFactorEnabled",
                table: "Candidates",
                newName: "IsEmploymentEligible");

            migrationBuilder.RenameColumn(
                name: "SecurityStamp",
                table: "Candidates",
                newName: "OtherMajor");

            migrationBuilder.RenameColumn(
                name: "PhoneNumberConfirmed",
                table: "Candidates",
                newName: "HasGraduated");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Candidates",
                newName: "Jobs");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "Candidates",
                newName: "EducationDegree");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Candidates",
                newName: "Comment");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Candidates",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Candidates",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateSubmitted",
                table: "Candidates",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateSubmitted",
                table: "Candidates");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Candidates",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "OtherMajor",
                table: "Candidates",
                newName: "SecurityStamp");

            migrationBuilder.RenameColumn(
                name: "Jobs",
                table: "Candidates",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "IsEmploymentEligible",
                table: "Candidates",
                newName: "TwoFactorEnabled");

            migrationBuilder.RenameColumn(
                name: "HasGraduated",
                table: "Candidates",
                newName: "PhoneNumberConfirmed");

            migrationBuilder.RenameColumn(
                name: "EducationDegree",
                table: "Candidates",
                newName: "PasswordHash");

            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "Candidates",
                newName: "Password");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Candidates",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Candidates",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Candidates",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Candidates",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Education",
                table: "Candidates",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Candidates",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Candidates",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Candidates",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Candidates",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Candidates",
                type: "TEXT",
                nullable: true);
        }
    }
}
