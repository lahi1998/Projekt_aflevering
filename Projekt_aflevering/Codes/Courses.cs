using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_aflevering.Codes
{
    internal class Courses : Schooling
    {
        public List<string> SchoolingCourses { get; set; }
        public Courses(SchoolingCategory schoolingName) : base(schoolingName)
        {

        }
        public override void SetCourses()
        {
            List<string> schoolingCources = new();
            base.SetCourses();
            if ((int)SchoolingName == 1)
            {
                foreach (string Course in (Enum.GetNames(typeof(CourseCategory))))
                {
                    SchoolingCourses.Add(Courses.FirstOrDefault(a => a.Contains("programmering")));
                }
            }
            if ((int)SchoolingName == 2)
            {
                foreach (string Course in (Enum.GetNames(typeof(CourseCategory))))
                {
                    SchoolingCourses.Add(Courses.FirstOrDefault(a => a.Contains("server")));
                }
            }
            if ((int)SchoolingName == 3)
            {
                foreach (string Course in (Enum.GetNames(typeof(CourseCategory))))
                {
                    SchoolingCourses.Add(Courses.FirstOrDefault(a => a.Contains("netværk")));
                }
            }
        }

        public override void GetTeacher()
        {
            foreach (string Course in (Enum.GetNames(typeof())))
            {
                SchoolingCourses.Add(Courses.FirstOrDefault(a => a.Contains("netværk")));
            }
        }




    }
}
