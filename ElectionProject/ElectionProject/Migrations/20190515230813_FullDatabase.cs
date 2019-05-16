using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ElectionProject.Migrations
{
    public partial class FullDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "circuit",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    name = table.Column<string>(type: "character varying(30)", nullable: false),
                    center = table.Column<string>(type: "character varying(100)", nullable: false),
                    address = table.Column<string>(type: "character varying(75)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_circuit", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "citizen",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    first_name = table.Column<string>(type: "character varying(30)", nullable: false),
                    last_name = table.Column<string>(type: "character varying(30)", nullable: false),
                    middle_name = table.Column<string>(type: "character varying(30)", nullable: false),
                    birth_date = table.Column<DateTime>(type: "date", nullable: false),
                    ipn = table.Column<string>(type: "character varying(12)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_citizen", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "type",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(type: "character varying(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "district",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    name = table.Column<string>(type: "character varying(30)", nullable: false),
                    address = table.Column<string>(type: "character varying(75)", nullable: false),
                    circuit_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_district", x => x.id);
                    table.ForeignKey(
                        name: "district_circuit_id_fkey",
                        column: x => x.circuit_id,
                        principalTable: "circuit",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "election",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(type: "character varying(30)", nullable: false),
                    year = table.Column<int>(nullable: false),
                    tour = table.Column<int>(nullable: false),
                    start_date = table.Column<DateTime>(type: "date", nullable: false),
                    end_date = table.Column<DateTime>(type: "date", nullable: false),
                    head_of_cvk = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_election", x => x.id);
                    table.ForeignKey(
                        name: "election_head_of_cvk_fkey",
                        column: x => x.head_of_cvk,
                        principalTable: "citizen",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "appeal",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    election_id = table.Column<int>(nullable: true),
                    district_id = table.Column<int>(nullable: true),
                    citizen_id = table.Column<int>(nullable: false),
                    type_id = table.Column<int>(nullable: false),
                    text = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appeal", x => x.id);
                    table.ForeignKey(
                        name: "appeal_citizen_id_fkey",
                        column: x => x.citizen_id,
                        principalTable: "citizen",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "appeal_district_id_fkey",
                        column: x => x.district_id,
                        principalTable: "district",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "appeal_election_id_fkey",
                        column: x => x.election_id,
                        principalTable: "election",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "appeal_type_id_fkey",
                        column: x => x.type_id,
                        principalTable: "type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "candidate",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    number = table.Column<int>(nullable: false),
                    election_id = table.Column<int>(nullable: true),
                    citizen_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidate", x => x.id);
                    table.ForeignKey(
                        name: "candidate_citizen_id_fkey",
                        column: x => x.citizen_id,
                        principalTable: "citizen",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "candidate_election_id_fkey",
                        column: x => x.election_id,
                        principalTable: "election",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "observer",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    election_id = table.Column<int>(nullable: true),
                    district_id = table.Column<int>(nullable: true),
                    citizen_id = table.Column<int>(nullable: false),
                    candidate_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_observer", x => x.id);
                    table.ForeignKey(
                        name: "observer_candidate_id_fkey",
                        column: x => x.candidate_id,
                        principalTable: "candidate",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "observer_citizen_id_fkey",
                        column: x => x.citizen_id,
                        principalTable: "citizen",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "observer_district_id_fkey",
                        column: x => x.district_id,
                        principalTable: "district",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "observer_election_id_fkey",
                        column: x => x.election_id,
                        principalTable: "election",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "vote",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    election_id = table.Column<int>(nullable: true),
                    district_id = table.Column<int>(nullable: true),
                    citizen_id = table.Column<int>(nullable: false),
                    candidate_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vote", x => x.id);
                    table.ForeignKey(
                        name: "vote_candidate_id_fkey",
                        column: x => x.candidate_id,
                        principalTable: "candidate",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "vote_citizen_id_fkey",
                        column: x => x.citizen_id,
                        principalTable: "citizen",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "vote_district_id_fkey",
                        column: x => x.district_id,
                        principalTable: "district",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "vote_election_id_fkey",
                        column: x => x.election_id,
                        principalTable: "election",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "complaint",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    election_id = table.Column<int>(nullable: true),
                    district_id = table.Column<int>(nullable: true),
                    observer_id = table.Column<int>(nullable: false),
                    type_id = table.Column<int>(nullable: false),
                    text = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_complaint", x => x.id);
                    table.ForeignKey(
                        name: "complaint_district_id_fkey",
                        column: x => x.district_id,
                        principalTable: "district",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "complaint_election_id_fkey",
                        column: x => x.election_id,
                        principalTable: "election",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "complaint_observer_id_fkey",
                        column: x => x.observer_id,
                        principalTable: "observer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "complaint_type_id_fkey",
                        column: x => x.type_id,
                        principalTable: "type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_appeal_citizen_id",
                table: "appeal",
                column: "citizen_id");

            migrationBuilder.CreateIndex(
                name: "IX_appeal_district_id",
                table: "appeal",
                column: "district_id");

            migrationBuilder.CreateIndex(
                name: "IX_appeal_election_id",
                table: "appeal",
                column: "election_id");

            migrationBuilder.CreateIndex(
                name: "IX_appeal_type_id",
                table: "appeal",
                column: "type_id");

            migrationBuilder.CreateIndex(
                name: "IX_candidate_citizen_id",
                table: "candidate",
                column: "citizen_id");

            migrationBuilder.CreateIndex(
                name: "IX_candidate_election_id",
                table: "candidate",
                column: "election_id");

            migrationBuilder.CreateIndex(
                name: "candidate_number_key",
                table: "candidate",
                column: "number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "circuit_address_key",
                table: "circuit",
                column: "address",
                unique: true);

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
                name: "citizen_ipn_key",
                table: "citizen",
                column: "ipn",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_complaint_district_id",
                table: "complaint",
                column: "district_id");

            migrationBuilder.CreateIndex(
                name: "IX_complaint_election_id",
                table: "complaint",
                column: "election_id");

            migrationBuilder.CreateIndex(
                name: "IX_complaint_observer_id",
                table: "complaint",
                column: "observer_id");

            migrationBuilder.CreateIndex(
                name: "IX_complaint_type_id",
                table: "complaint",
                column: "type_id");

            migrationBuilder.CreateIndex(
                name: "district_address_key",
                table: "district",
                column: "address",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_district_circuit_id",
                table: "district",
                column: "circuit_id");

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

            migrationBuilder.CreateIndex(
                name: "IX_election_head_of_cvk",
                table: "election",
                column: "head_of_cvk");

            migrationBuilder.CreateIndex(
                name: "IX_observer_candidate_id",
                table: "observer",
                column: "candidate_id");

            migrationBuilder.CreateIndex(
                name: "IX_observer_citizen_id",
                table: "observer",
                column: "citizen_id");

            migrationBuilder.CreateIndex(
                name: "IX_observer_district_id",
                table: "observer",
                column: "district_id");

            migrationBuilder.CreateIndex(
                name: "IX_observer_election_id",
                table: "observer",
                column: "election_id");

            migrationBuilder.CreateIndex(
                name: "IX_vote_candidate_id",
                table: "vote",
                column: "candidate_id");

            migrationBuilder.CreateIndex(
                name: "vote_citizen_id_key",
                table: "vote",
                column: "citizen_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_vote_district_id",
                table: "vote",
                column: "district_id");

            migrationBuilder.CreateIndex(
                name: "IX_vote_election_id",
                table: "vote",
                column: "election_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "appeal");

            migrationBuilder.DropTable(
                name: "circuit_head");

            migrationBuilder.DropTable(
                name: "complaint");

            migrationBuilder.DropTable(
                name: "district_head");

            migrationBuilder.DropTable(
                name: "vote");

            migrationBuilder.DropTable(
                name: "observer");

            migrationBuilder.DropTable(
                name: "type");

            migrationBuilder.DropTable(
                name: "candidate");

            migrationBuilder.DropTable(
                name: "district");

            migrationBuilder.DropTable(
                name: "election");

            migrationBuilder.DropTable(
                name: "circuit");

            migrationBuilder.DropTable(
                name: "citizen");
        }
    }
}
