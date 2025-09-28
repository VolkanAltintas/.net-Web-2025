Console.WriteLine(AreaOfCircle(5));     // double döner
        Console.WriteLine(Sum(3, 5));
        
        Console.WriteLine(Sum1(1, 2, 3, 4));  // params overload
    

    static double AreaOfCircle(double r) => Math.PI * r * r;

    int Sum(int a, int b)
     { return a + b ; }
    


    static int Sum1(params int[] numbers)
{
    int total = 0;
    foreach (var n in numbers) total += n;
    return total;
}