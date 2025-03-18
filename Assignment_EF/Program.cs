using Assignment03_EF;
using Assignment03_EF.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Assignment_EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITI_Context dbcontext = new ITI_Context();

            #region Session 5

            #region Inner Join
            //1.Query syntax
            //var result = from S in dbcontext.Students
            //             join D in dbcontext.Departments
            //             on S.Dept_Id equals D.Id
            //             select new
            //             {
            //                 StudentName = S.FName,
            //                 DeptName = D.Name 
            //             };

            //2.Fluent Syntax
            //var result = dbcontext.Students.Join(dbcontext.Departments, s => s.Dept_Id, d => d.Id,
            //                                     (s, d) => new
            //                                     {
            //                                         StudentName = s.FName,
            //                                         DeptName = d.Name
            //                                     }).Where(a=>a.DeptName=="cs");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Group Join

            #region ex1
            //var result = dbcontext.Departments.GroupJoin(dbcontext.Students, d => d.Id, s => s.Dept_Id, (d, s) => new
            //{
            //    Department = d,
            //    Student = s
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Department.Name}");
            //    Console.WriteLine("--------------------------------------------------");
            //    foreach (var item1 in item.Student)
            //    {
            //        Console.WriteLine(item1.FName);
            //    }
            //} 
            #endregion

            #region ex2

            //var result = dbcontext.Departments.GroupJoin(dbcontext.Students, d => d.Id, s => s.Dept_Id, (Department, Student) => new
            //{
            //    Department = Department,
            //    Student = Student
            //}).Where(A=>A.Student.Count()>1);

            //foreach (var Item in result)
            //{
            //    Console.WriteLine(Item.Department.Name);
            //    Console.WriteLine("---------------------------------------------------");
            //    foreach (var stItem in Item.Student)
            //    {
            //        Console.WriteLine(stItem.FName);
            //    }
            //}
            #endregion

            #region Left Join Not Working
            //var result = dbcontext.Departments.LeftJoin(dbcontext.Students, d => d.Id, s => s.Dept_Id, (d, s) => new
            //{
            //    Department = d,
            //    Student = s
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 

            #endregion

            #region Right Outer Join
            //var result = dbcontext.Students.GroupJoin(dbcontext.Departments,s => s.Dept_Id, d=>d.Id, (s, d) => new
            //{
            //    Department = d,
            //    Student = s
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Student.FName);

            //    Console.WriteLine("-----------------------------------");
            //    foreach (var item1 in item.Department)
            //    {
            //        Console.WriteLine(item1.Name);
            //    }
            //} 
            #endregion

            #endregion

            #region Cross Join
            //var result = from s in dbcontext.Students
            //             from d in dbcontext.Departments
            //             select new
            //             {
            //                 s.FName,
            //                 deptName = d.Name
            //             };

            //var result = dbcontext.Students.SelectMany(s=> dbcontext.Departments.Select(d=>new 
            //{
            //   s.FName,
            //   DeptName = d.Name
            //}));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion

        }
    }
}
