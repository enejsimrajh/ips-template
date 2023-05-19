using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.DALEF.ContextFactory.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SYSetting",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StringValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DecimalValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateTimeValue = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Module = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LevelValue = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateChanged = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreatedID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserChangedID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYSetting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TEEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Attribute1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateChanged = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserCreatedID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserChangedID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TEEntity", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SYSetting",
                columns: new[] { "Id", "Active", "DateChanged", "DateCreated", "DateTimeValue", "DecimalValue", "Level", "LevelValue", "Module", "Name", "StringValue", "Type", "UserChangedID", "UserCreatedID" },
                values: new object[] { new Guid("d81229a0-cf63-46c0-87f4-59db2ee37256"), true, new DateTime(1800, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1800, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0m, 1, null, "SY", "DataSchemaVersion", "SchemaVersion.V1_0_0", "System.String", new Guid("89b87015-b687-4cad-a553-f911cf2e6fcf"), new Guid("89b87015-b687-4cad-a553-f911cf2e6fcf") });

            migrationBuilder.InsertData(
                table: "TEEntity",
                columns: new[] { "Id", "Active", "Attribute1", "DateChanged", "DateCreated", "UserChangedID", "UserCreatedID" },
                values: new object[] { new Guid("50366dd5-49e5-4cc4-a06d-5ec6f4c0805e"), true, "This is a dummy record.", new DateTime(1800, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1800, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("89b87015-b687-4cad-a553-f911cf2e6fcf"), new Guid("89b87015-b687-4cad-a553-f911cf2e6fcf") });

            migrationBuilder.InsertData(
                table: "TEEntity",
                columns: new[] { "Id", "Active", "Attribute1", "DateChanged", "DateCreated", "UserChangedID", "UserCreatedID" },
                values: new object[] { new Guid("c041f416-41e6-419e-b832-7e67c6c35fda"), true, "This is a seed record.", new DateTime(1800, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1800, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("89b87015-b687-4cad-a553-f911cf2e6fcf"), new Guid("89b87015-b687-4cad-a553-f911cf2e6fcf") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SYSetting");

            migrationBuilder.DropTable(
                name: "TEEntity");
        }
    }
}
