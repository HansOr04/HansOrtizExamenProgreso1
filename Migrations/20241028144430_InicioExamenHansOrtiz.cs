using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HansOrtizExamenProgreso1.Migrations
{
    /// <inheritdoc />
    public partial class InicioExamenHansOrtiz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HO_Producto",
                columns: table => new
                {
                    HO_ProductoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HO_ProductoName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HO_ProductoDescripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    HO_Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HO_Variantes = table.Column<bool>(type: "bit", nullable: false),
                    HO_CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HO_Producto", x => x.HO_ProductoId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HO_Producto");
        }
    }
}
