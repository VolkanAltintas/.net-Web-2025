using System;

public class Student
{
    // Otomatik özellik
    public string Name { get; private set; }

    private int _age;
    public int Age
    {
        get => _age;
        set
        {
            if (value < 0 || value > 120) throw new ArgumentOutOfRangeException(nameof(Age));
            _age = value;
        }
    }

    // Kurucu--yapıcı 
    public Student(string name, int age)
    {
        Name = name;
        Age  = age; // property set ediliyor → doğrulama çalışır
    }

    public void Introduce() => Console.WriteLine($"Ben {Name}, {Age} yaşındayım.");
}

class Program
{
    static void Main()
    {
        var s = new Student("Elif", 20);
        s.Introduce();
        // s.Name = "Değiştiremem"; // private set → derleme hatası
    }
}
