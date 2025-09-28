using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public int Id { get; }
    public string Name { get; set; }
    public int Age { get; set; }

    private static int _idSeed = 1;

    public Student(string name, int age)
    {
        Id = _idSeed++;
        Name = name;
        Age = age;
    }

    public override string ToString() => $"#{Id} - {Name} ({Age})";
}

class Program
{
    static List<Student> _students = new();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1) Listele");
            Console.WriteLine("2) Ekle");
            Console.WriteLine("3) Ara (isim)");
            Console.WriteLine("4) Sil (id)");
            Console.WriteLine("0) Çıkış");
            Console.Write("Seçim: ");

            switch (Console.ReadLine())
            {
                case "1": ListAll(); break;
                case "2": AddStudent(); break;
                case "3": SearchByName(); break;
                case "4": DeleteById(); break;
                case "0": return;
                default: Console.WriteLine("Geçersiz seçim."); break;
            }
        }
    }

    static void ListAll()
    {
        if (_students.Count == 0) { Console.WriteLine("Kayıt yok."); return; }
        _students.ForEach(s => Console.WriteLine(s));
    }

    static void AddStudent()
    {
        Console.Write("İsim: ");
        var name = Console.ReadLine();

        Console.Write("Yaş: ");
        if (!int.TryParse(Console.ReadLine(), out int age)) { Console.WriteLine("Hatalı yaş."); return; }

        _students.Add(new Student(name, age));
        Console.WriteLine("Eklendi.");
    }

    static void SearchByName()
    {
        Console.Write("Aranacak isim: ");
        var q = Console.ReadLine() ?? "";
        var results = _students.Where(s => s.Name.Contains(q, StringComparison.OrdinalIgnoreCase)).ToList();
        if (results.Count == 0) Console.WriteLine("Bulunamadı.");
        else results.ForEach(s => Console.WriteLine(s));
    }

    static void DeleteById()
    {
        Console.Write("Silinecek id: ");
        if (!int.TryParse(Console.ReadLine(), out int id)) { Console.WriteLine("Hatalı id."); return; }
        var s = _students.FirstOrDefault(x => x.Id == id);
        if (s == null) Console.WriteLine("Bulunamadı.");
        else { _students.Remove(s); Console.WriteLine("Silindi."); }
    }
}
