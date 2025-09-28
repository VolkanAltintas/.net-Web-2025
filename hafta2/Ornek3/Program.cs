// 1..10 arası sayıların toplamı (for)
        int sum = 0;
        for (int i = 1; i <= 10; i++) sum += i;
        Console.WriteLine($"Toplam (1..10): {sum}");

        // while ile tahmin oyunu (0..5)
        var rnd = new Random();
        int secret = rnd.Next(0, 6);
        int guess = -1, tries = 0;

        Console.WriteLine("0..5 arasında tahmin et!");
        while (guess != secret)
        {
            tries++;
            Console.Write("Tahmin: ");
            int.TryParse(Console.ReadLine(), out guess);
        }
        Console.WriteLine($"Bildin! Sayı {secret}. Deneme: {tries}");

        // foreach ile liste gezme
        var names = new List<string> { "Ayşe", "Mehmet", "Zeynep" };
        foreach (var n in names) Console.WriteLine($"-> {n}");