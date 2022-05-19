using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySearchEngine
{
    class Teacher : User 
    {
        public enum Profession
        {
            ComputerScience , Biology, History
        }
  
        private Date StartDate;
        private Profession Pro;
        private Profession Pro1 { get => Pro; set => Pro = value; }

        public Teacher(Profession pro ,Date StartDate, string firstname, string lastname, string id) : base(firstname, lastname, id)
        {
            StartDate.Year = DateTime.Now.Year;
            StartDate.Day = DateTime.Now.Day;
            StartDate.Month = DateTime.Now.Month;
            this.Pro = pro;
        }

        public int TotalYears()
        {
            return DateTime.Now.Year - StartDate.Year + 1;
        }

    }
}
