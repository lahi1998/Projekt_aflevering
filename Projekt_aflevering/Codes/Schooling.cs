using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_aflevering.Codes
{
    internal abstract class Schooling
    {

        public SchoolingCategory SchoolingName { get; set; }
        public List<TECPerson> Teachers { get; set; }
        public List<string> Courses { get; set; }

        public Schooling(SchoolingCategory schoolingName)
        {
            SchoolingName = schoolingName;

            List<TECPerson> Teacher = new()
            {
                new TECPerson() { FullName = "Niels Olsen", Uddannelselinje = schoolingName },
                new TECPerson() { FullName = "Bo Hansen", Uddannelselinje = schoolingName },
                new TECPerson() { FullName = "Ole Nielsen", Uddannelselinje = schoolingName }
            };
        }
        public virtual void SetCourses()
        {
            List<string> courses = new();
            Courses = courses;
            foreach (var displayCourses in (Enum.GetNames(typeof(CourseCatogory))))
            {
                courses.Add(displayCourses);
            }
        }
        public abstract void GetTeacher();

    }

}


