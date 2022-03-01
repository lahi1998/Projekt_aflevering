using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_aflevering.Codes
{
    internal abstract class Schooling
    {

        
        public List<TECPerson>Teacher { get; set; }

        public List<string> Courses { get; set; }
        public SchoolingCategory SchoolingName { get; set; }



        public Schooling(SchoolingCategory schoolingName)
        {
            SchoolingName = schoolingName;

            List<TECPerson> Teachers = new()
            {
                new TECPerson() { FullName = "Niels Olesen", Uddannelselinje = schoolingName },
                new TECPerson() { FullName = "Bo Hansen", Uddannelselinje = schoolingName },
                new TECPerson() { FullName = "Ole", Uddannelselinje = schoolingName }
            };

        }


        public virtual void SetCourses()
        {
            
            List<string> courses = new();
            Courses = courses;
            foreach (var val in Enum.GetNames(typeof(CourseCategory)))
            {
                courses.Add(val);
            }
        }
        public abstract void GetTeacher();

    }

}


