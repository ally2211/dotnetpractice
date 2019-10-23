
using System;

public class A
{
    public string Name;
    public void GetName()
    {
        Console.WriteLine("Name: {0}", Name);
    }
}
public class B : A
{
    public string Location;
    public void GetLocation()
    {
        Console.WriteLine("Location: {0}", Location);
    }
}

public class C : B
{
    public int Age;
    public void GetAge()
    {
        Console.WriteLine("Age: {0}", Age);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        C c = new C();
        c.Name = "Allyson";
        c.Location = "United States of America";
        c.Age = 32;
        c.GetName();
        c.GetLocation();
        c.GetAge();
        Console.WriteLine("Press any key to exit World");
        Console.ReadLine();
    }

}