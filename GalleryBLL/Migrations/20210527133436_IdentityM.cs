using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GalleryDAL.Migrations
{
    public partial class IdentityM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "countries",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('countries_id_country_seq'::regclass)"),
                    name = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "exhibitions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('exhibitions_id_exh_seq'::regclass)"),
                    name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    price = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exhibitions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "news",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying", nullable: true),
                    description = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_news", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "owners",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('owners_id_owner_seq'::regclass)"),
                    surname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    last_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    telephone = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    bank_acc = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_owners", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "techniques",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('techniques_id_technique_seq'::regclass)"),
                    name = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    paint = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    @base = table.Column<string>(name: "base", type: "character varying(10)", maxLength: 10, nullable: false),
                    picUrl = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_techniques", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cities",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('cities_id_city_seq'::regclass)"),
                    name = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    id_country = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cities", x => x.id);
                    table.ForeignKey(
                        name: "cities_id_country_fkey",
                        column: x => x.id_country,
                        principalTable: "countries",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "artists",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('artists_id_artist_seq'::regclass)"),
                    name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    last_name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    bday = table.Column<DateTime>(type: "date", nullable: false),
                    death = table.Column<DateTime>(type: "date", nullable: true),
                    art_direction = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    telephone = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_city = table.Column<int>(type: "integer", nullable: true),
                    surname = table.Column<string>(type: "character varying", nullable: true),
                    url = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    add_info = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_artists", x => x.id);
                    table.ForeignKey(
                        name: "artists_id_city_fkey",
                        column: x => x.id_city,
                        principalTable: "cities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('employees_id_employee_seq'::regclass)"),
                    surname = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    name = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    last_name = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    bday = table.Column<DateTime>(type: "date", nullable: true),
                    job = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    telephone = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    id_city = table.Column<int>(type: "integer", nullable: false),
                    add_info = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.id);
                    table.ForeignKey(
                        name: "employees_id_city_fkey",
                        column: x => x.id_city,
                        principalTable: "cities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "exhibit_places",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('exhibit_places_id_exh_place_seq'::regclass)"),
                    name = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    telephone = table.Column<int>(type: "integer", nullable: true),
                    id_city = table.Column<int>(type: "integer", nullable: false),
                    description = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exhibit_places", x => x.id);
                    table.ForeignKey(
                        name: "exhibit_places_id_city_fkey",
                        column: x => x.id_city,
                        principalTable: "cities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "pictures",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('pictures_id_picture_seq'::regclass)"),
                    name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    create_date = table.Column<DateTime>(type: "date", nullable: false),
                    price = table.Column<int>(type: "integer", nullable: false),
                    genre = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    add_info = table.Column<string>(type: "text", nullable: true),
                    id_artist = table.Column<int>(type: "integer", nullable: false),
                    id_technique = table.Column<int>(type: "integer", nullable: false),
                    url = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pictures", x => x.id);
                    table.ForeignKey(
                        name: "pictures_id_artist_fkey",
                        column: x => x.id_artist,
                        principalTable: "artists",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "pictures_id_technique_fkey",
                        column: x => x.id_technique,
                        principalTable: "techniques",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "current_exhibitions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('current_exhibitions_id_curr_exh_seq'::regclass)"),
                    id_employee = table.Column<int>(type: "integer", nullable: false),
                    id_exh = table.Column<int>(type: "integer", nullable: false),
                    id_exh_place = table.Column<int>(type: "integer", nullable: false),
                    date_begin = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "now()"),
                    date_end = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_current_exhibitions", x => x.id);
                    table.ForeignKey(
                        name: "current_exhibitions_id_employee_fkey",
                        column: x => x.id_employee,
                        principalTable: "employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "current_exhibitions_id_exh_fkey",
                        column: x => x.id_exh,
                        principalTable: "exhibitions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "current_exhibitions_id_exh_place_fkey",
                        column: x => x.id_exh_place,
                        principalTable: "exhibit_places",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "owned_pictures",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('owned_pictures_id_owned_picture_seq'::regclass)"),
                    id_owner = table.Column<int>(type: "integer", nullable: true),
                    id_picture = table.Column<int>(type: "integer", nullable: false),
                    buy_date = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_owned_pictures", x => x.id);
                    table.ForeignKey(
                        name: "owned_pictures_id_owner_fkey",
                        column: x => x.id_owner,
                        principalTable: "owners",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "owned_pictures_id_picture_fkey",
                        column: x => x.id_picture,
                        principalTable: "pictures",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "exhibited_pictures",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('exhibited_pictures_id_exh_pic_seq'::regclass)"),
                    id_curr_exh = table.Column<int>(type: "integer", nullable: false),
                    id_picture = table.Column<int>(type: "integer", nullable: false),
                    room = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exhibited_pictures", x => x.id);
                    table.ForeignKey(
                        name: "exhibited_pictures_id_curr_exh_fkey",
                        column: x => x.id_curr_exh,
                        principalTable: "current_exhibitions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "exhibited_pictures_id_picture_fkey",
                        column: x => x.id_picture,
                        principalTable: "pictures",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('tickets_id_ticket_seq'::regclass)"),
                    buy_date = table.Column<DateTime>(type: "date", nullable: false),
                    curExhId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.id);
                    table.ForeignKey(
                        name: "tickets_current_exhibitions_id_fk",
                        column: x => x.curExhId,
                        principalTable: "current_exhibitions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tickets_in_cart",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('ticket_in_cart_id_seq'::regclass)"),
                    ticketId = table.Column<int>(type: "integer", nullable: true),
                    totalPrice = table.Column<int>(type: "integer", nullable: true),
                    quantity = table.Column<int>(type: "integer", nullable: true),
                    CartId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets_in_cart", x => x.id);
                    table.ForeignKey(
                        name: "ticket_in_cart___fk_ticket",
                        column: x => x.ticketId,
                        principalTable: "tickets",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "artists_telephone_key",
                table: "artists",
                column: "telephone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_artists_id_city",
                table: "artists",
                column: "id_city");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cities_id_country",
                table: "cities",
                column: "id_country");

            migrationBuilder.CreateIndex(
                name: "countries_name_key",
                table: "countries",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_current_exhibitions_id_employee",
                table: "current_exhibitions",
                column: "id_employee");

            migrationBuilder.CreateIndex(
                name: "IX_current_exhibitions_id_exh",
                table: "current_exhibitions",
                column: "id_exh");

            migrationBuilder.CreateIndex(
                name: "IX_current_exhibitions_id_exh_place",
                table: "current_exhibitions",
                column: "id_exh_place");

            migrationBuilder.CreateIndex(
                name: "employees_telephone_key",
                table: "employees",
                column: "telephone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_employees_id_city",
                table: "employees",
                column: "id_city");

            migrationBuilder.CreateIndex(
                name: "IX_exhibit_places_id_city",
                table: "exhibit_places",
                column: "id_city");

            migrationBuilder.CreateIndex(
                name: "IX_exhibited_pictures_id_curr_exh",
                table: "exhibited_pictures",
                column: "id_curr_exh");

            migrationBuilder.CreateIndex(
                name: "IX_exhibited_pictures_id_picture",
                table: "exhibited_pictures",
                column: "id_picture");

            migrationBuilder.CreateIndex(
                name: "news_id_uindex",
                table: "news",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_owned_pictures_id_owner",
                table: "owned_pictures",
                column: "id_owner");

            migrationBuilder.CreateIndex(
                name: "owned_pictures_id_picture_key",
                table: "owned_pictures",
                column: "id_picture",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "owners_bank_acc_key",
                table: "owners",
                column: "bank_acc",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "owners_telephone_key",
                table: "owners",
                column: "telephone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_pictures_id_artist",
                table: "pictures",
                column: "id_artist");

            migrationBuilder.CreateIndex(
                name: "IX_pictures_id_technique",
                table: "pictures",
                column: "id_technique");

            migrationBuilder.CreateIndex(
                name: "techniques_name_key",
                table: "techniques",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tickets_curExhId",
                table: "tickets",
                column: "curExhId");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_in_cart_ticketId",
                table: "tickets_in_cart",
                column: "ticketId");

            migrationBuilder.CreateIndex(
                name: "ticket_in_cart_id_uindex",
                table: "tickets_in_cart",
                column: "id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "exhibited_pictures");

            migrationBuilder.DropTable(
                name: "news");

            migrationBuilder.DropTable(
                name: "owned_pictures");

            migrationBuilder.DropTable(
                name: "tickets_in_cart");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "owners");

            migrationBuilder.DropTable(
                name: "pictures");

            migrationBuilder.DropTable(
                name: "tickets");

            migrationBuilder.DropTable(
                name: "artists");

            migrationBuilder.DropTable(
                name: "techniques");

            migrationBuilder.DropTable(
                name: "current_exhibitions");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "exhibitions");

            migrationBuilder.DropTable(
                name: "exhibit_places");

            migrationBuilder.DropTable(
                name: "cities");

            migrationBuilder.DropTable(
                name: "countries");
        }
    }
}
