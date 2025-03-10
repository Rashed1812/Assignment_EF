using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_EF.Migrations
{
    /// <inheritdoc />
    public partial class Relations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "course_Insts",
                columns: table => new
                {
                    inst_ID = table.Column<int>(type: "int", nullable: false),
                    Course_ID = table.Column<int>(type: "int", nullable: false),
                    evaluate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_course_Insts", x => new { x.inst_ID, x.Course_ID });
                    table.ForeignKey(
                        name: "FK_course_Insts_Courses_Course_ID",
                        column: x => x.Course_ID,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_course_Insts_Instructors_inst_ID",
                        column: x => x.inst_ID,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "stud_Courses",
                columns: table => new
                {
                    stud_ID = table.Column<int>(type: "int", nullable: false),
                    Course_ID = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stud_Courses", x => new { x.stud_ID, x.Course_ID });
                    table.ForeignKey(
                        name: "FK_stud_Courses_Courses_Course_ID",
                        column: x => x.Course_ID,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_stud_Courses_Students_stud_ID",
                        column: x => x.stud_ID,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_Dept_Id",
                table: "Students",
                column: "Dept_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Ins_Id",
                table: "Departments",
                column: "Ins_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Top_Id",
                table: "Courses",
                column: "Top_Id");

            migrationBuilder.CreateIndex(
                name: "IX_course_Insts_Course_ID",
                table: "course_Insts",
                column: "Course_ID");

            migrationBuilder.CreateIndex(
                name: "IX_stud_Courses_Course_ID",
                table: "stud_Courses",
                column: "Course_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_Top_Id",
                table: "Courses",
                column: "Top_Id",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_Ins_Id",
                table: "Departments",
                column: "Ins_Id",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_Dept_Id",
                table: "Students",
                column: "Dept_Id",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_Top_Id",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_Ins_Id",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_Dept_Id",
                table: "Students");

            migrationBuilder.DropTable(
                name: "course_Insts");

            migrationBuilder.DropTable(
                name: "stud_Courses");

            migrationBuilder.DropIndex(
                name: "IX_Students_Dept_Id",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Ins_Id",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Top_Id",
                table: "Courses");
        }
    }
}
