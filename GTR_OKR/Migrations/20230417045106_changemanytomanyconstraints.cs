using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GTR_OKR.Migrations
{
    /// <inheritdoc />
    public partial class changemanytomanyconstraints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Templates_TempId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_projTempRelations_Projects_PId",
                table: "projTempRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_projTempRelations_Templates_TempId",
                table: "projTempRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_Templates_Templates_TemplateId",
                table: "Templates");

            migrationBuilder.DropForeignKey(
                name: "FK_Templates_Users_User",
                table: "Templates");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProjectAssigns_Projects_PId",
                table: "UserProjectAssigns");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProjectAssigns_Users_UserId",
                table: "UserProjectAssigns");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTaskAssigns_Tasks_TaskId",
                table: "UserTaskAssigns");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTaskAssigns_Users_UserId",
                table: "UserTaskAssigns");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTempAssigns_Templates_TempId",
                table: "UserTempAssigns");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTempAssigns_Users_UserId",
                table: "UserTempAssigns");

            migrationBuilder.DropIndex(
                name: "IX_Templates_TemplateId",
                table: "Templates");

            migrationBuilder.DropIndex(
                name: "IX_Templates_User",
                table: "Templates");

            migrationBuilder.DropIndex(
                name: "IX_Projects_TempId",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTempAssigns",
                table: "UserTempAssigns");

            migrationBuilder.DropIndex(
                name: "IX_UserTempAssigns_TempId",
                table: "UserTempAssigns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTaskAssigns",
                table: "UserTaskAssigns");

            migrationBuilder.DropIndex(
                name: "IX_UserTaskAssigns_TaskId",
                table: "UserTaskAssigns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserProjectAssigns",
                table: "UserProjectAssigns");

            migrationBuilder.DropIndex(
                name: "IX_UserProjectAssigns_PId",
                table: "UserProjectAssigns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_projTempRelations",
                table: "projTempRelations");

            migrationBuilder.DropIndex(
                name: "IX_projTempRelations_PId",
                table: "projTempRelations");

            migrationBuilder.DropColumn(
                name: "TemplateId",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "User",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserTempAssigns");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserTaskAssigns");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserProjectAssigns");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "projTempRelations");

            migrationBuilder.RenameTable(
                name: "UserTempAssigns",
                newName: "UserTempAssign");

            migrationBuilder.RenameTable(
                name: "UserTaskAssigns",
                newName: "UserTaskAssign");

            migrationBuilder.RenameTable(
                name: "UserProjectAssigns",
                newName: "UserProjectAssign");

            migrationBuilder.RenameTable(
                name: "projTempRelations",
                newName: "ProjTempRelation");

            migrationBuilder.RenameIndex(
                name: "IX_UserTempAssigns_UserId",
                table: "UserTempAssign",
                newName: "IX_UserTempAssign_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTaskAssigns_UserId",
                table: "UserTaskAssign",
                newName: "IX_UserTaskAssign_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserProjectAssigns_UserId",
                table: "UserProjectAssign",
                newName: "IX_UserProjectAssign_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_projTempRelations_TempId",
                table: "ProjTempRelation",
                newName: "IX_ProjTempRelation_TempId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTempAssign",
                table: "UserTempAssign",
                columns: new[] { "TempId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTaskAssign",
                table: "UserTaskAssign",
                columns: new[] { "TaskId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserProjectAssign",
                table: "UserProjectAssign",
                columns: new[] { "PId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjTempRelation",
                table: "ProjTempRelation",
                columns: new[] { "PId", "TempId" });

            migrationBuilder.CreateIndex(
                name: "IX_Templates_OwnerId",
                table: "Templates",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjTempRelation_Projects_TempId",
                table: "ProjTempRelation",
                column: "TempId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjTempRelation_Templates_PId",
                table: "ProjTempRelation",
                column: "PId",
                principalTable: "Templates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Templates_Users_OwnerId",
                table: "Templates",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProjectAssign_Projects_UserId",
                table: "UserProjectAssign",
                column: "UserId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProjectAssign_Users_PId",
                table: "UserProjectAssign",
                column: "PId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTaskAssign_Tasks_UserId",
                table: "UserTaskAssign",
                column: "UserId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTaskAssign_Users_TaskId",
                table: "UserTaskAssign",
                column: "TaskId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTempAssign_Templates_UserId",
                table: "UserTempAssign",
                column: "UserId",
                principalTable: "Templates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTempAssign_Users_TempId",
                table: "UserTempAssign",
                column: "TempId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjTempRelation_Projects_TempId",
                table: "ProjTempRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjTempRelation_Templates_PId",
                table: "ProjTempRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_Templates_Users_OwnerId",
                table: "Templates");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProjectAssign_Projects_UserId",
                table: "UserProjectAssign");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProjectAssign_Users_PId",
                table: "UserProjectAssign");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTaskAssign_Tasks_UserId",
                table: "UserTaskAssign");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTaskAssign_Users_TaskId",
                table: "UserTaskAssign");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTempAssign_Templates_UserId",
                table: "UserTempAssign");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTempAssign_Users_TempId",
                table: "UserTempAssign");

            migrationBuilder.DropIndex(
                name: "IX_Templates_OwnerId",
                table: "Templates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTempAssign",
                table: "UserTempAssign");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTaskAssign",
                table: "UserTaskAssign");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserProjectAssign",
                table: "UserProjectAssign");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjTempRelation",
                table: "ProjTempRelation");

            migrationBuilder.RenameTable(
                name: "UserTempAssign",
                newName: "UserTempAssigns");

            migrationBuilder.RenameTable(
                name: "UserTaskAssign",
                newName: "UserTaskAssigns");

            migrationBuilder.RenameTable(
                name: "UserProjectAssign",
                newName: "UserProjectAssigns");

            migrationBuilder.RenameTable(
                name: "ProjTempRelation",
                newName: "projTempRelations");

            migrationBuilder.RenameIndex(
                name: "IX_UserTempAssign_UserId",
                table: "UserTempAssigns",
                newName: "IX_UserTempAssigns_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTaskAssign_UserId",
                table: "UserTaskAssigns",
                newName: "IX_UserTaskAssigns_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserProjectAssign_UserId",
                table: "UserProjectAssigns",
                newName: "IX_UserProjectAssigns_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ProjTempRelation_TempId",
                table: "projTempRelations",
                newName: "IX_projTempRelations_TempId");

            migrationBuilder.AddColumn<int>(
                name: "TemplateId",
                table: "Templates",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "User",
                table: "Templates",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "UserTempAssigns",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "UserTaskAssigns",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "UserProjectAssigns",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "projTempRelations",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTempAssigns",
                table: "UserTempAssigns",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTaskAssigns",
                table: "UserTaskAssigns",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserProjectAssigns",
                table: "UserProjectAssigns",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_projTempRelations",
                table: "projTempRelations",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Templates_TemplateId",
                table: "Templates",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Templates_User",
                table: "Templates",
                column: "User");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_TempId",
                table: "Projects",
                column: "TempId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTempAssigns_TempId",
                table: "UserTempAssigns",
                column: "TempId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTaskAssigns_TaskId",
                table: "UserTaskAssigns",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProjectAssigns_PId",
                table: "UserProjectAssigns",
                column: "PId");

            migrationBuilder.CreateIndex(
                name: "IX_projTempRelations_PId",
                table: "projTempRelations",
                column: "PId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Templates_TempId",
                table: "Projects",
                column: "TempId",
                principalTable: "Templates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_projTempRelations_Projects_PId",
                table: "projTempRelations",
                column: "PId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_projTempRelations_Templates_TempId",
                table: "projTempRelations",
                column: "TempId",
                principalTable: "Templates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Templates_Templates_TemplateId",
                table: "Templates",
                column: "TemplateId",
                principalTable: "Templates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Templates_Users_User",
                table: "Templates",
                column: "User",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProjectAssigns_Projects_PId",
                table: "UserProjectAssigns",
                column: "PId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProjectAssigns_Users_UserId",
                table: "UserProjectAssigns",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTaskAssigns_Tasks_TaskId",
                table: "UserTaskAssigns",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTaskAssigns_Users_UserId",
                table: "UserTaskAssigns",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTempAssigns_Templates_TempId",
                table: "UserTempAssigns",
                column: "TempId",
                principalTable: "Templates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTempAssigns_Users_UserId",
                table: "UserTempAssigns",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
