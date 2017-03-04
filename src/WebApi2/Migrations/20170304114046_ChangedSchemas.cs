using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi2.Migrations
{
    public partial class ChangedSchemas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "WebApi2");

            migrationBuilder.RenameTable(
                name: "Orders",
                newSchema: "WebApi2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Orders",
                schema: "WebApi2");
        }
    }
}
