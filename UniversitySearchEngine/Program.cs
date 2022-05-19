using System;
using System.Data;
using System.Linq;


namespace UniversitySearchEngine
{
    class Program
    {
        static void Main(string[] args)
        {

            CSStudent s = new CSStudent("Yoav", "Lavie", "208768226");
            s.AddCourse(CSStudent.Courses.C);
            s.AddCourse(CSStudent.Courses.DataStructures);
            s.AddCourse(CSStudent.Courses.Java);

            Console.WriteLine("----------------------------------------------");
            s.AddGradeCousreAndDelete(CSStudent.Courses.C, 90);
            s.AddGradeCousreAndDelete(CSStudent.Courses.DataStructures, 91);
            s.AddGradeCousreAndDelete(CSStudent.Courses.Java, 100);

            s.PrintStudentPrevCousres();
            s.PrintStudentCousres();
            Console.WriteLine(s.AvgGrade1);

            Console.WriteLine("----------------------------------------------");


        }
    }
}
