using System.ComponentModel.Design;

namespace ÜL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kirjuta programmm mis
            //küsib kasutajalt tsüklis ,illised mängud telle meeldivad
            //küsimuste tulemus hoia järjednis
            List<string> mängud = new List<string>();
            Console.WriteLine("Tere kasutaja millised mängud slle meeldivad");
            string mäng = "";
            while (mäng != "ei ole")
            {
                Console.WriteLine("palun sisesta järgmine mäng keui ei ole kirjuta \"ei ole\"");
                mäng = Console.ReadLine();
                if (mäng != "ei ole")
                {
                    mängud.Add(mäng);
                }
            }
            //kui järjend sisaldab (.Contains()) "mario kart" siis küsi kui vana ta on sarkatiliselt
            if (mängud.Contains("mario kart"))
            {
                Console.WriteLine("kui vana sa oled??!?mingi kuus vä?!?!");
            }
            //kui järjend sisaldab "gta 6" siis küsi kust ta ajamasin sai et rockstar lõpuks ajsaga valmis sai
            if (mängud.Contains("gta 6"))
            {
                Console.WriteLine("kust ajamasina said? Kuidas rockstar arendusega juurde sai?");
            }
            //kui järjend sisaldab "pong" siis ütle "80ndad tahavad vanureid tagasi tpoimub boomerite recall
            if (mängud.Contains ("pong"))
            {
                Console.WriteLine("80ndad tahavad vanureid tagasi toimbub boomerite recall");
            }
            //kui järjend on tühi siis programm läheb edasi ->

            //küsi kasutajalt kas talle ei meeldi mängud ning löase tal vastata sõnaga jah või ei kontrolli kasutaja sisestust tOuPPER() VÕI tOlOWER()iga
            if (!mängud.Any())
            {
                Console.WriteLine("Kas sulle ei meeldi mängud? vasta kas jah või ei");
                string jahvõiei = Console.ReadLine().ToLower();
                if (jahvõiei.Contains("jah"))
                {
                    Console.WriteLine("aga miks siis ei sisestanud?");
                }
                else if (jahvõiei.Contains("ei"))
                {
                    Console.WriteLine("kahju :c");
                }
                
            }
            else
            {
                Console.WriteLine("ei saa aru :/");
            }
            //kui talle ei meeldi siis ütle kahju
            //kui ta vastab jah siis ütle aga miks siis ei sisestanud?
            //kui vastus on midagi muud siis üte ei saa aru :/
        }
    }
}
