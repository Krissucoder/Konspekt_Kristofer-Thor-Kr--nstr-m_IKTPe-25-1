static void Main()
{
    Console.WriteLine("Tõstja kalkulaator");
    Console.Write("Mida soovid mõõta: kast või tünn? ");
    string choice = Console.ReadLine().Trim().ToLower();

    if (choice == "tünn")
    {
        Console.Write("Kas tead põhja raadiust (r) või diameetrit (d)? ");
        string rd = Console.ReadLine().Trim().ToLower();

        double r;
        if (rd == "r")
        {
            Console.Write("Sisesta tünni põhja raadius (meetrites): ");
            r = double.Parse(Console.ReadLine());
        }
        else if (rd == "d")
        {
            Console.Write("Sisesta tünni põhja diameeter (meetrites): ");
            double d = double.Parse(Console.ReadLine());
            r = d / 2.0;
        }
        else
        {
            Console.WriteLine("Vigane sisend.");
            return;
        }

        Console.Write("Sisesta tünni kõrgus (meetrites): ");
        double h = double.Parse(Console.ReadLine());

        Console.Write("Sisesta kaane paksus (meetrites): ");
        double t = double.Parse(Console.ReadLine());

        double hEff = h - t; // tõhus kõrgus

        double volume = Math.PI * r * r * hEff;
        double sideArea = 2 * Math.PI * r * hEff;
        double totalArea = sideArea + 2 * Math.PI * r * r;

        Console.WriteLine("\n--- Tulemused tünni kohta ---");
        Console.WriteLine($"Tünni maht: {volume:F2} m³");
        Console.WriteLine($"Külgpindala: {sideArea:F2} m²");
        Console.WriteLine($"Kogupindala: {totalArea:F2} m²");
    }
    else if (choice == "kast")
    {
        Console.Write("Kas see on kuup või risttahukas? ");
        string typeBox = Console.ReadLine().Trim().ToLower();

        double volume, area, diag;

        if (typeBox == "kuup")
        {
            Console.Write("Sisesta kuubi külje pikkus (meetrites): ");
            double a = double.Parse(Console.ReadLine());

            volume = Math.Pow(a, 3);
            area = 6 * Math.Pow(a, 2);
            diag = a * Math.Sqrt(3);

            Console.WriteLine("\n--- Tulemused kuubi kohta ---");
        }
        else if (typeBox == "risttahukas")
        {
            Console.Write("Sisesta kõige pikem külg (meetrites): ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Sisesta kõige lühem külg (meetrites): ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Sisesta kasti kõrgus (meetrites): ");
            double c = double.Parse(Console.ReadLine());

            volume = a * b * c;
            area = 2 * (a * b + a * c + b * c);
            diag = Math.Sqrt(a * a + b * b + c * c);

            Console.WriteLine("\n--- Tulemused risttahuka kohta ---");
        }
        else
        {
            Console.WriteLine("Vigane sisend.");
            return;
        }

        Console.WriteLine($"Maht: {volume:F2} m³");
        Console.WriteLine($"Kogupindala: {area:F2} m²");
        Console.WriteLine($"Pikim diagonaal (läbimõõt): {diag:F2} m");
    }
    else
    {
        Console.WriteLine("Vigane sisend. Palun kirjuta 'kast' või 'tünn'.");
    }
}
        