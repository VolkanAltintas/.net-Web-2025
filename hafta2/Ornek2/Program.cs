
        Console.Write("Not (0-100): ");
        if (!int.TryParse(Console.ReadLine(), out int grade))
        {
            Console.WriteLine("Hatalı giriş.");
            return;
        }

        // if-else ile harf notu
        string letter =
            grade >= 90 ? "AA" :
            grade >= 80 ? "BA" :
            grade >= 70 ? "BB" :
            grade >= 60 ? "CB" :
            grade >= 50 ? "CC" : "FF";

        Console.WriteLine($"Harf notu: {letter}");

        // switch expression (C# 8+)
        string status = grade switch
        {
            >= 90 => "Mükemmel",
            >= 70 => "Başarılı",
            >= 50 => "Geçti",
            _     => "Kaldı"
        };
        Console.WriteLine($"Durum: {status}");
