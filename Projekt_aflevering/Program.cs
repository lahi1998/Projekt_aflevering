global using Projekt_aflevering.Codes;
global using Projekt_aflevering.Codes.Models;
global using System.ComponentModel;



SchoolingCategory school = new();
List<TECPerson> persons = new();

Courses c = new(school);

start:
while (true)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Vælg uddannelseslinje");
    Console.WriteLine("1: Programmering");
    Console.WriteLine("2: Support");
    Console.WriteLine("3: Infrastruktur");
    Console.Write("Vælg 1, 2 eller 3");
    Console.CursorVisible = false;

returmenu:
    var Menuvalg = Console.ReadKey(true);
    switch (Menuvalg.Key)
    {
        case ConsoleKey.D1:
            c.SchoolingName = SchoolingCategory.Programmeringslinje;
            c.SetCourses();
            break;
        case ConsoleKey.D2:
            c.SchoolingName = SchoolingCategory.Supporterlinje;
            c.SetCourses();
            break;
        case ConsoleKey.D3:
            c.SchoolingName = SchoolingCategory.Infrastrukturlinje;
            c.SetCourses();
            break;
        default:
            goto returmenu;
    }



    Console.Clear();
    if (Menuvalg.Key == ConsoleKey.D1 || Menuvalg.Key == ConsoleKey.D2 || Menuvalg.Key == ConsoleKey.D3)
    {
        Console.WriteLine(c.ToString());
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
        Console.Write("Fag og lærer tilhørende ");
        if (c.SchoolingName == SchoolingCategory.Programmeringslinje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Programmeringslinjen");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" er market med");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Grøn.");
        }
        else if (c.SchoolingName == SchoolingCategory.Supporterlinje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Supporterlinjen");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" er market med");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Gul.");

        }
        else if (c.SchoolingName == SchoolingCategory.Infrastrukturlinje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Infrastrukturlinjen");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" er market med");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Rød.");

        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");



        string? Course_valgt;
        foreach (string Course_valg in c.Courses)
        {
            if (c.SchoolingName == SchoolingCategory.Programmeringslinje && Course_valg.Contains("Programmering"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Course_valgt = Course_valg.Replace("_", " ");
                Console.WriteLine(Course_valgt);
            }
            else if (c.SchoolingName == SchoolingCategory.Supporterlinje && Course_valg.Contains("Server"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Course_valgt = Course_valg.Replace("_", " ");
                Console.WriteLine(Course_valgt);
            }
            else if (c.SchoolingName == SchoolingCategory.Infrastrukturlinje && Course_valg.Contains("Netværk"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Course_valgt = Course_valg.Replace("_", " ");
                Console.WriteLine(Course_valgt);
            }
            else
            {
                Course_valgt = Course_valg.Replace("_", " ");
                Console.WriteLine(Course_valgt);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }




        Console.SetCursorPosition(0, 11);
        Console.WriteLine("Lærer:");
        foreach (var Line in c.Teachers)
        {
            if (c.SchoolingName == Line.Uddannelselinje)
            {
                if (Line.FullName == "Niels Olesen")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Line.FullName);
                }
                else if (Line.FullName == "Bo Hansen")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Line.FullName);
                }
                else if (Line.FullName == "Ole Nielsen")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Line.FullName);
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine(Line.FullName);
            }
        }
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
        goto start;
    }
}