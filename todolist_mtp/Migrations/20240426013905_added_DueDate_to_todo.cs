using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace todolist_mtp.Migrations
{
    /// <inheritdoc />
    public partial class added_DueDate_to_todo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DueDate",
                table: "Todos",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "Todos");
        }
    }
}
