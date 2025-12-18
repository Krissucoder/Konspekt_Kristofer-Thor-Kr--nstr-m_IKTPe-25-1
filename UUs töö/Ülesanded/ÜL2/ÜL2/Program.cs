namespace ÜL2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kirjuta programm kus on kaks kasutajat (kasutajanime ja parooliga)
            //küsi kasutjalt tema kasutajanime otsi kasutajate järjendist vastav kasutaja ja kui kasutajat ei leita ütle et kasutaja ei eksisteeri
            //küsi kasutaja ekisteerib vaata kasutaja parooli küsi kasutajalt tema parool ja võrdne neid
            //kui paroolid ühtiad ütle tere tulemast
            //kui aga ei ühti küsi kasutajalt parool uuesti

            List<List<string>> kasutajad = new List<List<string>>();
            kasutajad.Add(new List<string> { "kasutajanimi1", "parool1" });
            kasutajad.Add(new List<string> { "kasutajanimi2", "parool2" });
            //foreach (var item in kasutajad)
            //{
            //    Console.WriteLine(item.ToString() + "," + item[0] + "," + item[1]);
            //}
            string kasutajanimi = "";
            Console.WriteLine("palun sisesta oma kasutajanimi");
            kasutajanimi = Console.ReadLine();
            bool doesuserexsist = false;
            string õigeparool = "";
            foreach (var user in kasutajad)
            {
                if (user[0] == kasutajanimi)
                {
                    doesuserexsist = true;
                    õigeparool = user[1];
                }
            }
            if (doesuserexsist == true)
            {
                string sisestus = "";
                Console.WriteLine("´Tere",kasutajanimi,"sisesta oma parool");
                while (sisestus != õigeparool)
                {
                    Console.WriteLine("palun sisesta oma parool:");
                    sisestus = Console.ReadLine();
                }
                Console.WriteLine($"Tere tulemast {kasutajanimi}");

            }
            else
            {
                Console.WriteLine("kasutaja ei eksisteeri");
            }
        
        }
    }
}
