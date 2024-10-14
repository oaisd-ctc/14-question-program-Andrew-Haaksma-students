// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    public static void Main(string[] args)
    {
        /*plug in info*/
        Console.WriteLine("enter your name: ");
        string name = Console.ReadLine();
        int number = int.Parse(age); 

        Console.WriteLine("enter your age: ");
        string age = Console.ReadLine();

        Console.WriteLine("enter your eye color: ");
        string eye = Console.ReadLine();

        Console.WriteLine("enter your hair color: ");
        string hair = Console.ReadLine();

        Console.WriteLine("enter your shoe size: ");
        string shoe = Console.ReadLine();

        Console.WriteLine("enter your favorite movie: ");
        string movie = Console.ReadLine();

        Console.WriteLine("enter your favorite color: ");
        string color = Console.ReadLine();

        Console.WriteLine("enter your favorite teacher: ");
        string teacher = Console.ReadLine();

        Console.WriteLine("enter your favorite class: ");
        string study = Console.ReadLine();

        Console.WriteLine("enter your favorite holiday: ");
        string holiday = Console.ReadLine();

        Console.WriteLine("enter your favorite season: ");
        string season = Console.ReadLine();

        Console.WriteLine("enter your dream job: ");
        string dream = Console.ReadLine();

        Console.WriteLine("enter amount of siblings: ");
        string siblings = Console.ReadLine();

        /*results of info*/
        Console.WriteLine("My friend's name is " + name + ". " + name + " is " + age + " years old. " + name + 
        " eye color is " + eye + " with " + hair + " hair and a pair of size " + shoe + " shoes and on them should be " 
        + color + " his favorite color. Which he uses to walk to school with. " + "He also loves the movie " + movie 
        + ". " + name + " favorite class of the day is " + study + " he hopes to go into " + dream 
        + "as his dream job and is always able to go and ask " + teacher + " if he has any problems. " 
        + " Though he does love " + holiday +  " and he does love " + season + ". " + name + " has " + siblings 
        + " sibling with him during his time at highschool and in five years " + name + " will be " + (number + 5) + ".");
    }
}