using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ElectionProject.Migrations
{
    public partial class nev : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "appeal_circuit_id_fkey",
                table: "appeal");

            migrationBuilder.DropForeignKey(
                name: "complaint_circuit_id_fkey",
                table: "complaint");

            migrationBuilder.DropForeignKey(
                name: "district_circuit_id_fkey",
                table: "district");

            migrationBuilder.DropForeignKey(
                name: "observer_circuit_id_fkey",
                table: "observer");

            migrationBuilder.DropForeignKey(
                name: "vote_circuit_id_fkey",
                table: "vote");

            migrationBuilder.DropTable(
                name: "head_circuit");

            migrationBuilder.DropTable(
                name: "head_district");

            migrationBuilder.DropPrimaryKey(
                name: "PK_district",
                table: "district");

            migrationBuilder.DropPrimaryKey(
                name: "PK_circuit",
                table: "circuit");

            migrationBuilder.DropColumn(
                name: "district_id",
                table: "district");

            migrationBuilder.DropColumn(
                name: "center",
                table: "district");

            migrationBuilder.DropColumn(
                name: "circuit_id",
                table: "circuit");

            migrationBuilder.DropColumn(
                name: "district_name",
                table: "circuit");

            migrationBuilder.RenameColumn(
                name: "circuit_id",
                table: "vote",
                newName: "district_id");

            migrationBuilder.RenameColumn(
                name: "vote_id",
                table: "vote",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_vote_circuit_id",
                table: "vote",
                newName: "IX_vote_district_id");

            migrationBuilder.RenameColumn(
                name: "type_id",
                table: "type",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "circuit_id",
                table: "observer",
                newName: "district_id");

            migrationBuilder.RenameColumn(
                name: "observer_id",
                table: "observer",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_observer_circuit_id",
                table: "observer",
                newName: "IX_observer_district_id");

            migrationBuilder.RenameColumn(
                name: "election_id",
                table: "election",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "number",
                table: "district",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "circuit_id",
                table: "complaint",
                newName: "district_id");

            migrationBuilder.RenameColumn(
                name: "complaint_id",
                table: "complaint",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_complaint_circuit_id",
                table: "complaint",
                newName: "IX_complaint_district_id");

            migrationBuilder.RenameColumn(
                name: "surname",
                table: "citizen",
                newName: "middle_name");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "citizen",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "birth",
                table: "citizen",
                newName: "birth_date");

            migrationBuilder.RenameColumn(
                name: "citizen_id",
                table: "citizen",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "number",
                table: "circuit",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "candidate_id",
                table: "candidate",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "circuit_id",
                table: "appeal",
                newName: "district_id");

            migrationBuilder.RenameColumn(
                name: "appeal_id",
                table: "appeal",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_appeal_circuit_id",
                table: "appeal",
                newName: "IX_appeal_district_id");

            migrationBuilder.AlterColumn<string>(
                name: "address",
                table: "district",
                type: "character varying(75)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)");

            migrationBuilder.AlterColumn<string>(
                name: "address",
                table: "circuit",
                type: "character varying(75)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(30)");

            migrationBuilder.AddColumn<string>(
                name: "center",
                table: "circuit",
                type: "character varying(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_district",
                table: "district",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_circuit",
                table: "circuit",
                column: "id");

            migrationBuilder.CreateTable(
                name: "circuit_head",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    election_id = table.Column<int>(nullable: true),
                    circuit_id = table.Column<int>(nullable: true),
                    citizen_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_circuit_head", x => x.id);
                    table.ForeignKey(
                        name: "circuit_head_circuit_id_fkey",
                        column: x => x.circuit_id,
                        principalTable: "circuit",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "circuit_head_citizen_id_fkey",
                        column: x => x.citizen_id,
                        principalTable: "citizen",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "circuit_head_election_id_fkey",
                        column: x => x.election_id,
                        principalTable: "election",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "district_head",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    election_id = table.Column<int>(nullable: true),
                    district_id = table.Column<int>(nullable: true),
                    citizen_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_district_head", x => x.id);
                    table.ForeignKey(
                        name: "district_head_citizen_id_fkey",
                        column: x => x.citizen_id,
                        principalTable: "citizen",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "district_head_district_id_fkey",
                        column: x => x.district_id,
                        principalTable: "district",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "district_head_election_id_fkey",
                        column: x => x.election_id,
                        principalTable: "election",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    SecondName = table.Column<string>(nullable: true),
                    MyProperty = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_circuit_head_circuit_id",
                table: "circuit_head",
                column: "circuit_id");

            migrationBuilder.CreateIndex(
                name: "IX_circuit_head_citizen_id",
                table: "circuit_head",
                column: "citizen_id");

            migrationBuilder.CreateIndex(
                name: "IX_circuit_head_election_id",
                table: "circuit_head",
                column: "election_id");

            migrationBuilder.CreateIndex(
                name: "IX_district_head_citizen_id",
                table: "district_head",
                column: "citizen_id");

            migrationBuilder.CreateIndex(
                name: "IX_district_head_district_id",
                table: "district_head",
                column: "district_id");

            migrationBuilder.CreateIndex(
                name: "IX_district_head_election_id",
                table: "district_head",
                column: "election_id");

            migrationBuilder.AddForeignKey(
                name: "appeal_district_id_fkey",
                table: "appeal",
                column: "district_id",
                principalTable: "district",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "complaint_district_id_fkey",
                table: "complaint",
                column: "district_id",
                principalTable: "district",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "district_circuit_id_fkey",
                table: "district",
                column: "circuit_id",
                principalTable: "circuit",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "observer_district_id_fkey",
                table: "observer",
                column: "district_id",
                principalTable: "district",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "vote_district_id_fkey",
                table: "vote",
                column: "district_id",
                principalTable: "district",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "appeal_district_id_fkey",
                table: "appeal");

            migrationBuilder.DropForeignKey(
                name: "complaint_district_id_fkey",
                table: "complaint");

            migrationBuilder.DropForeignKey(
                name: "district_circuit_id_fkey",
                table: "district");

            migrationBuilder.DropForeignKey(
                name: "observer_district_id_fkey",
                table: "observer");

            migrationBuilder.DropForeignKey(
                name: "vote_district_id_fkey",
                table: "vote");

            migrationBuilder.DropTable(
                name: "circuit_head");

            migrationBuilder.DropTable(
                name: "district_head");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_district",
                table: "district");

            migrationBuilder.DropPrimaryKey(
                name: "PK_circuit",
                table: "circuit");

            migrationBuilder.DropColumn(
                name: "center",
                table: "circuit");

            migrationBuilder.RenameColumn(
                name: "district_id",
                table: "vote",
                newName: "circuit_id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "vote",
                newName: "vote_id");

            migrationBuilder.RenameIndex(
                name: "IX_vote_district_id",
                table: "vote",
                newName: "IX_vote_circuit_id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "type",
                newName: "type_id");

            migrationBuilder.RenameColumn(
                name: "district_id",
                table: "observer",
                newName: "circuit_id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "observer",
                newName: "observer_id");

            migrationBuilder.RenameIndex(
                name: "IX_observer_district_id",
                table: "observer",
                newName: "IX_observer_circuit_id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "election",
                newName: "election_id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "district",
                newName: "number");

            migrationBuilder.RenameColumn(
                name: "district_id",
                table: "complaint",
                newName: "circuit_id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "complaint",
                newName: "complaint_id");

            migrationBuilder.RenameIndex(
                name: "IX_complaint_district_id",
                table: "complaint",
                newName: "IX_complaint_circuit_id");

            migrationBuilder.RenameColumn(
                name: "middle_name",
                table: "citizen",
                newName: "surname");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "citizen",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "birth_date",
                table: "citizen",
                newName: "birth");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "citizen",
                newName: "citizen_id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "circuit",
                newName: "number");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "candidate",
                newName: "candidate_id");

            migrationBuilder.RenameColumn(
                name: "district_id",
                table: "appeal",
                newName: "circuit_id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "appeal",
                newName: "appeal_id");

            migrationBuilder.RenameIndex(
                name: "IX_appeal_district_id",
                table: "appeal",
                newName: "IX_appeal_circuit_id");

            migrationBuilder.AlterColumn<string>(
                name: "address",
                table: "district",
                type: "character varying(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(75)");

            migrationBuilder.AddColumn<int>(
                name: "district_id",
                table: "district",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddColumn<string>(
                name: "center",
                table: "district",
                type: "character varying(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "address",
                table: "circuit",
                type: "character varying(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(75)");

            migrationBuilder.AddColumn<int>(
                name: "circuit_id",
                table: "circuit",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddColumn<string>(
                name: "district_name",
                table: "circuit",
                type: "character varying(30)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_district",
                table: "district",
                column: "district_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_circuit",
                table: "circuit",
                column: "circuit_id");

            migrationBuilder.CreateTable(
                name: "head_circuit",
                columns: table => new
                {
                    head_circuit_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    circuit_id = table.Column<int>(nullable: true),
                    citizen_id = table.Column<int>(nullable: false),
                    election_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_head_circuit", x => x.head_circuit_id);
                    table.ForeignKey(
                        name: "head_circuit_circuit_id_fkey",
                        column: x => x.circuit_id,
                        principalTable: "circuit",
                        principalColumn: "circuit_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "head_circuit_citizen_id_fkey",
                        column: x => x.citizen_id,
                        principalTable: "citizen",
                        principalColumn: "citizen_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "head_circuit_election_id_fkey",
                        column: x => x.election_id,
                        principalTable: "election",
                        principalColumn: "election_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "head_district",
                columns: table => new
                {
                    head_district = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    citizen_id = table.Column<int>(nullable: false),
                    district_id = table.Column<int>(nullable: true),
                    election_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_head_district", x => x.head_district);
                    table.ForeignKey(
                        name: "head_district_citizen_id_fkey",
                        column: x => x.citizen_id,
                        principalTable: "citizen",
                        principalColumn: "citizen_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "head_district_district_id_fkey",
                        column: x => x.district_id,
                        principalTable: "district",
                        principalColumn: "district_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "head_district_election_id_fkey",
                        column: x => x.election_id,
                        principalTable: "election",
                        principalColumn: "election_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_head_circuit_circuit_id",
                table: "head_circuit",
                column: "circuit_id");

            migrationBuilder.CreateIndex(
                name: "IX_head_circuit_citizen_id",
                table: "head_circuit",
                column: "citizen_id");

            migrationBuilder.CreateIndex(
                name: "IX_head_circuit_election_id",
                table: "head_circuit",
                column: "election_id");

            migrationBuilder.CreateIndex(
                name: "IX_head_district_citizen_id",
                table: "head_district",
                column: "citizen_id");

            migrationBuilder.CreateIndex(
                name: "IX_head_district_district_id",
                table: "head_district",
                column: "district_id");

            migrationBuilder.CreateIndex(
                name: "IX_head_district_election_id",
                table: "head_district",
                column: "election_id");

            migrationBuilder.AddForeignKey(
                name: "appeal_circuit_id_fkey",
                table: "appeal",
                column: "circuit_id",
                principalTable: "circuit",
                principalColumn: "circuit_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "complaint_circuit_id_fkey",
                table: "complaint",
                column: "circuit_id",
                principalTable: "circuit",
                principalColumn: "circuit_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "district_circuit_id_fkey",
                table: "district",
                column: "circuit_id",
                principalTable: "circuit",
                principalColumn: "circuit_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "observer_circuit_id_fkey",
                table: "observer",
                column: "circuit_id",
                principalTable: "circuit",
                principalColumn: "circuit_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "vote_circuit_id_fkey",
                table: "vote",
                column: "circuit_id",
                principalTable: "circuit",
                principalColumn: "circuit_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
