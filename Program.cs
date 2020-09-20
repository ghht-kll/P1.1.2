using System;

enum Genders
{
    Male,
    Female
}
struct Person
{
    public string firstName;
    public string LastName;
    public int age;
    public Genders genders;

    public Person(String firstName, string LastName, int age, Genders genders)
    {
        this.firstName = firstName;
        this.LastName = LastName;
        this.age = age;
        this.genders = genders;
    }

    public override string ToString()
    {
        return firstName + " " + LastName + "(" + genders + "), age" + age;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Tony", "Allen", 20, Genders.Male);
        Console.WriteLine(person.ToString());
    }
}