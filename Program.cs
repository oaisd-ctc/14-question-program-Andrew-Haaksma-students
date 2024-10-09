using System;

public class Program{
    public static void Main(string[] args){
        string name = Console.ReadLine();
        string age = Console.ReadLine();
        string eye = Console.ReadLine();
        string hair = Console.ReadLine();
        string shoe = Console.ReadLine();
        string color = Console.ReadLine();
        string movie = Console.ReadLine();
        string teacher = Console.ReadLine();
        string study = Console.ReadLine();
        string holiday = Console.ReadLine();
        string season = Console.ReadLine();
        string job = Console.ReadLine();
        string siblings = Console.ReadLine();

        Console.WriteLine("My friend's name is " + name + "." + name + " is " + age + " years old. " + name + 
        " eye color is " + eye + " with " + hair + " hair and a pair of a size " + shoe + "shoes and on them should be" 
        + color + "his favorite color. Which he uses to walk to school with." + name + " favorite class of the day is " 
        + study + "with his favorite teacher being" + teacher + "." + "Though he does love" + holiday + 
        " Although he does love " + season + "." + name + "has" + siblings + "with him during his time at highschool and in five years" +
        name + "will be" + (age + 5) + ".");
    }
}