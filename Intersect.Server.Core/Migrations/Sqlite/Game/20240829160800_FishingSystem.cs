using System;
using Intersect.Server.Database.PlayerData;
using Intersect.Server.Database;
using Microsoft.EntityFrameworkCore.Migrations;
using SqlKata;
using Intersect.Server.Database.GameData;
using Intersect.Server.Migrations.SqlOnlyDataMigrations;
using SqlKata.Extensions;
using SqlKata.Compilers;

#nullable disable

namespace Intersect.Server.Migrations.Sqlite.Game
{
    /// <inheritdoc />
    public partial class FishingSystem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fishes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Chance = table.Column<int>(type: "INTEGER", nullable: true),
                    Weight = table.Column<int>(type: "INTEGER", nullable: true),
                    PushStrength = table.Column<int>(type: "INTEGER", nullable: true),
                    Strength = table.Column<int>(type: "INTEGER", nullable: true),
                    Position = table.Column<int>(type: "INTEGER", nullable: true),
                    RangeSize = table.Column<int>(type: "INTEGER", nullable: true),
                    SpeedMove = table.Column<int>(type: "INTEGER", nullable: true),
                    SpeedChangeRangeSize = table.Column<int>(type: "INTEGER", nullable: true),
                    CoeffUnpredictability = table.Column<int>(type: "INTEGER", nullable: true),
                    TimeChangeSpeed = table.Column<int>(type: "INTEGER", nullable: true),
                    TimeChangeRangeSize = table.Column<int>(type: "INTEGER", nullable: true),
                    ItemId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Folder = table.Column<string>(type: "TEXT", nullable: true),
                    Event = table.Column<Guid>(type: "TEXT", nullable: true),
                    FishingRequirements = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    TimeCreated = table.Column<long>(type: "INTEGER", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fishes", x => x.Id);
                });
            migrationBuilder.CreateTable(
               name: "FishingSpots",
               columns: table => new
               {
                   Id = table.Column<Guid>(type: "TEXT", nullable: false),
                   Name = table.Column<string>(type: "TEXT", nullable: true),
                   Fishes = table.Column<string>(type: "TEXT", nullable: true),
                   Folder = table.Column<string>(type: "TEXT", nullable: true),
                   TimeCreated = table.Column<long>(type: "INTEGER", nullable: true),
                   FishingTimeMin = table.Column<long>(type: "INTEGER", nullable: true, defaultValue:0),
                   FishingTimeMax = table.Column<long>(type: "INTEGER", nullable: true, defaultValue: 0),
                   FishingRequirements = table.Column<long>(type: "TEXT", nullable: true, defaultValue: "[]"),
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_FishingSpots", x => x.Id);
               });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Fishes");
            migrationBuilder.DropTable(name: "FishingSpots");
        }
    }
}
