using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GTR_OKR.Migrations
{
    /// <inheritdoc />
    public partial class initializing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Understandings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Question = table.Column<string>(type: "text", nullable: false),
                    Answer = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Understandings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CompanyName = table.Column<string>(type: "text", nullable: false),
                    ComId = table.Column<string>(type: "text", nullable: false),
                    ComAdminId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DepartmentName = table.Column<string>(type: "text", nullable: false),
                    ComId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_Companies_ComId",
                        column: x => x.ComId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    DeptId = table.Column<int>(type: "integer", nullable: false),
                    ComId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Companies_ComId",
                        column: x => x.ComId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Departments_DeptId",
                        column: x => x.DeptId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Templates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    OwnerId = table.Column<int>(type: "integer", nullable: false),
                    User = table.Column<int>(type: "integer", nullable: false),
                    TemplateId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Templates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Templates_Templates_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "Templates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Templates_Users_User",
                        column: x => x.User,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DueDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EstDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Progress = table.Column<int>(type: "integer", nullable: false),
                    Tags = table.Column<List<string>>(type: "text[]", nullable: false),
                    ComId = table.Column<int>(type: "integer", nullable: false),
                    OwnerId = table.Column<int>(type: "integer", nullable: false),
                    TempId = table.Column<int>(type: "integer", nullable: false),
                    UndId = table.Column<int>(type: "integer", nullable: false),
                    DeptId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Companies_ComId",
                        column: x => x.ComId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projects_Departments_DeptId",
                        column: x => x.DeptId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projects_Templates_TempId",
                        column: x => x.TempId,
                        principalTable: "Templates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projects_Understandings_UndId",
                        column: x => x.UndId,
                        principalTable: "Understandings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projects_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTempAssigns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TempId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTempAssigns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTempAssigns_Templates_TempId",
                        column: x => x.TempId,
                        principalTable: "Templates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTempAssigns_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "projTempRelations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PId = table.Column<int>(type: "integer", nullable: false),
                    TempId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projTempRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_projTempRelations_Projects_PId",
                        column: x => x.PId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_projTempRelations_Templates_TempId",
                        column: x => x.TempId,
                        principalTable: "Templates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    PId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DueDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EstimatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TempId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Projects_PId",
                        column: x => x.PId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_Templates_TempId",
                        column: x => x.TempId,
                        principalTable: "Templates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserProjectAssigns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProjectAssigns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProjectAssigns_Projects_PId",
                        column: x => x.PId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProjectAssigns_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTaskAssigns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TaskId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTaskAssigns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTaskAssigns_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTaskAssigns_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ComAdminId",
                table: "Companies",
                column: "ComAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ComId",
                table: "Departments",
                column: "ComId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ComId",
                table: "Projects",
                column: "ComId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_DeptId",
                table: "Projects",
                column: "DeptId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_OwnerId",
                table: "Projects",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_TempId",
                table: "Projects",
                column: "TempId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_UndId",
                table: "Projects",
                column: "UndId");

            migrationBuilder.CreateIndex(
                name: "IX_projTempRelations_PId",
                table: "projTempRelations",
                column: "PId");

            migrationBuilder.CreateIndex(
                name: "IX_projTempRelations_TempId",
                table: "projTempRelations",
                column: "TempId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_PId",
                table: "Tasks",
                column: "PId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TempId",
                table: "Tasks",
                column: "TempId");

            migrationBuilder.CreateIndex(
                name: "IX_Templates_TemplateId",
                table: "Templates",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Templates_User",
                table: "Templates",
                column: "User");

            migrationBuilder.CreateIndex(
                name: "IX_UserProjectAssigns_PId",
                table: "UserProjectAssigns",
                column: "PId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProjectAssigns_UserId",
                table: "UserProjectAssigns",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ComId",
                table: "Users",
                column: "ComId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DeptId",
                table: "Users",
                column: "DeptId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTaskAssigns_TaskId",
                table: "UserTaskAssigns",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTaskAssigns_UserId",
                table: "UserTaskAssigns",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTempAssigns_TempId",
                table: "UserTempAssigns",
                column: "TempId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTempAssigns_UserId",
                table: "UserTempAssigns",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Users_ComAdminId",
                table: "Companies",
                column: "ComAdminId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Users_ComAdminId",
                table: "Companies");

            migrationBuilder.DropTable(
                name: "projTempRelations");

            migrationBuilder.DropTable(
                name: "UserProjectAssigns");

            migrationBuilder.DropTable(
                name: "UserTaskAssigns");

            migrationBuilder.DropTable(
                name: "UserTempAssigns");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Templates");

            migrationBuilder.DropTable(
                name: "Understandings");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
