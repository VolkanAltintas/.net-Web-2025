        Console.Write("Adın: ");
        string name = Console.ReadLine();

        Console.Write("Yaşın: ");
        // kullanıcı hatalı sayı girerse güvenli dönüştürme:
        bool ok = int.TryParse(Console.ReadLine(), out int age);

        if (!ok)
        {
            Console.WriteLine("Geçerli bir sayı girmelisin.");
            return;
        }

        double pi = 3.14159;
        bool isStudent = true;

        Console.WriteLine($"Merhaba {name}, {age} yaşındasın.");
        Console.WriteLine($"pi ≈ {pi}, öğrenci misin? {isStudent}");

Console.Write(topla(3,5));
int topla(int a, int b)
{
    return a + b;
}