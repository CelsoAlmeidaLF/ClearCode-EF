using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Systekna.Infrasctruture.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbDespesa",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VlrDespesa = table.Column<double>(type: "float", nullable: false),
                    DsDespesa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DtVencimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdStatusPagamento = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbDespesa", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbDespesa");
        }
    }
}
