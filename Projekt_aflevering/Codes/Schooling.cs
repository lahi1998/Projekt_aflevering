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
        public CourseCatogory CourseName { get; set; }
        public List<TECPerson> Teachers { get; set; }
        public List<string>? Courses { get; set; }

        public Schooling(SchoolingCategory schoolingName)
        {
            List<TECPerson> teacherName = new()
            {
                new TECPerson { FullName = "Niels Olesen", Uddannelselinje = SchoolingCategory.Programmeringslinje },
                new TECPerson { FullName = "Bo Hansen", Uddannelselinje = SchoolingCategory.Supporterlinje },
                new TECPerson { FullName = "Ole Nielsen", Uddannelselinje = SchoolingCategory.Infrastrukturlinje }
            };
            Teachers = teacherName.ToList();
        }
        public virtual void SetCourses()
        {
            List<string> courses = new();
            Courses = courses;
            foreach (var ValCourses in (Enum.GetNames(typeof(CourseCatogory))))
            {
                courses.Add(ValCourses);
            }
        }
        public abstract void GetTeacher();
    }



}


