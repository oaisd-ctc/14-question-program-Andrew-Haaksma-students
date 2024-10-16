   // See https://aka.ms/new-console-template for more information
using System;

public class Program
{
        public static string name;
        public static string age;
        public static string eye;
        public static string hair;
        public static string shoe;
        public static string color;
        public static string movie;
        public static string teacher;
        public static string study;
        public static string holiday;
        public static string season;
        public static string dream;
        public static string siblings;
        public static int number;



    public static void Main(string[] args)
    {
        AskName();
        AskAge();
        AskEye();
        AskHair();
        AskShoe();
        AskMovie();
        AskColor();
        AskTeacher();
        AskStudy();
        AskHoliday();
        AskSeason();
        AskDream();
        AskSiblings();
        AskNumber();
        InfoText();
    }

    public static void AskName()
    {
        Console.WriteLine("enter your name: ");
        name = Console.ReadLine();
    }
    public static void AskAge()
    {
        Console.WriteLine("enter your age: ");
        age = Console.ReadLine();
    }
    public static void AskEye()
    {
        Console.WriteLine("enter your eye color: ");
        eye = Console.ReadLine();
    }
    public static void AskHair()
    {
        Console.WriteLine("enter your hair color: ");
        hair = Console.ReadLine();
    }
    public static void AskShoe()
    {
        Console.WriteLine("enter your shoe size: ");
        shoe = Console.ReadLine();
    }
    public static void AskMovie()
    {
        Console.WriteLine("enter your favorite movie: ");
        color = Console.ReadLine();
    }
    public static void AskColor()
    {
        Console.WriteLine("enter your favorite color: ");
        movie = Console.ReadLine();
    }
    public static void AskTeacher()
    {
        Console.WriteLine("enter your favorite teacher: ");
        teacher = Console.ReadLine();
    }
    public static void AskStudy()
    {
        Console.WriteLine("enter your favorite class: ");
        study = Console.ReadLine();
    }
    public static void AskHoliday()
    {
        Console.WriteLine("enter your favorite holiday: ");
        holiday = Console.ReadLine();
    }
    public static void AskSeason()
    {
        Console.WriteLine("enter your favorite season: ");
        season = Console.ReadLine();
    }
    public static void AskDream()
    {
        Console.WriteLine("enter your dream job: ");
        dream = Console.ReadLine();
    }
    public static void AskSiblings()
    {
        Console.WriteLine("enter amount of siblings: ");
        siblings = Console.ReadLine();
    }
    public static void AskNumber()
    {
        number = int.Parse(age);
    }
    public static void InfoText()
    {
        Console.WriteLine("My friend's name is " + name + ". " + name + " is " + age + " years old. " + name + 
        " eye color is " + eye + " with " + hair + " hair and a pair of size " + shoe + " shoes and on them should be " 
        + color + " his favorite color. Which he uses to walk to school with. " + "He also loves the movie " + movie 
        + ". " + name + " favorite class of the day is " + study + " he hopes to go into " + dream 
        + "as his dream job and is always able to go and ask " + teacher + " if he has any problems. " 
        + " Though he does love " + holiday +  " and he does love " + season + ". " + name + " has " + siblings 
        + " sibling with him during his time at highschool and in five years " + name + " will be " + (number + 5) + ".");
    }
    
}