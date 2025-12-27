using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirLineMetrics.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EntitiesConfigurationsDone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AIRCRAFT",
                columns: table => new
                {
                    AIRCRAFT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    CAPACITY = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AIRCRAFT", x => x.AIRCRAFT_ID);
                });

            migrationBuilder.CreateTable(
                name: "BAGGAGE_TYPES",
                columns: table => new
                {
                    BAGGAGE_TYPE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BAGGAGE_TYPES", x => x.BAGGAGE_TYPE_ID);
                });

            migrationBuilder.CreateTable(
                name: "CANCELLATION_REASSONS",
                columns: table => new
                {
                    CANCELLATION_REASSON_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CANCELLATION_REASSONS", x => x.CANCELLATION_REASSON_ID);
                });

            migrationBuilder.CreateTable(
                name: "COUNTRIES",
                columns: table => new
                {
                    COUNTRY_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COUNTRY_NAME = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COUNTRIES", x => x.COUNTRY_ID);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.DocumentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "PASSENGER_TYPES",
                columns: table => new
                {
                    PASSENGER_TYPE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PASSENGER_TYPES", x => x.PASSENGER_TYPE_ID);
                });

            migrationBuilder.CreateTable(
                name: "PAYMENT_METHODS",
                columns: table => new
                {
                    PAYMENT_METHOD_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAYMENT_METHODS", x => x.PAYMENT_METHOD_ID);
                });

            migrationBuilder.CreateTable(
                name: "PROMOTIONS",
                columns: table => new
                {
                    PROMOTION_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    START = table.Column<DateTime>(type: "datetime2", nullable: false),
                    END = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PROMOTION_DISCOUNT = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROMOTIONS", x => x.PROMOTION_ID);
                });

            migrationBuilder.CreateTable(
                name: "SEAT_TYPES",
                columns: table => new
                {
                    SEAT_TYPE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SEAT_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ADDED_SEAT_TYPE_PRICE = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SEAT_TYPES", x => x.SEAT_TYPE_ID);
                });

            migrationBuilder.CreateTable(
                name: "STATES",
                columns: table => new
                {
                    STATE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    STATE_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    COUNTRY_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STATES", x => x.STATE_ID);
                    table.ForeignKey(
                        name: "FK_STATES_COUNTRIES",
                        column: x => x.COUNTRY_ID,
                        principalTable: "COUNTRIES",
                        principalColumn: "COUNTRY_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AIRPORTS",
                columns: table => new
                {
                    AIRPORT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    STATE_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AIRPORTS", x => x.AIRPORT_ID);
                    table.ForeignKey(
                        name: "FK_AIRPORTS_STATES",
                        column: x => x.STATE_ID,
                        principalTable: "STATES",
                        principalColumn: "STATE_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PASSENGERS",
                columns: table => new
                {
                    PASSENGER_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SURNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    STREET = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MOBILE_NUMBER = table.Column<int>(type: "int", nullable: false),
                    IS_ACTIVE = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    DOCUMENT_TYPE_ID = table.Column<int>(type: "int", nullable: false),
                    PASSENGER_TYPE_ID = table.Column<int>(type: "int", nullable: false),
                    STATE_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PASSENGERS", x => x.PASSENGER_ID);
                    table.ForeignKey(
                        name: "FK_PASSENGERS_DOCUMENT_TYPES",
                        column: x => x.DOCUMENT_TYPE_ID,
                        principalTable: "DocumentTypes",
                        principalColumn: "DocumentTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PASSENGERS_PASSENGER_TYPES",
                        column: x => x.PASSENGER_TYPE_ID,
                        principalTable: "PASSENGER_TYPES",
                        principalColumn: "PASSENGER_TYPE_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PASSENGERS_STATES",
                        column: x => x.STATE_ID,
                        principalTable: "STATES",
                        principalColumn: "STATE_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    FLIGHT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FLIGHT_CODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SCHEDULED_DEPARTURE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SCHEDULED_ARRIVAL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ACTUAL_DEPARTURE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ACTUAL_ARRIVAL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IS_DELETED = table.Column<bool>(type: "bit", nullable: false),
                    AIRCRAFT_ID = table.Column<int>(type: "int", nullable: false),
                    ORIGINAL_AIRPORT_ID = table.Column<int>(type: "int", nullable: false),
                    DESTINATION_AIRPORT_ID = table.Column<int>(type: "int", nullable: false),
                    STATE_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.FLIGHT_ID);
                    table.ForeignKey(
                        name: "FK_FLIGHTS_AIRCRAFTS",
                        column: x => x.AIRCRAFT_ID,
                        principalTable: "AIRCRAFT",
                        principalColumn: "AIRCRAFT_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FLIGHTS_AIRPORTS_DESTINATION",
                        column: x => x.DESTINATION_AIRPORT_ID,
                        principalTable: "AIRPORTS",
                        principalColumn: "AIRPORT_ID");
                    table.ForeignKey(
                        name: "FK_FLIGHTS_AIRPORTS_ORIGIN",
                        column: x => x.ORIGINAL_AIRPORT_ID,
                        principalTable: "AIRPORTS",
                        principalColumn: "AIRPORT_ID");
                    table.ForeignKey(
                        name: "FK_FLIGHTS_STATES",
                        column: x => x.STATE_ID,
                        principalTable: "STATES",
                        principalColumn: "STATE_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "INVOICES",
                columns: table => new
                {
                    INVOICE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PASSENGER_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INVOICES", x => x.INVOICE_ID);
                    table.ForeignKey(
                        name: "FK_INVOICES_PASSENGERS",
                        column: x => x.PASSENGER_ID,
                        principalTable: "PASSENGERS",
                        principalColumn: "PASSENGER_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FlightDetails",
                columns: table => new
                {
                    FLIGHT_DETAIL_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PRICE = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IS_CANCELLED = table.Column<bool>(type: "bit", nullable: false),
                    PASSENGER_ID = table.Column<int>(type: "int", nullable: false),
                    FLIGHT_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightDetails", x => x.FLIGHT_DETAIL_ID);
                    table.ForeignKey(
                        name: "FK_FLIGHT_DETAILS_FLIGTHS",
                        column: x => x.FLIGHT_ID,
                        principalTable: "Flights",
                        principalColumn: "FLIGHT_ID");
                    table.ForeignKey(
                        name: "FK_FLIGHT_DETAILS_PASSENGERS",
                        column: x => x.PASSENGER_ID,
                        principalTable: "PASSENGERS",
                        principalColumn: "PASSENGER_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FLIGHTS_PROMOTIONS",
                columns: table => new
                {
                    FLIGHT_PROMOTION_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROMOTION_ID = table.Column<int>(type: "int", nullable: false),
                    FLIGHT_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FLIGHTS_PROMOTIONS", x => x.FLIGHT_PROMOTION_ID);
                    table.ForeignKey(
                        name: "FK_FLIGHTS_PROMOTIONS_FLIGHTS",
                        column: x => x.FLIGHT_ID,
                        principalTable: "Flights",
                        principalColumn: "FLIGHT_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FLIGHT_PROMOTIONS_PROMOTIONS",
                        column: x => x.PROMOTION_ID,
                        principalTable: "PROMOTIONS",
                        principalColumn: "PROMOTION_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OPERATIONAL_COSTS",
                columns: table => new
                {
                    OPERATIONAL_COST_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FUEL_COST = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    MAINTENANCE_COST = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    CREW_COST = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    AIRPORT_FEES = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    OPERATIONAL_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FLIGHT_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPERATIONAL_COSTS", x => x.OPERATIONAL_COST_ID);
                    table.ForeignKey(
                        name: "FK_OPERATIONAL_COSTS_FLIGHTS",
                        column: x => x.FLIGHT_ID,
                        principalTable: "Flights",
                        principalColumn: "FLIGHT_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "INVOICE_PAYMENTS",
                columns: table => new
                {
                    PAYMENT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AMOUNT = table.Column<double>(type: "float", nullable: false),
                    PAYMENT_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PAYMENT_METHOD_ID = table.Column<int>(type: "int", nullable: false),
                    INVOICE_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INVOICE_PAYMENTS", x => x.PAYMENT_ID);
                    table.ForeignKey(
                        name: "FK_INVOICE_PAYMENT_INVOICE_ID",
                        column: x => x.INVOICE_ID,
                        principalTable: "INVOICES",
                        principalColumn: "INVOICE_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_INVOICE_PAYMENT_PAYMENTE_METHOD_ID",
                        column: x => x.PAYMENT_METHOD_ID,
                        principalTable: "PAYMENT_METHODS",
                        principalColumn: "PAYMENT_METHOD_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BAGGAGES",
                columns: table => new
                {
                    BAGGAGE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRICE = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    WEIGHT = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    BAGGAGE_TYPE_ID = table.Column<int>(type: "int", nullable: false),
                    FLIGHT_DETAIL_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BAGGAGES", x => x.BAGGAGE_ID);
                    table.ForeignKey(
                        name: "FK_BAGGAGE_BAGGAGE_TYPE",
                        column: x => x.BAGGAGE_TYPE_ID,
                        principalTable: "BAGGAGE_TYPES",
                        principalColumn: "BAGGAGE_TYPE_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BAGGAGE_FLIGHT_DETAILS",
                        column: x => x.FLIGHT_DETAIL_ID,
                        principalTable: "FlightDetails",
                        principalColumn: "FLIGHT_DETAIL_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "INVOICE_DETAILS",
                columns: table => new
                {
                    INVOICE_DETAIL_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRICE = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    INVOICE_ID = table.Column<int>(type: "int", nullable: false),
                    FLIGHT_DETAIL_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INVOICE_DETAILS", x => x.INVOICE_DETAIL_ID);
                    table.ForeignKey(
                        name: "FK_INVOICE_DETAILS_FLIGHT_DETAILS",
                        column: x => x.FLIGHT_DETAIL_ID,
                        principalTable: "FlightDetails",
                        principalColumn: "FLIGHT_DETAIL_ID");
                    table.ForeignKey(
                        name: "FK_INVOICE_DETAILS_INVOICES",
                        column: x => x.INVOICE_ID,
                        principalTable: "INVOICES",
                        principalColumn: "INVOICE_ID");
                });

            migrationBuilder.CreateTable(
                name: "SEATS",
                columns: table => new
                {
                    SEAT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SEAT_NUMBER = table.Column<int>(type: "int", nullable: false),
                    IS_BUSY = table.Column<bool>(type: "bit", nullable: false),
                    SEAT_TYPE_ID = table.Column<int>(type: "int", nullable: false),
                    FLIGHT_DETAIL_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SEATS", x => x.SEAT_ID);
                    table.ForeignKey(
                        name: "FK_SEAT_RESERVATIONS_FLIGHT_DETAILS",
                        column: x => x.FLIGHT_DETAIL_ID,
                        principalTable: "FlightDetails",
                        principalColumn: "FLIGHT_DETAIL_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SEAT_RESERVATIONS_SEAT_TYPES",
                        column: x => x.SEAT_TYPE_ID,
                        principalTable: "SEAT_TYPES",
                        principalColumn: "SEAT_TYPE_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PURCHASE_CANCELLATIONS",
                columns: table => new
                {
                    CANCELLATION_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REFOUND_AMOUNT = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SATISFACTION_ESTIMATED = table.Column<int>(type: "int", nullable: false),
                    CANCELLATION_REASSON_ID = table.Column<int>(type: "int", nullable: false),
                    INVOICE_DETAIL_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PURCHASE_CANCELLATIONS", x => x.CANCELLATION_ID);
                    table.ForeignKey(
                        name: "FK_PURCHASE_CANCELLATIONS_CANCELLATION_REASONS",
                        column: x => x.CANCELLATION_REASSON_ID,
                        principalTable: "CANCELLATION_REASSONS",
                        principalColumn: "CANCELLATION_REASSON_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PURCHASE_CANCELLATIONS_INVOICE_DETAILS",
                        column: x => x.INVOICE_DETAIL_ID,
                        principalTable: "INVOICE_DETAILS",
                        principalColumn: "INVOICE_DETAIL_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AIRPORTS_STATE_ID",
                table: "AIRPORTS",
                column: "STATE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_BAGGAGES_BAGGAGE_TYPE_ID",
                table: "BAGGAGES",
                column: "BAGGAGE_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_BAGGAGES_FLIGHT_DETAIL_ID",
                table: "BAGGAGES",
                column: "FLIGHT_DETAIL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FlightDetails_FLIGHT_ID",
                table: "FlightDetails",
                column: "FLIGHT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FlightDetails_PASSENGER_ID",
                table: "FlightDetails",
                column: "PASSENGER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_AIRCRAFT_ID",
                table: "Flights",
                column: "AIRCRAFT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_DESTINATION_AIRPORT_ID",
                table: "Flights",
                column: "DESTINATION_AIRPORT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_ORIGINAL_AIRPORT_ID",
                table: "Flights",
                column: "ORIGINAL_AIRPORT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_STATE_ID",
                table: "Flights",
                column: "STATE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FLIGHTS_PROMOTIONS_FLIGHT_ID",
                table: "FLIGHTS_PROMOTIONS",
                column: "FLIGHT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_FLIGHTS_PROMOTIONS_PROMOTION_ID",
                table: "FLIGHTS_PROMOTIONS",
                column: "PROMOTION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INVOICE_DETAILS_FLIGHT_DETAIL_ID",
                table: "INVOICE_DETAILS",
                column: "FLIGHT_DETAIL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INVOICE_DETAILS_INVOICE_ID",
                table: "INVOICE_DETAILS",
                column: "INVOICE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INVOICE_PAYMENTS_INVOICE_ID",
                table: "INVOICE_PAYMENTS",
                column: "INVOICE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INVOICE_PAYMENTS_PAYMENT_METHOD_ID",
                table: "INVOICE_PAYMENTS",
                column: "PAYMENT_METHOD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INVOICES_PASSENGER_ID",
                table: "INVOICES",
                column: "PASSENGER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_OPERATIONAL_COSTS_FLIGHT_ID",
                table: "OPERATIONAL_COSTS",
                column: "FLIGHT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PASSENGERS_DOCUMENT_TYPE_ID",
                table: "PASSENGERS",
                column: "DOCUMENT_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PASSENGERS_PASSENGER_TYPE_ID",
                table: "PASSENGERS",
                column: "PASSENGER_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PASSENGERS_STATE_ID",
                table: "PASSENGERS",
                column: "STATE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PURCHASE_CANCELLATIONS_CANCELLATION_REASSON_ID",
                table: "PURCHASE_CANCELLATIONS",
                column: "CANCELLATION_REASSON_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PURCHASE_CANCELLATIONS_INVOICE_DETAIL_ID",
                table: "PURCHASE_CANCELLATIONS",
                column: "INVOICE_DETAIL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SEATS_FLIGHT_DETAIL_ID",
                table: "SEATS",
                column: "FLIGHT_DETAIL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SEATS_SEAT_TYPE_ID",
                table: "SEATS",
                column: "SEAT_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_STATES_COUNTRY_ID",
                table: "STATES",
                column: "COUNTRY_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BAGGAGES");

            migrationBuilder.DropTable(
                name: "FLIGHTS_PROMOTIONS");

            migrationBuilder.DropTable(
                name: "INVOICE_PAYMENTS");

            migrationBuilder.DropTable(
                name: "OPERATIONAL_COSTS");

            migrationBuilder.DropTable(
                name: "PURCHASE_CANCELLATIONS");

            migrationBuilder.DropTable(
                name: "SEATS");

            migrationBuilder.DropTable(
                name: "BAGGAGE_TYPES");

            migrationBuilder.DropTable(
                name: "PROMOTIONS");

            migrationBuilder.DropTable(
                name: "PAYMENT_METHODS");

            migrationBuilder.DropTable(
                name: "CANCELLATION_REASSONS");

            migrationBuilder.DropTable(
                name: "INVOICE_DETAILS");

            migrationBuilder.DropTable(
                name: "SEAT_TYPES");

            migrationBuilder.DropTable(
                name: "FlightDetails");

            migrationBuilder.DropTable(
                name: "INVOICES");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "PASSENGERS");

            migrationBuilder.DropTable(
                name: "AIRCRAFT");

            migrationBuilder.DropTable(
                name: "AIRPORTS");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "PASSENGER_TYPES");

            migrationBuilder.DropTable(
                name: "STATES");

            migrationBuilder.DropTable(
                name: "COUNTRIES");
        }
    }
}
