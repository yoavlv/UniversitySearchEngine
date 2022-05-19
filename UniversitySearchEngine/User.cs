using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySearchEngine
{
    class User

    {

        public struct Date
        {
            int day ;
            int month;
            int year;

            public int Day { get => day; set => day = value; }
            public int Year { get => year; set => year = value; }
            public int Month { get => month; set => month = value; }
        }
        public enum Status
        {
            Student, Teacher, Unknown

        }

        private string FirstName;
        private string LastName;
        private string City;
        private string Id;
        private Date BirthDay ;
        private Status Title;


        public User(string firstname, string lastname, string id) {
            FirstName = firstname;
            this.LastName = lastname;
            this.BirthDay.Day = 12;
            this.BirthDay.Month = 12;
            this.BirthDay.Year = 2000;

            this.Title = Status.Unknown;
            
            if (id.Length != 9)
            {
                Console.WriteLine("The id is'nt Valid");
                this.Id = null;
            }
            else
                this.Id = id;


        }
        public string firstname1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public string City1 { get => City; set => City = value; }
        internal Date BirthDay1 { get => BirthDay; set => BirthDay = value; }
        public string Id1 { get => Id; set => Id = value; }
        internal Status Title1 { get => Title; set => Title = value; }
    }

}
