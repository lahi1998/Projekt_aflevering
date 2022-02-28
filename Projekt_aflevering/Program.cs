global using Projekt_aflevering.Codes;
global using Projekt_aflevering.Codes.Models;


// har sat dubble //// som her på dem du kan afmærkere til tjek i quiz.





//                       Quiz   1/5
//-----------------------------------------------------------------------------------


//1.Udefra klasserne til venstre, og med det arve
//hierarki som klasserne implementer, hvilket af
//følgende 6 istantiering forneden vil IKKE vise fejl
//når implementeres?
//1. //MotorKøretøj motorKøretøj = new MotorKøretøj();
//2. //MotorKøretøj motorKøretøj = new Bil();
//3. //MotorKøretøj motorKøretøj = new Audi();
//4. //Audi audi = new Audi();
//5. //Audi audi = new Bil();
//6. //Audi audi = new MotorKøretøj(); 



//                 svar
//---------------------------------------------------------
// de instantieringer der virker er : 1. 2. 3. 4.
// 4. Audi audi = new Audi() kan nå helle hierakiet givet det grandchild.
// 1-3 giver ikke fejl men mortorkørtøj kan ikke se hvad der i bil og audi givet den er parent. når jeg skrive dem være for sig sat eksempel ind afmærker efter behov.

////MotorKøretøj motorKøretøj = new MotorKøretøj();
////MotorKøretøj motorKøretøj = new Bil();
////MotorKøretøj motorKøretøj = new Audi();

////internal class MotorKøretøj
////{
////    public int HesteKræfter { get; set; }
////}
////internal class Bil : MotorKøretøj
////{
////    public string Mærke { get; set; }
////}
////internal class Audi : Bil
////{
////    public string Model { get; set; }
////}


//2.Hvis man istantiere Audi klassen. Kan
//man igennem audi klassens instans se
//Mærke og HesteKræfter property’erne?

//                 svar
//---------------------------------------------------------
// ja givet det Grandchild/bunden af hierakiet.



//3.Hvis man istantiere MotorKøretøj
//klassen. Kan man igennem motorkøretøj
//instans se Mærke og Model
//property’erne?

//                 svar
//---------------------------------------------------------
// nej givet det parent





//                       Quiz   2/5
//-----------------------------------------------------------------------------------

//1.Vis med de 3 bil data til højre, hvordan i kan,
//indkapsle bil dataerne i en objekt og indkapsle
//flere bil data objekter i en List af Bil objekter i
//MotorKøretøj klassen.

//                 svar
//---------------------------------------------------------
// tror jeg misforstår spørgsmålet. men jeg laver en list med de 3 set bildata i.

//2. Vis med LINQ hvordan i kan udskrive alle bilers
//info ud i konsollen for biler som har hestekræfter
//over 60.

//3. Vis med LINQ hvordan i kan udtræk en enkelt bil
//objekt ud af mærket ”Audi” og udskriv alle dens
//info i konsollen



//                 svar 1.
//---------------------------------------------------------
////List<Bil> biler = new()
////{
////    new Bil() { Mærke = "Toyota", Model = "Aygo", HesteKræfter = 60 },
////    new Bil() { Mærke = "Fiat", Model = "Punto", HesteKræfter = 90 },
////    new Bil() { Mærke = "Audi", Model = "A6", HesteKræfter = 175 }

////};


//                 svar 2.
//---------------------------------------------------------


////foreach (Bil line in biler)
////{
////    if (line.HesteKræfter > 60)
////    {
////        Console.WriteLine(line.Mærke + " " + line.Model + " " + "har" + " " + line.HesteKræfter + " " + " hestekræfter");
////    }

////}
////Console.ReadKey();


//                 svar 3.
//---------------------------------------------------------

//Bil bil = biler.FirstOrDefault(a => a.Mærke == "Audi");
//if (bil != null)
//{

//    Console.WriteLine(bil.Mærke + " " + bil.Model + " " + bil.HesteKræfter);

//}

//Console.ReadKey();






//                       Quiz   3/5
//-----------------------------------------------------------------------------------
////List<Bil> biler = new()
////{
////    new Bil() { Mærke = "Toyota", Model = "Aygo", HesteKræfter = 60 },
////    new Bil() { Mærke = "Fiat", Model = "Punto", HesteKræfter = 90 },
////    new Bil() { Mærke = "Audi", Model = "A6", HesteKræfter = 175 }
////};


//Følgende 3 kode linjer laver query af data fra
//List<Bil> Biler i forrige quiz:
//?? = Biler.Where(…);
//?? = Biler.FirstOrDefault(…);
//?? = Biler.First(…);

//1.Hvilket af de 3 kode linjer foroven returner en
//List<Bil>

//                 svar 1.
//---------------------------------------------------------
//?? = Biler.Where(…);


//2. Hvilket af de 3 kode linjer foroven returner en
//enkelt Bil objekt?

//                 svar 2.
//---------------------------------------------------------
//?? = Biler.FirstOrDefault(…);
//?? = Biler.First(…);


//3. Hvilket af de 3 kode linjer foroven returner null
//værdi hvis søge kondition ikke matcher med noget af
//data i listen?

//                 svar 3.
//---------------------------------------------------------
//?? = Biler.FirstOrDefault(…);


//4. Hvilket af de 3 kode linjer foroven vil CRASH
//applikationen hvis ingen match funket i søge
//kondition?
//• Ligesom Convert vil crash applikation hvis
//format er forkert, mens tryParse() vil
//returner true or false)

//                 svar 4.
//---------------------------------------------------------

//   Biler.First(…);

//                       Quiz   4/5
//-----------------------------------------------------------------------------------
