using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TasksEvaluation.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class INITDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Assignment_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeadLine = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Assignment_GroupId = table.Column<int>(type: "int", nullable: true),
                    Course_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: true),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: true),
                    SolutionFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradeId = table.Column<int>(type: "int", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    AssignmentId = table.Column<int>(type: "int", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilePic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bases_Bases_AssignmentId",
                        column: x => x.AssignmentId,
                        principalTable: "Bases",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bases_Bases_Assignment_GroupId",
                        column: x => x.Assignment_GroupId,
                        principalTable: "Bases",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bases_Bases_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Bases",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bases_Bases_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Bases",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bases_Bases_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Bases",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bases_Bases_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Bases",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bases_Assignment_GroupId",
                table: "Bases",
                column: "Assignment_GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Bases_AssignmentId",
                table: "Bases",
                column: "AssignmentId",
                unique: true,
                filter: "[AssignmentId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bases_CourseId",
                table: "Bases",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Bases_GradeId",
                table: "Bases",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Bases_GroupId",
                table: "Bases",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Bases_StudentId",
                table: "Bases",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bases");
        }
    }
}
