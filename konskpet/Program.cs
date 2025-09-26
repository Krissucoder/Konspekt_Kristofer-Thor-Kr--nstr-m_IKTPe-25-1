

//1. tuvasta võrdlus tühja stringiga, string andmetüüp
using System.ComponentModel.Design;

Console.WriteLine("Tere kasutaja, kuidas on sinu nimi?;");
string nimi = Console.ReadLine();

if (nimi == "")
{
    Console.WriteLine("Sa ei sisestanud oma nime, sadface 😒");
}
else if ( (nimi !=""))
{
    Console.WriteLine("Tere " + nimi + "! häpifeiss 😊😊");

}
else
{
    Console.WriteLine("Tundmatu sisestus.");
}
//2 -vahemikud
Console.WriteLine(nimi + ", mis on sinu vanus?:");
int kasutajavanus = int.Parse(Console.ReadLine());



//2.1 mitu tingimust pesastatud ifide abil
//if (kasutajavanus > 0)
//{
//    if(kasutajavanus < 18)
//    {
//        Console.WriteLine("Enerksi ei saa, oled alakas, Monsterist ilma 😒");
//    }
//    else
//    {
//        Console.WriteLine("Yippie saad monsut osta 😊");
//    }
//}
//2.2 mitu tingimust pesastatud ifide abil
if (kasutajavanus > 0 && kasutajavanus < 18)

    {
        Console.WriteLine("Enerksi ei saa, oled alakas, Monsterist ilma 😒");
    }
    else
    {
        Console.WriteLine("Yippie saad monsut osta 😊");
    }

//2.3 mitu vahemikku if/else-if abil. andmetüüp double/float/decimal
Console.WriteLine($"Sisesta oma pikkus ka {nimi}!");
double kasutajaPikkus = double.Parse(Console.ReadLine());

if (kasutajaPikkus < 1.00d)
{
    Console.WriteLine("Oled Juntsu");
}
else if (kasutajaPikkus < 1.25 && kasutajaPikkus >= 1.00d)
{
    Console.WriteLine("Oled peaagu allameetrimees");
}

else if (kasutajaPikkus < 1.25 && kasutajaPikkus >= 1.00d)
{
    Console.WriteLine("Oled peaagu allameetrimees");
}
else if (kasutajaPikkus < 1.50d && kasutajaPikkus >= 1.25d)
{
    Console.WriteLine("OIOI, päkapikk enam ei olegi, " + nimi);
}
else if (kasutajaPikkus < 1.75 && kasutajaPikkus >= 1.5d)
{
    Console.WriteLine(nimi + ", oled enamasti standardpikkuses, kui mitte just natuke lühike");

}
else if (kasutajaPikkus < 2.00d && kasutajaPikkus >= 1.75)
{
    Console.WriteLine(nimi + ", oled pikk kolge, vaata et sa pead vastu uksepiita ära ei löö");

}
else
{
    Console.WriteLine("Täielik tulnukas! Kuidas pilved välja näevad läedalt?");
}
int arv1 = 0;
int arv2 = 0;
Console.WriteLine("Tere, palun sisesta esimene liidetav: ");
arv1 = int.Parse(Console.ReadLine());
Console.WriteLine("Tere, palun sisesta esimene liidetav: ");
arv2 = int.Parse(Console.ReadLine());
Console.WriteLine("Missugust tehet soovid teha? Kirjuta kas: + - / *");
string tehtetüüp = Console.ReadLine();
int tehe = 0;




if (tehtetüüp == "+"  /*tingimus siia:*/)
{
    tehe = arv1 + arv2;
}

if (tehtetüüp == "*" /*tingimus siia:*/)
{
    tehe = arv1 + arv2;
}


if (tehtetüüp == "/" /*tingimus siia*/)
{
    tehe = arv1 + arv2;
}





if (tehtetüüp == "-"  /*tingimus siia */)
{
    tehe = arv1 + arv2;
}


Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");



if (tehtetüüp == "+"  /*tingimus siia:*/)
{
    tehe = arv1 + arv2;
}

if (tehtetüüp == "*" /*tingimus siia:*/)
{
    tehe = arv1 + arv2;
}


if (tehtetüüp == "/" /*tingimus siia*/)
{
    tehe = arv1 + arv2;
}





if (tehtetüüp == "-"  /*tingimus siia */)
{
    tehe = arv1 + arv2;
}


Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");



//4 parool, if ja string andmetüüp
Console.WriteLine($"Palun vabandust {nimi}, aga programmi edasiseks tõööks on parooli vaja");
string password = Console.ReadLine();
if (password == "simsalabim")
{
    Console.WriteLine("JES, parool on õige, oled sisse lubatud");

}
else if (password == "saatana" || password =="1234")
{
    Console.WriteLine("Parool on sobimatu, see sinu parool kohe kindlasti ei ole. ");
}
else
{
    Console.WriteLine("Parool on vale");
}

//5 värvituvastus
Console.WriteLine("Mis on sinu lemmikvärv?:");
string favColour = Console.ReadLine();
if (favColour == "punane")
{
    Console.BackgroundColor = ConsoleColor.Red;
}
else if (favColour == "sinine")
{
    Console.BackgroundColor = ConsoleColor.Blue;
}
else if (favColour == "kollane")
{
    Console.BackgroundColor = ConsoleColor.Yellow;
}
else if (favColour == "roheline")
{
    Console.BackgroundColor = ConsoleColor.Green;
}
else if (favColour == "must")
{
    Console.BackgroundColor = ConsoleColor.Black;
}
else if (favColour == "valge")
{
    Console.BackgroundColor = ConsoleColor.White;
}
else if (favColour =="helesinine")
{
    Console.BackgroundColor = ConsoleColor.Blue;
}
else if (favColour =="oranz")
{
    Console.WriteLine("Kahjuks ei ole oranz saadaval");
}
else if (favColour =="lilla")
{
    Console.WriteLine("kahjuks ei ole lilla saadaval");
}
else if (favColour =="roosa")
{
    Console.WriteLine("kahjuks ei ole roosa saadaval");
}
else
    Console.WriteLine("The colour has maybe changed!!!!!");



/*ISESEISEV TÜLESANNE */
//# Kolija kalkulaator - Kirjuta programm mis:
//# - Küsib kasutajalt kas ta tahab ära mõõta pappkasti või õlitünni.
//# - olenevalt kasutaja sisestusest küsib ta:
//# - - tünni jaoks:
//# - - - kas kasutaja teab põhja raadiust (r) või põhja läbimõõtu (d):
//# - - - tünni kõrgust
//# - - - kaane paksust (kaane paksus võtab tünni kõrgusest maha, kuna kaan võtab tünni sisust natuke ruumi)
//# - - - Arvutab tünni ruumala mahu, tünni küljepindala, tünni kogupindala
//# - - kasti jaoks:
//# - - - Kas kast on kuubiku kujuline või risttahuka kujuline
//# - - - - kui on kuubik, siis küsib kasutajalt ainult küljepikkust
//# - - - - kui on risttahukas siis küsib kasutajalt:
//# - - - - - pikima külje pikkust,
//# - - - - - lühima külje pikkust ja
//# - - - - - kasti kõrgust
//# - - arvutab vastavalt kasti kogupindala, mahu, ja pikima läbiva joone (d)


Console.WriteLine("Tere, kas sa tahad ära mõõta pappkasti või õlitünni");
string õlitünn = Console.ReadLine();
string pappkasti = Console.ReadLine();
Console.WriteLine("Tere, kas sa tahad ära mõõta pappkasti või õlitünni?");
string valik = Console.ReadLine().ToLower();

if (valik == "õlitünni" || valik == "õlitünn")
{
    Console.WriteLine("Kas soovid sisestada raadiuse (r) või läbimõõdu (d)?");
    string mõõt = Console.ReadLine().ToLower();

    double raadius = 0;

    if (mõõt == "r")
    {
        Console.Write("Sisesta tünni sisemine raadius (cm): ");
        raadius = double.Parse(Console.ReadLine()) / 100.0; // muundame meetriteks
    }
    else if (mõõt == "d")
    {
        Console.Write("Sisesta tünni sisemine läbimõõt (cm): ");
        double d = double.Parse(Console.ReadLine());
        raadius = d / 2.0 / 100.0;
    }
    else
    {
        Console.WriteLine("Vigane valik.");
        return;
    }

    Console.Write("Sisesta tünni kõrgus (cm): ");
    double kõrgus = double.Parse(Console.ReadLine()) / 100.0;

    Console.Write("Sisesta seina paksus (mm): ");
    double paksus = double.Parse(Console.ReadLine()) / 1000.0;

    double pindala = 2 * Math.PI * raadius * kõrgus; // külgpindala
    double ruumala = Math.PI * Math.Pow(raadius, 2) * kõrgus; // maht

    Console.WriteLine($"\n--- Õlitünni andmed ---");
    Console.WriteLine($"Külgpindala: {pindala:F3} m²");
    Console.WriteLine($"Maht: {ruumala:F3} m³");
}
else if (valik == "pappkasti" || valik == "pappkast")
{
    Console.Write("Sisesta kasti pikkus (cm): ");
    double pikkus = double.Parse(Console.ReadLine()) / 100.0;

    Console.Write("Sisesta kasti laius (cm): ");
    double laius = double.Parse(Console.ReadLine()) / 100.0;

    Console.Write("Sisesta kasti kõrgus (cm): ");
    double kõrgus = double.Parse(Console.ReadLine()) / 100.0;

    double ruumala = pikkus * laius * kõrgus;
    double pindala = 2 * (pikkus * laius + pikkus * kõrgus + laius * kõrgus);

    Console.WriteLine($"\n--- Pappkasti andmed ---");
    Console.WriteLine($"Kogupindala: {pindala:F3} m²");
    Console.WriteLine($"Maht: {ruumala:F3} m³");
}
else
{
    Console.WriteLine("Tundmatu objekt. Palun vali kas 'pappkasti' või 'õlitünni'.");
}

