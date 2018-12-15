using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Maxtrain.MaxCoin.Migrations
{
    public partial class initialization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blocks",
                columns: table => new
                {
                    Index = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    Hash = table.Column<string>(nullable: true),
                    PrevHash = table.Column<string>(nullable: true),
                    Data = table.Column<string>(nullable: true),
                    Nonce = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blocks", x => x.Index);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Version = table.Column<int>(nullable: false),
                    Flag = table.Column<string>(nullable: true),
                    InCounter = table.Column<int>(nullable: false),
                    Inputs = table.Column<string>(nullable: true),
                    OutCounter = table.Column<int>(nullable: false),
                    Outputs = table.Column<string>(nullable: true),
                    Witnesses = table.Column<string>(nullable: true),
                    LockTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blocks");

            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
