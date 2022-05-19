using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySearchEngine
{
    class Student :  User
    {
        private Date StartDate;
        private Date EndDate;


        public Student(string firstname, string lastname, string id) : base(firstname, lastname, id)
        {
            StartDate.Year = DateTime.Now.Year;
            StartDate.Day = DateTime.Now.Day;
            StartDate.Month = DateTime.Now.Month;
            Title1 = Status.Student;

            EndDate.Year = DateTime.Now.Year + 3;
            EndDate.Day = DateTime.Now.Day;
            EndDate.Month = DateTime.Now.Month;
        }
    }
}
