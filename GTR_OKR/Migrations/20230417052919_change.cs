using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GTR_OKR.Migrations
{
    /// <inheritdoc />
    public partial class change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjTempRelation_Projects_TempId",
                table: "ProjTempRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjTempRelation_Templates_PId",
                table: "ProjTempRelation");

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
                newName: "ProjTempRelations");

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
                table: "ProjTempRelations",
                newName: "IX_ProjTempRelations_TempId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTempAssigns",
                table: "UserTempAssigns",
                columns: new[] { "TempId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTaskAssigns",
                table: "UserTaskAssigns",
                columns: new[] { "TaskId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserProjectAssigns",
                table: "UserProjectAssigns",
                columns: new[] { "PId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjTempRelations",
                table: "ProjTempRelations",
                columns: new[] { "PId", "TempId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProjTempRelations_Projects_TempId",
                table: "ProjTempRelations",
                column: "TempId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjTempRelations_Templates_PId",
                table: "ProjTempRelations",
                column: "PId",
                principalTable: "Templates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProjectAssigns_Projects_UserId",
                table: "UserProjectAssigns",
                column: "UserId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProjectAssigns_Users_PId",
                table: "UserProjectAssigns",
                column: "PId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTaskAssigns_Tasks_UserId",
                table: "UserTaskAssigns",
                column: "UserId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTaskAssigns_Users_TaskId",
                table: "UserTaskAssigns",
                column: "TaskId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTempAssigns_Templates_UserId",
                table: "UserTempAssigns",
                column: "UserId",
                principalTable: "Templates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTempAssigns_Users_TempId",
                table: "UserTempAssigns",
                column: "TempId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjTempRelations_Projects_TempId",
                table: "ProjTempRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjTempRelations_Templates_PId",
                table: "ProjTempRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProjectAssigns_Projects_UserId",
                table: "UserProjectAssigns");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProjectAssigns_Users_PId",
                table: "UserProjectAssigns");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTaskAssigns_Tasks_UserId",
                table: "UserTaskAssigns");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTaskAssigns_Users_TaskId",
                table: "UserTaskAssigns");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTempAssigns_Templates_UserId",
                table: "UserTempAssigns");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTempAssigns_Users_TempId",
                table: "UserTempAssigns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTempAssigns",
                table: "UserTempAssigns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTaskAssigns",
                table: "UserTaskAssigns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserProjectAssigns",
                table: "UserProjectAssigns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjTempRelations",
                table: "ProjTempRelations");

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
                name: "ProjTempRelations",
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
                name: "IX_ProjTempRelations_TempId",
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
    }
}
