using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_aflevering.Codes
{
    enum CourseCatogory
    {
        [Description("Grundlæggende Programmering")]
        Grundlæggendeprogrammering,
        [Description("Objektorienteret Programmering")]
        Objektorienteretprogrammering,
        [Description("Web Server")]
        Webserver,
        [Description("Database Server")]
        Databaseserver,
        [Description("WAN Netværk")]
        WANnetværk,
        [Description("LAN Netværk")]
        LANnetværk
    }
    enum SchoolingCategory
    {
        Programmeringslinje,
        Supporterlinje,
        Infrastrukturlinje
    }
}
