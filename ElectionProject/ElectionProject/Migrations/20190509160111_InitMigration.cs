using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ElectionProject.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "circuit",
                columns: table => new
                {
                    circuit_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    number = table.Column<int>(nullable: false),
                    name = table.Column<string>(type: "character varying(30)", nullable: false),
                    address = table.Column<string>(type: "character varying(30)", nullable: false),
                    district_name = table.Column<string>(type: "character varying(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_circuit", x => x.circuit_id);
                });

            migrationBuilder.CreateTable(
                name: "citizen",
                columns: table => new
                {
                    citizen_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    first_name = table.Column<string>(type: "character varying(30)", nullable: false),
                    name = table.Column<string>(type: "character varying(30)", nullable: false),
                    surname = table.Column<string>(type: "character varying(30)", nullable: false),
                    birth = table.Column<DateTime>(type: "date", nullable: false),
                    ipn = table.Column<string>(type: "character varying(12)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_citizen", x => x.citizen_id);
                });

            migrationBuilder.CreateTable(
                name: "type",
                columns: table => new
                {
                    type_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(type: "character varying(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_type", x => x.type_id);
                });

            migrationBuilder.CreateTable(
                name: "district",
                columns: table => new
                {
                    district_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    number = table.Column<int>(nullable: false),
                    name = table.Column<string>(type: "character varying(30)", nullable: false),
                    center = table.Column<string>(type: "character varying(100)", nullable: false),
                    address = table.Column<string>(type: "character varying(100)", nullable: false),
                    circuit_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_district", x => x.district_id);
                    table.ForeignKey(
                        name: "district_circuit_id_fkey",
                        column: x => x.circuit_id,
                        principalTable: "circuit",
                        principalColumn: "circuit_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "election",
                columns: table => new
                {
                    election_id = table.Column<int>(nullable: false)
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
                    table.PrimaryKey("PK_election", x => x.election_id);
                    table.ForeignKey(
                        name: "election_head_of_cvk_fkey",
                        column: x => x.head_of_cvk,
                        principalTable: "citizen",
                        principalColumn: "citizen_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "appeal",
                columns: table => new
                {
                    appeal_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    election_id = table.Column<int>(nullable: true),
                    circuit_id = table.Column<int>(nullable: true),
                    citizen_id = table.Column<int>(nullable: false),
                    type_id = table.Column<int>(nullable: false),
                    text = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appeal", x => x.appeal_id);
                    table.ForeignKey(
                        name: "appeal_circuit_id_fkey",
                        column: x => x.circuit_id,
                        principalTable: "circuit",
                        principalColumn: "circuit_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "appeal_citizen_id_fkey",
                        column: x => x.citizen_id,
                        principalTable: "citizen",
                        principalColumn: "citizen_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "appeal_election_id_fkey",
                        column: x => x.election_id,
                        principalTable: "election",
                        principalColumn: "election_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "appeal_type_id_fkey",
                        column: x => x.type_id,
                        principalTable: "type",
                        principalColumn: "type_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "candidate",
                columns: table => new
                {
                    candidate_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    number = table.Column<int>(nullable: false),
                    election_id = table.Column<int>(nullable: true),
                    citizen_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidate", x => x.candidate_id);
                    table.ForeignKey(
                        name: "candidate_citizen_id_fkey",
                        column: x => x.citizen_id,
                        principalTable: "citizen",
                        principalColumn: "citizen_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "candidate_election_id_fkey",
                        column: x => x.election_id,
                        principalTable: "election",
                        principalColumn: "election_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "head_circuit",
                columns: table => new
                {
                    head_circuit_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    election_id = table.Column<int>(nullable: true),
                    circuit_id = table.Column<int>(nullable: true),
                    citizen_id = table.Column<int>(nullable: false)
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
                    election_id = table.Column<int>(nullable: true),
                    district_id = table.Column<int>(nullable: true),
                    citizen_id = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "observer",
                columns: table => new
                {
                    observer_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    election_id = table.Column<int>(nullable: true),
                    circuit_id = table.Column<int>(nullable: true),
                    citizen_id = table.Column<int>(nullable: false),
                    candidate_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_observer", x => x.observer_id);
                    table.ForeignKey(
                        name: "observer_candidate_id_fkey",
                        column: x => x.candidate_id,
                        principalTable: "candidate",
                        principalColumn: "candidate_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "observer_circuit_id_fkey",
                        column: x => x.circuit_id,
                        principalTable: "circuit",
                        principalColumn: "circuit_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "observer_citizen_id_fkey",
                        column: x => x.citizen_id,
                        principalTable: "citizen",
                        principalColumn: "citizen_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "observer_election_id_fkey",
                        column: x => x.election_id,
                        principalTable: "election",
                        principalColumn: "election_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "vote",
                columns: table => new
                {
                    vote_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    election_id = table.Column<int>(nullable: true),
                    circuit_id = table.Column<int>(nullable: true),
                    citizen_id = table.Column<int>(nullable: false),
                    candidate_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vote", x => x.vote_id);
                    table.ForeignKey(
                        name: "vote_candidate_id_fkey",
                        column: x => x.candidate_id,
                        principalTable: "candidate",
                        principalColumn: "candidate_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "vote_circuit_id_fkey",
                        column: x => x.circuit_id,
                        principalTable: "circuit",
                        principalColumn: "circuit_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "vote_citizen_id_fkey",
                        column: x => x.citizen_id,
                        principalTable: "citizen",
                        principalColumn: "citizen_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "vote_election_id_fkey",
                        column: x => x.election_id,
                        principalTable: "election",
                        principalColumn: "election_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "complaint",
                columns: table => new
                {
                    complaint_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    election_id = table.Column<int>(nullable: true),
                    circuit_id = table.Column<int>(nullable: true),
                    observer_id = table.Column<int>(nullable: false),
                    type_id = table.Column<int>(nullable: false),
                    text = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_complaint", x => x.complaint_id);
                    table.ForeignKey(
                        name: "complaint_circuit_id_fkey",
                        column: x => x.circuit_id,
                        principalTable: "circuit",
                        principalColumn: "circuit_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "complaint_election_id_fkey",
                        column: x => x.election_id,
                        principalTable: "election",
                        principalColumn: "election_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "complaint_observer_id_fkey",
                        column: x => x.observer_id,
                        principalTable: "observer",
                        principalColumn: "observer_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "complaint_type_id_fkey",
                        column: x => x.type_id,
                        principalTable: "type",
                        principalColumn: "type_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_appeal_circuit_id",
                table: "appeal",
                column: "circuit_id");

            migrationBuilder.CreateIndex(
                name: "IX_appeal_citizen_id",
                table: "appeal",
                column: "citizen_id");

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
                name: "citizen_ipn_key",
                table: "citizen",
                column: "ipn",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_complaint_circuit_id",
                table: "complaint",
                column: "circuit_id");

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
                name: "IX_election_head_of_cvk",
                table: "election",
                column: "head_of_cvk");

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

            migrationBuilder.CreateIndex(
                name: "IX_observer_candidate_id",
                table: "observer",
                column: "candidate_id");

            migrationBuilder.CreateIndex(
                name: "IX_observer_circuit_id",
                table: "observer",
                column: "circuit_id");

            migrationBuilder.CreateIndex(
                name: "IX_observer_citizen_id",
                table: "observer",
                column: "citizen_id");

            migrationBuilder.CreateIndex(
                name: "IX_observer_election_id",
                table: "observer",
                column: "election_id");

            migrationBuilder.CreateIndex(
                name: "IX_vote_candidate_id",
                table: "vote",
                column: "candidate_id");

            migrationBuilder.CreateIndex(
                name: "IX_vote_circuit_id",
                table: "vote",
                column: "circuit_id");

            migrationBuilder.CreateIndex(
                name: "vote_citizen_id_key",
                table: "vote",
                column: "citizen_id",
                unique: true);

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
                name: "complaint");

            migrationBuilder.DropTable(
                name: "head_circuit");

            migrationBuilder.DropTable(
                name: "head_district");

            migrationBuilder.DropTable(
                name: "vote");

            migrationBuilder.DropTable(
                name: "observer");

            migrationBuilder.DropTable(
                name: "type");

            migrationBuilder.DropTable(
                name: "district");

            migrationBuilder.DropTable(
                name: "candidate");

            migrationBuilder.DropTable(
                name: "circuit");

            migrationBuilder.DropTable(
                name: "election");

            migrationBuilder.DropTable(
                name: "citizen");
        }
    }
}
