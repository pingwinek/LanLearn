using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Dto.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PartsOfSpeech",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PolishTranslate = table.Column<string>(nullable: true),
                    Symbol = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartsOfSpeech", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnglishDictionaries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EnglishWord = table.Column<string>(nullable: true),
                    PartOfSpeechID = table.Column<int>(nullable: false),
                    PolishTranslate = table.Column<string>(nullable: true),
                    Rank = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnglishDictionaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnglishDictionaries_PartsOfSpeech_PartOfSpeechID",
                        column: x => x.PartOfSpeechID,
                        principalTable: "PartsOfSpeech",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EnglishDictionaries_PartOfSpeechID",
                table: "EnglishDictionaries",
                column: "PartOfSpeechID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnglishDictionaries");

            migrationBuilder.DropTable(
                name: "PartsOfSpeech");
        }
    }
}
