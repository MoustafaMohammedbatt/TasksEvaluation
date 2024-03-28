using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TasksEvaluation.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class INITDataBaseV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bases_Bases_AssignmentId",
                table: "Bases");

            migrationBuilder.DropForeignKey(
                name: "FK_Bases_Bases_Assignment_GroupId",
                table: "Bases");

            migrationBuilder.DropForeignKey(
                name: "FK_Bases_Bases_CourseId",
                table: "Bases");

            migrationBuilder.DropForeignKey(
                name: "FK_Bases_Bases_GradeId",
                table: "Bases");

            migrationBuilder.DropForeignKey(
                name: "FK_Bases_Bases_GroupId",
                table: "Bases");

            migrationBuilder.DropForeignKey(
                name: "FK_Bases_Bases_StudentId",
                table: "Bases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bases",
                table: "Bases");

            migrationBuilder.DropIndex(
                name: "IX_Bases_Assignment_GroupId",
                table: "Bases");

            migrationBuilder.DropIndex(
                name: "IX_Bases_AssignmentId",
                table: "Bases");

            migrationBuilder.DropIndex(
                name: "IX_Bases_CourseId",
                table: "Bases");

            migrationBuilder.DropIndex(
                name: "IX_Bases_GradeId",
                table: "Bases");

            migrationBuilder.DropIndex(
                name: "IX_Bases_StudentId",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "AssignmentId",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "Assignment_GroupId",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "Assignment_Title",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "Course_Title",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "DeadLine",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "GradeId",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "SolutionFile",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Bases");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Bases");

            migrationBuilder.RenameTable(
                name: "Bases",
                newName: "Students");

            migrationBuilder.RenameIndex(
                name: "IX_Bases_GroupId",
                table: "Students",
                newName: "IX_Students_GroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EvaluationGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationGrades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeadLine = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assignments_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Solutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SolutionFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradeId = table.Column<int>(type: "int", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    AssignmentId = table.Column<int>(type: "int", nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Solutions_Assignments_AssignmentId",
                        column: x => x.AssignmentId,
                        principalTable: "Assignments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Solutions_EvaluationGrades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "EvaluationGrades",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Solutions_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_GroupId",
                table: "Assignments",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_CourseId",
                table: "Groups",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Solutions_AssignmentId",
                table: "Solutions",
                column: "AssignmentId",
                unique: true,
                filter: "[AssignmentId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Solutions_GradeId",
                table: "Solutions",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Solutions_StudentId",
                table: "Solutions",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Solutions");

            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "EvaluationGrades");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Bases");

            migrationBuilder.RenameIndex(
                name: "IX_Students_GroupId",
                table: "Bases",
                newName: "IX_Bases_GroupId");

            migrationBuilder.AddColumn<int>(
                name: "AssignmentId",
                table: "Bases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Assignment_GroupId",
                table: "Bases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Assignment_Title",
                table: "Bases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Bases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Course_Title",
                table: "Bases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeadLine",
                table: "Bases",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Bases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Bases",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Grade",
                table: "Bases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GradeId",
                table: "Bases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "Bases",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Bases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SolutionFile",
                table: "Bases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Bases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Bases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bases",
                table: "Bases",
                column: "Id");

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
                name: "IX_Bases_StudentId",
                table: "Bases",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bases_Bases_AssignmentId",
                table: "Bases",
                column: "AssignmentId",
                principalTable: "Bases",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bases_Bases_Assignment_GroupId",
                table: "Bases",
                column: "Assignment_GroupId",
                principalTable: "Bases",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bases_Bases_CourseId",
                table: "Bases",
                column: "CourseId",
                principalTable: "Bases",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bases_Bases_GradeId",
                table: "Bases",
                column: "GradeId",
                principalTable: "Bases",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bases_Bases_GroupId",
                table: "Bases",
                column: "GroupId",
                principalTable: "Bases",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bases_Bases_StudentId",
                table: "Bases",
                column: "StudentId",
                principalTable: "Bases",
                principalColumn: "Id");
        }
    }
}
