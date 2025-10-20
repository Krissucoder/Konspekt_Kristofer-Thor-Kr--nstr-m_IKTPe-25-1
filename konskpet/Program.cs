

//1. tuvasta võrdlus tühja stringiga, string andmetüüp
using System.ComponentModel.Design;

//Console.WriteLine("Tere kasutaja, kuidas on sinu nimi?;");
//string nimi = Console.ReadLine();

//if (nimi == "")
//{
//    Console.WriteLine("Sa ei sisestanud oma nime, sadface 😒");
//}
//else if ( (nimi !=""))
//{
//    Console.WriteLine("Tere " + nimi + "! häpifeiss 😊😊");

//}
//else
//{
//    Console.WriteLine("Tundmatu sisestus.");
//}
////2 -vahemikud
//Console.WriteLine(nimi + ", mis on sinu vanus?:");
//int kasutajavanus = int.Parse(Console.ReadLine());



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
//if (kasutajavanus > 0 && kasutajavanus < 18)

//    {
//        Console.WriteLine("Enerksi ei saa, oled alakas, Monsterist ilma 😒");
//    }
//    else
//    {
//        Console.WriteLine("Yippie saad monsut osta 😊");
//    }

////2.3 mitu vahemikku if/else-if abil. andmetüüp double/float/decimal
//Console.WriteLine($"Sisesta oma pikkus ka {nimi}!");
//double kasutajaPikkus = double.Parse(Console.ReadLine());

//if (kasutajaPikkus < 1.00d)
//{
//    Console.WriteLine("Oled Juntsu");
//}
//else if (kasutajaPikkus < 1.25 && kasutajaPikkus >= 1.00d)
//{
//    Console.WriteLine("Oled peaagu allameetrimees");
//}

//else if (kasutajaPikkus < 1.25 && kasutajaPikkus >= 1.00d)
//{
//    Console.WriteLine("Oled peaagu allameetrimees");
//}
//else if (kasutajaPikkus < 1.50d && kasutajaPikkus >= 1.25d)
//{
//    Console.WriteLine("OIOI, päkapikk enam ei olegi, " + nimi);
//}
//else if (kasutajaPikkus < 1.75 && kasutajaPikkus >= 1.5d)
//{
//    Console.WriteLine(nimi + ", oled enamasti standardpikkuses, kui mitte just natuke lühike");

//}
//else if (kasutajaPikkus < 2.00d && kasutajaPikkus >= 1.75)
//{
//    Console.WriteLine(nimi + ", oled pikk kolge, vaata et sa pead vastu uksepiita ära ei löö");

//}
//else
//{
//    Console.WriteLine("Täielik tulnukas! Kuidas pilved välja näevad läedalt?");
//}
//int arv1 = 0;
//int arv2 = 0;
//Console.WriteLine("Tere, palun sisesta esimene liidetav: ");
//arv1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Tere, palun sisesta esimene liidetav: ");
//arv2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Missugust tehet soovid teha? Kirjuta kas: + - / *");
//string tehtetüüp = Console.ReadLine();
//int tehe = 0;




//if (tehtetüüp == "+"  /*tingimus siia:*/)
//{
//    tehe = arv1 + arv2;
//}

//if (tehtetüüp == "*" /*tingimus siia:*/)
//{
//    tehe = arv1 + arv2;
//}


//if (tehtetüüp == "/" /*tingimus siia*/)
//{
//    tehe = arv1 + arv2;
//}





//if (tehtetüüp == "-"  /*tingimus siia */)
//{
//    tehe = arv1 + arv2;
//}


//Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");



//if (tehtetüüp == "+"  /*tingimus siia:*/)
//{
//    tehe = arv1 + arv2;
//}

//if (tehtetüüp == "*" /*tingimus siia:*/)
//{
//    tehe = arv1 + arv2;
//}


//if (tehtetüüp == "/" /*tingimus siia*/)
//{
//    tehe = arv1 + arv2;
//}





//if (tehtetüüp == "-"  /*tingimus siia */)
//{
//    tehe = arv1 + arv2;
//}


//Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");



////4 parool, if ja string andmetüüp
//Console.WriteLine($"Palun vabandust {nimi}, aga programmi edasiseks tõööks on parooli vaja");
//string password = Console.ReadLine();
//if (password == "simsalabim")
//{
//    Console.WriteLine("JES, parool on õige, oled sisse lubatud");

//}
//else if (password == "saatana" || password =="1234")
//{
//    Console.WriteLine("Parool on sobimatu, see sinu parool kohe kindlasti ei ole. ");
//}
//else
//{
//    Console.WriteLine("Parool on vale");
//}

////5 värvituvastus
//Console.WriteLine("Mis on sinu lemmikvärv?:");
//string favColour = Console.ReadLine();
//if (favColour == "punane")
//{
//    Console.BackgroundColor = ConsoleColor.Red;
//}
//else if (favColour == "sinine")
//{
//    Console.BackgroundColor = ConsoleColor.Blue;
//}
//else if (favColour == "kollane")
//{
//    Console.BackgroundColor = ConsoleColor.Yellow;
//}
//else if (favColour == "roheline")
//{
//    Console.BackgroundColor = ConsoleColor.Green;
//}
//else if (favColour == "must")
//{
//    Console.BackgroundColor = ConsoleColor.Black;
//}
//else if (favColour == "valge")
//{
//    Console.BackgroundColor = ConsoleColor.White;
//}
//else if (favColour =="helesinine")
//{
//    Console.BackgroundColor = ConsoleColor.Blue;
//}
//else if (favColour =="oranz")
//{
//    Console.WriteLine("Kahjuks ei ole oranz saadaval");
//}
//else if (favColour =="lilla")
//{
//    Console.WriteLine("kahjuks ei ole lilla saadaval");
//}
//else if (favColour =="roosa")
//{
//    Console.WriteLine("kahjuks ei ole roosa saadaval");
//}
//else
//    Console.WriteLine("The colour has maybe changed!!!!!");



///*ISESEISEV TÜLESANNE */
////# Kolija kalkulaator - Kirjuta programm mis:
////# - Küsib kasutajalt kas ta tahab ära mõõta pappkasti või õlitünni.
////# - olenevalt kasutaja sisestusest küsib ta:
////# - - tünni jaoks:
////# - - - kas kasutaja teab põhja raadiust (r) või põhja läbimõõtu (d):
////# - - - tünni kõrgust
////# - - - kaane paksust (kaane paksus võtab tünni kõrgusest maha, kuna kaan võtab tünni sisust natuke ruumi)
////# - - - Arvutab tünni ruumala mahu, tünni küljepindala, tünni kogupindala
////# - - kasti jaoks:
////# - - - Kas kast on kuubiku kujuline või risttahuka kujuline
////# - - - - kui on kuubik, siis küsib kasutajalt ainult küljepikkust
////# - - - - kui on risttahukas siis küsib kasutajalt:
////# - - - - - pikima külje pikkust,
////# - - - - - lühima külje pikkust ja
////# - - - - - kasti kõrgust
////# - - arvutab vastavalt kasti kogupindala, mahu, ja pikima läbiva joone (d)


//Console.WriteLine("Tere, kas sa tahad ära mõõta pappkasti või õlitünni");
//string valik = Console.ReadLine();
//if (valik == "tünn")
//{
//    Console.WriteLine("kas sa tead põhja raadisut (r) või põhja läbimõõtu (d)");
//    string rvõid = Console.ReadLine();
//    Console.WriteLine("Sisesta see mõõt?");
//    double mõõt = double.Parse(Console.ReadLine());
//    if (rvõid == "d")
//    {
//        mõõt = mõõt / 2;
//    }
//    else if (rvõid != "r")
//    {
//        Console.WriteLine("Sisend ei ole tuntav");
//    }
//    Console.WriteLine("Kui kõrge on su tünn");
//    int kõrgus = int.Parse(Console.ReadLine());
//    Console.WriteLine("Kui paks on tünni kaas?");
//    int kaanepaksus = int.Parse(Console.ReadLine());
//    double tünnipõhiS = Math.PI * (mõõt * mõõt);
//    double mahtV = tünnipõhiS * (kõrgus - kaanepaksus);
//    double küljepindala = tünnipõhiS * kõrgus;
//    double kogupindala = (tünnipõhiS * 2) + küljepindala;
//    Console.WriteLine($"Sinu tünn mahutab {mahtV} \nTünni küljepindala on {küljepindala} \nkogupindala aga on {kogupindala}");


//}
//else if (valik == "kast")
//{
//    Console.WriteLine("Kus su kast on kuubik (k) või risttahukas (r)");
//    string kastitüüp = Console.ReadLine();
//    if (kastitüüp == "k")
//    {
//        Console.WriteLine("Sisesta kasti külgpikkus");
//        double külgA = double.Parse(Console.ReadLine());
//        double kuubik = Math.Pow(külgA, 3);
//        double küljepindala = (külgA * külgA) * 6;
//        double diagonaal = külgA * Math.Sqrt(3);
//        Console.WriteLine($"Sinu kuubik mahutab {kuubik} \nKuubiku küljepindala on {küljepindala} \ndiagonaal aga on {diagonaal}");
//    }
//    else if (kastitüüp == "r")
//    {
//        Console.WriteLine("Mis on sinu kasti kõige pikkim külg");
//        double pikkkülg = double.Parse(Console.ReadLine());
//        Console.WriteLine("Mis on sinu kasti kõige lühim külg");
//        double lühikekülg = double.Parse(Console.ReadLine());
//        Console.WriteLine("Mis omn sinu kasti kõrgus?:");
//        double kõrgus = double.Parse(Console.ReadLine());
//        double V = pikkkülg * lühikekülg * kõrgus;
//        double kogupindala = 2 * ((pikkkülg * lühikekülg) + (lühikekülg * kõrgus) + (pikkkülg * kõrgus));
//        double diagonaal = Math.Sqrt((pikkkülg * pikkkülg) + (lühikekülg * lühikekülg) + (kõrgus * kõrgus));
//        Console.WriteLine($"Sinu kast mahutab {V} \nKasti küljepindala on {kogupindala} \ndiagonaal aga on {diagonaal}");
//    }

//}

//Console.WriteLine("banana");
//// console -> adresseritav moodul või objekt (roheline)
//// . -> midagi selle objekti seest, sarnane windowsi kausta pahtis oleva slashiga
//// Writeline -> adresseritav funktsioon objektist Console
//// () -> sulupaar mis omab endas funktsioonile vajalikku infot
////     - saab kasutada ka if tingimuslauses oleva tingimuse piiramiseks, ehk teisisõnu "ifi parameter"
//// [] -> tähistab massiive
//// {} -> koodiplokk, tavaliselt pärast tingimust või funktisiooni kirjeldust.
////      - saab ka kasutada teksti sees muutujate kuvamiseks
//// -> taane aitab arendajal aru saada illise koodiplokki sees, miski on. Vajalik ka kompilaatorile.
//// "banana" -> parameeter is antakse funktsioonile WriteLine töötlememiseks kaasa.
//// ; -> iga koodilause lõppeb komakooloniga

//int muutuja = 3;
////int -> muutuja nime eesolev andmetüübi kirjeldus. See näitab ära mis tüüpi andmed selle muutuja sees on
//// = -> võrdusmärk omistab sellele muutujale mingisuguse väärtuse
//// 3 -> väärtus mis sellele muutujale omistatakse

////võimalikud andmetüübid;
//int a = 1; //täisarv
//decimal b = 2.0M; // kümnendasüsteemis olev komakohaga arv
//float c = 3.0f; // kümnendasüsteemis olev ujukomaga arv
//double d = 4.0d; // kümnendasüsteemis olev komakohaga arv, sarnane decimaliga
//char c1 = 'a';//üksainus täht või tähemärk
//string s = "tekst"; // inimiloetaval kujul tekst
//var x = "abc"; //ebamäärase tüübiga kohalik muutuja.
//var y = 123;
//const int z = 3; //konstant-tüüpi muutujad ei saa muuta, ned on read-only

////põhilised matemaatilised tehted
//int liitimine = 1 + 1; //liitmine, kaks arvu kokku
//int lahutamine = 1 - 1; //lahutamine, esimene arv maha teisest
//int korrutamine = 1 * 1; //korrutamine, esimene arv korrutatakse teisega
//int jagamine = 1 / 1; //jagamine. esimene arv jagatatakse teisega
//double astendamine = Math.Pow(2, 2); //astendamine, esimene arv astendatakse teisega
//double juurimine = Math.Sqrt(2); //ruutjuur, parameetriks arv mida juuritakse

//int arv = 0; // sobib
//string sõne = "abc";
//string sisend_string = "abc";
////string string = "abc" ei sobi järgnevad sõnad;

////muutuja nimeks ei sobi järgnevad sõnad;
////abstract as, base, bool, brake, byte, case
////catch, char, checked,class,,const,continue,decimal,
////deafult,delegate,do,double,else,enum,event,
////explicit,extern,false,finally,fixed,float,for
////foreach,goto, if,implicit,in,int,
////interface,iternal,is,lock,long,namespace,paramas,
////private,protected,public,readonly,ref,return,sybte,
////sealed,short,sizeof,stackalloc,static,string,struct,
////switch,this,throw,true,try,typoof,uint,
////ulong,unchecked,unsafe,ushort,using,virtual,void
////volatile,while.

////ülesanne, kasutada süntaksiseletust, kirjelda kommentaariga iga koordida 




//int arv3 = 0;
////see on esimene arv
//// = -> võrdusmärk omistab sellele muutujale mingisuguse väärtuse
//// 0 -> väärtus mis sellele muutujale omistamiseks
////int -> muutuja nime eesolev andmetüübi kirjeldus. See näitab ära mis tüüpi andmed selle muutuja sees on

//int arv4 = 0;
////see on teine arv,muutuja nime ees olev andmetüüp, see näitab ära mis tüüpi andmed selle muutuja sees on
//// = -> võrdusmärk omistab sellele muutujale mingisuguse väärtuse
//// 0 -> väärtus mis sellele muutujale omistamiseks

//Console.WriteLine("Tere, palun sisesta esimene liidetav arv: ");
////Adresseerimine modulit "console", punkti abil ütleme et kasutame
////funsktsiooni writeline, et kasutajale öelda sõnum mis asub funsktsiooni
////taga olevate sulgude vahel; antud rida lõppeb lauselõpumärgiga

//arv1 = int.Parse(Console.ReadLine());
////instantseerime muutuja "arv1", ning et sinna saab panna täisarve andmetüübisõnaga int, selle muutuja sisse omistame tulemuse
//// mille saame kasutajalt Console.readline() abil kasutame moodulist "console" realugemisfunktsiooni, ning teisendame int admetüübis
////asuva funkstsiooni "Parse" abil kasutajasisendi täisarvuks. Lause lõppeb lauselõppumärgiga;
//Console.WriteLine("Tere, palun sisesta esimene liidetav: ");
//arv2 = int.Parse(Console.ReadLine());
////instantseerime muutuja "arv2", ning et sinna saab panna täisarve andmetüübisõnaga int, selle muutuja sisse omistame tulemuse
//// mille saame kasutajalt Console.readline() abil kasutame moodulist "console" realugemisfunktsiooni, ning teisendame int admetüübis
////asuva funkstsiooni "Parse" abil kasutajasisendi täisarvuks. Lause lõppeb lauselõppumärgiga;
//Console.WriteLine("Missugust tehet soovid teha? Kirjuta kas: + - / *");
////Adresseerimine modulit "console", punkti abil ütleme et kasutame funktsiooni writeline et kasutajale öelda sõnum
//// mis asub funkstiooni taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga.
//string tehtetyyp = Console.ReadLine();
////tekitame muutuja "thetetyyp" mille ette paneme andmetüüpi string ehk ütleme et seal on tekst ning võrdusmärgi abil omistame talle
////konsooli rea pealt loetu info, mis saame kasutades "Console" mooduli, readline() funktsiooni. lause lõppeb lauselõpumärgiga;
//int tulemus = 0;
////instantsieerime muutja tulemus, mille andmetüübiks on int, ja omistame talle esialgu väärtuse 0.Lause lõpp lõüeb lauselõpumärgiga




//if (tehtetüüp == "+"  /*tingimus siia:*/)
////if->kood mis käivitub siis on kui tiggimus õige
////==-> kontrollib kas pool A on sama mis pool B
////teeme tingimuselause if ning sulgude vahele kirjutame tingimuseks kontrolli. kas muutuja tehtetüüp sisu on samal kujul kui sõnr "+"


//{
//    tehe = arv1 + arv2;
//    //liitmine, kaks arvu kokku
//    //==-> kontrollib kas pool A on sama mis pool B
//    //peale tingimust on koodiplokk mis {} loogiliste sulgude vahel. Koodiplokk sisaldab endas ühte rida,kus muutujasse tulemus omistatakse nüüd väärtus liites kokku 
//    //muutuja arv1 ja muutuja arv2. Luase lõppeb lauselõpumärgiga sulgude sees
//}

//if (tehtetüüp == "*" /*tingimus siia:*/)
////if->kood mis käivitub siis on kui tiggimus õige
////==-> kontrollib kas pool A on sama mis pool B
////teeme tingimuselause if ning sulgude vahele kirjutame tingimuseks kontrolli. kas muutuja tehtetüüp sisu on samal kujul kui sõnr "*"

//{
//    tehe = arv1 + arv2;
//    //korrutamine, esimene arv korrutatakse teisega
//    //==-> kontrollib kas pool A on sama mis pool B
//    //peale tingimust on koodiplokk mis {} loogiliste sulgude vahel. Koodiplokk sisaldab endas ühte rida,kus muutujasse tulemus omistatakse nüüd väärtus liites kokku 
//    //muutuja arv1 ja muutuja arv2. Luase lõppeb lauselõpumärgiga sulgude sees
//}


//if (tehtetüüp == "/" /*tingimus siia*/)
////if->kood mis käivitub siis on kui tiggimus õige
////==-> kontrollib kas pool A on sama mis pool B
////teeme tingimuselause if ning sulgude vahele kirjutame tingimuseks kontrolli. kas muutuja tehtetüüp sisu on samal kujul kui sõnr "/"
//{
//    tehe = arv1 + arv2;
//    //jagamine. esimene arv jagatatakse teisega
//    //peale tingimust on koodiplokk mis {} loogiliste sulgude vahel. Koodiplokk sisaldab endas ühte rida,kus muutujasse tulemus omistatakse nüüd väärtus liites kokku 
//    //muutuja arv1 ja muutuja arv2. Luase lõppeb lauselõpumärgiga sulgude sees
//}





//if (tehtetüüp == "-"  /*tingimus siia */)
////if->kood mis käivitub siis on kui tiggimus õige
////==-> kontrollib kas pool A on sama mis pool B
////teeme tingimuselause if ning sulgude vahele kirjutame tingimuseks kontrolli. kas muutuja tehtetüüp sisu on samal kujul kui sõnr "-"
//{
//    tehe = arv1 + arv2;
//    //lahutamine, esimene arv maha teisest
//    //peale tingimust on koodiplokk mis {} loogiliste sulgude vahel. Koodiplokk sisaldab endas ühte rida,kus muutujasse tulemus omistatakse nüüd väärtus liites kokku 
//    //muutuja arv1 ja muutuja arv2. Luase lõppeb lauselõpumärgiga sulgude sees
//}
//if (tehtetyyp == "^")
////teeme tingimuselause if ning sulgude vahele kirjutame tingimuseks kontrolli. kas muutuja tehtetüüp sisu on samal kujul kui sõnr "^"
//{
//    tulemus = (int)Math.Pow(arv1, arv2);

//}
////peale tingimust on koodiplokk mis {} loogiliste sulgude vahel. Koodiplokk sisaldab endas ühte rida,kus muutujasse tulemus omistatakse nüüd väärtus liites kokku 
////muutuja arv1 ja muutuja arv2. Luase lõppeb lauselõpumärgiga sulgude sees
////moodulist "Math" punkti abil funkstiooni "Pow()", selle sees on arv1 astendatavana esimene parameeter, ning arv2 astendajana teine parameeter 

//Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");
//Adresseerimine modulit "console", punkti abil ütleme et kasutame sealt funkstsiooni "writeline" koos sulgude vahel parameetriga tulemus, et kuvada kasutajale tehte vastus
// lause lõppeb lauselõpumärgiga
//taga olevate suhlude vahel; antud rida lõppeb lauselõpumärgiga
//{} -> koodiplokk, tavaliselt pärast tingimust või funktisiooni kirjeldust.

Console.WriteLine("Sisesta ostusumma");
double ostusumma = double.Parse(Console.ReadLine());
if (ostusumma > 100)
//Adresseerimine modulit "console", punkti abil ütleme et kasutame sealt funkstsiooni "writeline" koos sulgude vahel parameetriga tulemus, et kuvada kasutajale tehte vastus
// lause lõppeb lauselõpumärgiga
//taga olevate suhlude vahel; antud rida lõppeb lauselõpumärgiga
//{} -> koodiplokk, tavaliselt pärast tingimust või funktisiooni kirjeldust.

{
    Console.WriteLine("Saad 20% allahindlust!");
    // peale tingimust on koodiplokk, mis {} loogiliste sulgude vahel.
    // Koodiplokk sisaldab ühte rida, kus kasutame Console.WriteLine funktsiooni, et kuvada kasutajale sõnum "Saad 20% allahindlust!"
    // Funktsioon Console.WriteLine kuulub Console moodulisse, mille kaudu saame teksti ekraanile printida.
}
else if (ostusumma < 101 && ostusumma > 50)
// teeme tingimuslause else if, mis kontrollib järgmist summakategooriat, kui eelmine if ei olnud tõene
// Kas muutuja ostusumma on suurem kui 50 (aga kindlasti väiksem või võrdne 100-ga, kuna eelmine if ei käivitunud)

{
    Console.WriteLine("Saad 10% allahinflust");
    // Koodiplokk {} sees kuvab sõnumi ekraanile, et klient saab 10% allahindlust

}
else if (ostusumma < 51 && ostusumma > 20)
// teeme tingimuslause else if, mis kontrollib summat 20 ja 50 vahel
{
    Console.WriteLine("Saad 5% allahindlust");
    // Kuvame sõnumi ekraanile 5% allahindluse kohta
}
else if (ostusumma < 21)
// teeme tingimuslause else if ning sulgude vahele kirjutame tingimuseks kontrolli,
// kas muutuja ostusumma väärtus on väiksem kui 21
// < tähendab "väiksem kui"
{
    Console.WriteLine("Allahindlust ei saa :(");
}
// peale tingimust on koodiplokk, mis {} loogiliste sulgude vahel.
    // Koodiplokk sisaldab ühte rida, kus kasutame Console.WriteLine funktsiooni, et kuvada kasutajale sõnum "Saad 20% allahindlust!"
    // Funktsioon Console.WriteLine kuulub Console moodulisse, mille kaudu saame teksti ekraanile printida.
else if (ostusumma < 1)
// else if on tingimuslause, mis käivitub ainult siis,
// kui eelmine if või else if tingimus ei olnud tõene
// sulgude sees on tingimus, mida kontrollitakse (ostusumma > 50)
// kui see tingimus on tõene, käivitatakse koodiplokk {}

{
    Console.WriteLine("Susestatud vigane arv");
}
//string kasutajaNimi = "";
//do
//{
//    Console.WriteLine("Palun sisesta oma kasutajanimi");
//    kasutajaNimi = Console.ReadLine();
//}
//while (kasutajaNimi != "user1");
//if (kasutajaNimi == "user1")
//{
//    int ruudusuurus = 0;

//    do
//    {
//        Console.WriteLine("Kui suurt ruutu tahad?");
//        ruudusuurus = int.Parse(Console.ReadLine());
//    } while (ruudusuurus > 0 && ruudusuurus < 20);
//    char reaKujund = 'k';
//    string üksRida = "";
//    int tsükliMuutuja = ruudusuurus;
//    do
//    {
//        üksRida += "_" + reaKujund;
//        tsükliMuutuja -= 1;
//    }
//    while (tsükliMuutuja != 0);
//    tsükliMuutuja = ruudusuurus;
//    do
//    {
//        Console.WriteLine(üksRida);
//        tsükliMuutuja -= 1;


//    } while (tsükliMuutuja != 0);

/* tingimuselause osad */
if (true) { }//kaiatstud sõna if kutsub eile tigimuslause, mille tingimus on sulgude vahel ning millele järgneb
//koodiplokk tigmuse täitumisel teostatava koodiga
else if (true) { } //kaitstud sõnad else ja if (else if) kutsuvad esile sekundaarse tingimuslause, millele tingimus
//on samamoodi sulgude vahel, ning millele peab eelnema alati if või else if. Tingimuse täitumisel
//ja eelneva tingimuse mittetäitumisel teostatakse koodiplokk sees olev kood
else { } //kaitstud sõna else kutsub esile järelltingimuse. millele peab eelnema kes if või else if,ning mille koodi-
//ploki sisu täidetaks kõikide if ja else if sees olevate tingimuste läbikukkumisel.

/*Loogilised tehted */
//&& -> Loogiline tehe, mida kasutatakse tingimuste kirjutamisel, ning mis annab positiivse vastuse (true) juhul kui
//      mõlemal pool && märki olevad tingimused on täidetud.Kui üks neist ei ole, siis annab negatiivse vastuse (false).
// || -> loogiline tehe, mida kasutatakse tingimuste kirjutamisel, ning mis annab positiivse vastuse (true) siis kui 
//    vähemalt üks tingimus on täidetud. negatiivne vastus (false) tagastakse siis, kui kõik tingimused on täitmata.
//!  -> loogiline tehe, mida kasutatakse tignimuste tulemuse inverteerimiseks. Tulemus mis muidu tagastaks true, hüüumärgi
//      puhul tagastab false, ja vastupidi -tulemus mis muidu tagastaks false, hüüumärgi puhul tagastab true.

/* Võrdlusoperaatorid*/
// == -> on võrdne. Võrdusmärgi ühel pool olev objekt peab vastama täpselt oma olemuselt võrdusmärgi teisel pool oleva objektiga.
//       ei ole sama nagu üks võrdusmärk. üks võrdusmärk omistab, kaks võrdleb.
// != -> ei ole võrdne.Võrdusmärgi ühel pool olev objekt *EI TOHI* olla samal kujul nagu teisel pool olev objekt.
//       Võrdlusoperaator on kombinatsioon "on võrnde" operaatorsit, ja loogiliste tehtest "not".
// >  -> on suurem kui.Mäegist vasakul pool olev bjekt peaks olema suurem kui paremal olev objekt.
//<   -> on väiksem kui. Märgist vasakul pool olev objekt peaks olema väiksem, kui paremal pool olev objekt.
//>=  -> on suurem kui võrdne kui. Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või suurem
//       kui paremal pool olev objekt. Operaator on kombinatsioon "on võrdne" ja "on suurem kui" operaatoritest.
// <=  ->on väiksem kui või võrdne kui. Märgist vasakul poo olev objekt peaks olema vähemalt võrnde või väiksem
//       kui paremal pool olev objekt. Operaator on kombinatsioon "on võrdne" ja "on väiksem kui" operaatortiest.

/* Omistusoperaatorid ja kiirtehted */
int arv = 1;// =  ->  üksik võrdusmärk omsitab muutujale väärtuse.
arv += 1;   // += -> võrdusmärk mille ees on pluss, automaatselt liidab muutujale otsa võrdusmärgi teisel pool oleva arvu.
// asendab tehet "arv = arv + 1". on kombinatsioon matematilisest tehtest "+" ja omistamisest ("=")
arv -= 1;   // -= -> võrdusmärk mille ees on miinus, automaatselt lahutab muutujast maha võrdusmärgi teisel pool oleva väärtuse.
// asendab tehet "arv = arv -1". on kombinatsioon matemaatiliselt tehtest "-" ja omistamisest ("=")
arv *= 2;   // *= -> võedusmärk mille ees on korrutusmärk * 2". on kombinatsioon matemaatiliselt tehtest "*" ja omistamisest ("=")
            //       arvu kordi. asendab teht "arv = *2". on kombinatsioon matematilisest tehtset "*" ja omistaisest ("=")

arv /= 2;   // *= -> võrdusmärk mille ees on jagamismärk /. automaatselt jagab muutuja sisu võrdusmärgi teisel pool oleva 
            //arvu osadeks. asendab tehet " arv = arv 7 2". on kombinatsioon matematilisest tehetest "/" ja omistamisest
            // ("=")
arv++;      // ++ -> on spetsiifiliselt ühe juurd liitmiseks lühivariant.
arv--;      // -- -> on spetsiifilseslt ühe maha lahutamiseks lühivariant.

/* Tsüklid */
// 1. do-while
do // "do" on kaitsus sõna, mis alustab do-while tsüklit pärast mida on koodiplokk, ning ütleb et tee seda koodi
{

} while (true); //niikaua kuni while järel olevate sulgude vahel olev tingimuse on täidetud.
    // Adresseerime moodulit "Console" ja punktiga kasutame sealt funktsiooni "WriteLine"
    // Sulgude vahel on parameeter – tekst, mis kuvatakse kasutajale
    // Lause lõppeb semikooloniga (;)

