using MyTools;

public class Program
{
    static void Main()
    {
        Person person1 = new Person("Elpheba", 22, "Green");
        Person person2 = new Person("Galinda", 21, "Pink");

        Tools.Greet(person1);
        Tools.Greet(person2);
    }
}