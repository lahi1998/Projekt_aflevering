global using Projekt_aflevering.Codes;
global using Projekt_aflevering.Codes.Models;
global using System.ComponentModel;

SchoolingCategory schoolingCategory = new();
Courses c = new(schoolingCategory);


Console.WriteLine("-------------------------------------------------------------------");
Console.WriteLine("Vælg uddannelseslinje:");
Console.WriteLine("1) Programmering");
Console.WriteLine("2) Support");
Console.WriteLine("3) Infrastruktur");
//dovet ryg ned en linje
Console.WriteLine(" ");
Console.Write("Vælg 1, 2 eller 3:");

returnpunktuddannelseslinje:
var menusvar = Console.ReadKey(true);
switch (menusvar.Key)
{
    case ConsoleKey.D1:
        schoolingCategory = (global::Projekt_aflevering.Codes.SchoolingCategory)1;
        c.SetCourses();
        break;

    case ConsoleKey.D2:
        schoolingCategory = (global::Projekt_aflevering.Codes.SchoolingCategory)2;
        c.SetCourses();
        break;

    case ConsoleKey.D3:
        schoolingCategory = (global::Projekt_aflevering.Codes.SchoolingCategory)3;
        c.SetCourses();
        break;

    default:
        Console.WriteLine("Forkert Indtastning. Prøv igen.");
        goto returnpunktuddannelseslinje;
}