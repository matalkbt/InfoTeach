using Microsoft.EntityFrameworkCore.Migrations;

namespace InfoTeach.Migrations
{
    public partial class UpdateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Question_QuestionId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Curriculum_Classrooms_ClassroomId",
                table: "Curriculum");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Subject_SubjectId",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_Assignments_AssignmentId",
                table: "Question");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_question_Types_QuestionTypeId",
                table: "Question");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Classrooms_UserId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_User_ClassroomId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Classrooms_UserId",
                table: "Teacher");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_User_ClassroomId",
                table: "Teacher");

            migrationBuilder.DropTable(
                name: "question_Types");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subject",
                table: "Subject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Question",
                table: "Question");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Classrooms",
                table: "Classrooms");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Subject",
                newName: "Subjects");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "Question",
                newName: "Questions");

            migrationBuilder.RenameTable(
                name: "Classrooms",
                newName: "Classroom");

            migrationBuilder.RenameIndex(
                name: "IX_Student_ClassroomId",
                table: "Students",
                newName: "IX_Students_ClassroomId");

            migrationBuilder.RenameIndex(
                name: "IX_Question_QuestionTypeId",
                table: "Questions",
                newName: "IX_Questions_QuestionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Question_AssignmentId",
                table: "Questions",
                newName: "IX_Questions_AssignmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects",
                column: "SubjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                columns: new[] { "UserId", "ClassroomId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questions",
                table: "Questions",
                column: "QuestionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Classroom",
                table: "Classroom",
                column: "ClassroomId");

            migrationBuilder.CreateTable(
                name: "QuestionTypes",
                columns: table => new
                {
                    QuestionTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionTypes", x => x.QuestionTypeId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Curriculum_Classroom_ClassroomId",
                table: "Curriculum",
                column: "ClassroomId",
                principalTable: "Classroom",
                principalColumn: "ClassroomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Subjects_SubjectId",
                table: "Lessons",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Assignments_AssignmentId",
                table: "Questions",
                column: "AssignmentId",
                principalTable: "Assignments",
                principalColumn: "AssignmentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_QuestionTypes_QuestionTypeId",
                table: "Questions",
                column: "QuestionTypeId",
                principalTable: "QuestionTypes",
                principalColumn: "QuestionTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Classroom_UserId",
                table: "Students",
                column: "UserId",
                principalTable: "Classroom",
                principalColumn: "ClassroomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Users_ClassroomId",
                table: "Students",
                column: "ClassroomId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Classroom_UserId",
                table: "Teacher",
                column: "UserId",
                principalTable: "Classroom",
                principalColumn: "ClassroomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Users_ClassroomId",
                table: "Teacher",
                column: "ClassroomId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Curriculum_Classroom_ClassroomId",
                table: "Curriculum");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Subjects_SubjectId",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Assignments_AssignmentId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_QuestionTypes_QuestionTypeId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classroom_UserId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Users_ClassroomId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Classroom_UserId",
                table: "Teacher");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Users_ClassroomId",
                table: "Teacher");

            migrationBuilder.DropTable(
                name: "QuestionTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questions",
                table: "Questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Classroom",
                table: "Classroom");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Subjects",
                newName: "Subject");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "Questions",
                newName: "Question");

            migrationBuilder.RenameTable(
                name: "Classroom",
                newName: "Classrooms");

            migrationBuilder.RenameIndex(
                name: "IX_Students_ClassroomId",
                table: "Student",
                newName: "IX_Student_ClassroomId");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_QuestionTypeId",
                table: "Question",
                newName: "IX_Question_QuestionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_AssignmentId",
                table: "Question",
                newName: "IX_Question_AssignmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subject",
                table: "Subject",
                column: "SubjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                columns: new[] { "UserId", "ClassroomId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Question",
                table: "Question",
                column: "QuestionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Classrooms",
                table: "Classrooms",
                column: "ClassroomId");

            migrationBuilder.CreateTable(
                name: "question_Types",
                columns: table => new
                {
                    QuestionTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_question_Types", x => x.QuestionTypeId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Question_QuestionId",
                table: "Answers",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Curriculum_Classrooms_ClassroomId",
                table: "Curriculum",
                column: "ClassroomId",
                principalTable: "Classrooms",
                principalColumn: "ClassroomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Subject_SubjectId",
                table: "Lessons",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Assignments_AssignmentId",
                table: "Question",
                column: "AssignmentId",
                principalTable: "Assignments",
                principalColumn: "AssignmentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_question_Types_QuestionTypeId",
                table: "Question",
                column: "QuestionTypeId",
                principalTable: "question_Types",
                principalColumn: "QuestionTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Classrooms_UserId",
                table: "Student",
                column: "UserId",
                principalTable: "Classrooms",
                principalColumn: "ClassroomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_User_ClassroomId",
                table: "Student",
                column: "ClassroomId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Classrooms_UserId",
                table: "Teacher",
                column: "UserId",
                principalTable: "Classrooms",
                principalColumn: "ClassroomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_User_ClassroomId",
                table: "Teacher",
                column: "ClassroomId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
