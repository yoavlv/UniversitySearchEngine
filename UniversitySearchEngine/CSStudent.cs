using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySearchEngine
{
    class CSStudent : Student
    {
        public enum Courses
        {
            Math1, Math2 , C, Java,Python , DataStructures
        }

        private double AvgGrade ;

        private List<Tuple<Courses, int>> CurrectCourses; // List of tuple  
        private List<Tuple<Courses, int>> PreviousCourses;

        internal List<Tuple<Courses, int>> PreviousCourses1 { get => PreviousCourses; set => PreviousCourses = value; }
        internal List<Tuple<Courses, int>> CurrectCourses1 { get => CurrectCourses; set => CurrectCourses = value; }
        public double AvgGrade1 { get => AvgGrade; set => AvgGrade = value; }

        public CSStudent(string firstname, string lastname, string id, float avgGrade = 0) : base(firstname, lastname, id)
        {
            CurrectCourses = new List<Tuple<Courses, int>>();
            PreviousCourses = new List<Tuple<Courses, int>>();
        }
        public void AddCourse(Courses course , int grade = -1 )
        {
            CurrectCourses.Add(Tuple.Create(course, grade));
        }
    
 
        public void DeleteCourse(Courses course)
        {

            CurrectCourses.RemoveAll(item => item.Item1 == course);

        }
        public void AddGradeCousreAndDelete(Courses course , int Grade)
        {
            if (CurrectCourses.Any(m=>m.Item1 == course) == true)
            {
                DeleteCourse(course); ;
                PreviousCourses.Add(Tuple.Create(course, Grade));
                CalculateAvgGrade();

            }
            else
            {
                Console.WriteLine("Error: {0} Not registered for the course :{1}", this.firstname1, course);
            }
     
        }

        public void PrintStudentCousres()
        {
            if (CurrectCourses.Count == 0)
            {
                Console.WriteLine("{0} Has not have any course yet", this.firstname1);
                return;
            }
            for (int i=0; i< CurrectCourses.Count; i++)
            {
                Console.WriteLine("Course: {0} --- Grade: {1}", CurrectCourses[i].Item1, CurrectCourses[i].Item2);
            }
            
        }
        public void PrintStudentPrevCousres()
        {
            if (PreviousCourses.Count == 0)
            {
                Console.WriteLine("{0} Has not yet completed any course yet" , this.firstname1);
                return;
            }


            for (int i = 0; i < PreviousCourses.Count; i++)
            {
                Console.WriteLine("Course: {0} --- Grade: {1}", PreviousCourses[i].Item1, PreviousCourses[i].Item2);
            }

        }
        public void CalculateAvgGrade()
        {
            if (PreviousCourses.Count == 0)
                return;
            double sum = 0;
            for (int i = 0; i < PreviousCourses.Count; i++)
            {
                sum += PreviousCourses[i].Item2;

            }
            this.AvgGrade1 = (sum / PreviousCourses.Count);

        }
    }
}
