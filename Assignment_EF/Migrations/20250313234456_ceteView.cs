using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_EF.Migrations
{
    /// <inheritdoc />
    public partial class ceteView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"create view StudentDepartmentView
                                        with encryption
                                        as
                                        select s.Id studentId,s.FName FirstName,s.LName LastName,s.Age StudentAge,s.Address StudentAddress,d.Id DepartmentId,d.DepartmentName DepartmentName
                                        from Students s ,Departments d
                                        where s.Dept_Id = d.Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Drop view StudentDepartmentView");
        }
    }
}
