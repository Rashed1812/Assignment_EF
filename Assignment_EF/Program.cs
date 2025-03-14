using Assignment03_EF;
using Assignment03_EF.Data;
using Microsoft.EntityFrameworkCore;

namespace Assignment_EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITI_Context dbcontext = new ITI_Context();

            #region Session 4
            //var st = (from e in dbcontext.Students
            //          where e.Id ==101
            //          select e).FirstOrDefault();
            //Console.WriteLine($"Student Name: {st.FName} \nAge:{st.Age}\nAddress:{st.Address}\nDeptid:{st.Dept_Id}");

            //var dep = (from d in dbcontext.Departments
            //           where d.Id==3
            //           select d).FirstOrDefault();
            //Console.WriteLine($"Department Name: {dep.Name}");
            //foreach (var st in dep.Students)
            //{
            //    Console.WriteLine($"Student Name:{st.FName}");
            //} 

            #endregion

            #region Explicit loading
            //var st = (from e in dbcontext.Students
            //           where e.Id ==101
            //           select e).FirstOrDefault();

            //dbcontext.Entry(st).Reference(nameof(st.Department)).Load();
            //dbcontext.Entry(st).Collection(nameof(st.Department)).Load();
            //Console.WriteLine($"Department Name: {st.Department.Name}");

            #endregion

            #region Eager Loading

            //var st = (from e in dbcontext.Students.Include(e=>e.Department)
            //           where e.Id ==101
            //           select e).FirstOrDefault();
            //Console.WriteLine($"Department Name: {st.Department.Name}");

            #endregion

            #region Lazy Loading

            //var st = (from e in dbcontext.Students
            //          where e.Id ==101
            //          select e).FirstOrDefault();

            //Console.WriteLine($"Department Name: {st?.Department.Name}");

            #endregion

            #region Tracking Not Tracking

            ////dbcontext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            //var st = (from e in dbcontext.Students
            //          where e.Id ==101
            //          select e).FirstOrDefault();


            //Console.WriteLine(dbcontext.Entry(st).State);
            //st.FName = "Ahmed";
            //Console.WriteLine(dbcontext.Entry(st).State);

            //dbcontext.SaveChanges(); 
            #endregion

            #region Mapping View

            ////var result = dbcontext.studentDepartments.FromSqlRaw("select * from StudentDepartmentView");
            
            //foreach (var item in dbcontext.studentDepartments)
            //{
            //    Console.WriteLine($"StudentFName: {item.FirstName} StudentLName: {item.LastName} DepartmentId: {item.DepartmentId} DepartmentName: {item.DepartmentName}");
            //}

            #endregion

        }
    }
}
