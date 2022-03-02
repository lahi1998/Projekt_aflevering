using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_aflevering.Codes
{
    internal sealed class Courses : Schooling
    {
        public List<string> SchoolingCourses { get; set; }

        public Courses(SchoolingCategory schoolingName) : base(schoolingName)
        {
            SchoolingName = schoolingName;
        }
        public override void SetCourses()
        {
            base.SetCourses();

            if (SchoolingName == SchoolingCategory.Programmeringslinje)
            {

                List<string> schoolingCourses = Courses.Where(a => a.Contains("Programmering")).ToList();
                SchoolingCourses = schoolingCourses;

            }
            if (SchoolingName == SchoolingCategory.Infrastrukturlinje)
            {

                List<string> schoolingCourses = Courses.Where(a => a.Contains("Netværk")).ToList();
                SchoolingCourses = schoolingCourses;

            }
            if (SchoolingName == SchoolingCategory.Supporterlinje)
            {

                List<string> schoolingCourses = Courses.Where(a => a.Contains("Server")).ToList();
                SchoolingCourses = schoolingCourses;


            }
        }
        public override void GetTeacher()
        {
            List<TECPerson> ValTeachers = new();
            Teachers = ValTeachers;
            foreach (var ValTeacher in Teachers)
            {
                if (SchoolingName == ValTeacher.Uddannelselinje)
                {
                    ValTeachers.Add(ValTeacher);
                }
            }
        }

        public override string ToString()
        {
            return "** OOP H1 Afleveringsopgave **";
        }







    }
}
