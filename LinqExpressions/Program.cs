// LINQ --> System.Linq

var list = new List<Person>
{
    new Person("Can", 34, Gender.Male),
    new Person("Metehan", 22, Gender.Male),
    new Person("Kadir", 21, Gender.Male),
    new Person("Sümeyra", 26, Gender.Female),
    new Person("Tufan", 27, Gender.Male),
    new Person("Esengül", 32, Gender.Female),
    new Person("Berk", 25, Gender.Male),
    new Person("İsmail", 18, Gender.Male)
};

//LINQ Query
var olderPeopleV1 = from person in list
                    where person.Age > 30
                    orderby person.Age descending
                    select person; 

//Fluent LINQ Query
var olderPeopleV2 = list.Where(p => p.Age > 30).OrderByDescending(p => p.Age).ToList();

//SELECT COUNT(0) FROM Persons
var count = list.Count();

//SELECT COUNT(0) FROM Persons WHERE Age > 30
var countOlderThan30 = list.Count(c => c.Age > 30);

//SELECT TOP 1 * FROM Persons ORDER BY Age DESC
var oldest = list.MaxBy(m => m.Age);
Console.WriteLine("En yaşlı : " + oldest.Name);

//SELECT TOP 1 * FROM Persons ORDER BY Age ASC
var youngest = list.MinBy(m => m.Age);
Console.WriteLine("En genç : " + youngest.Name);

//SELECT * FROM Persons WHERE Gender = 2
var females = list.Where(p => p.Gender == Gender.Female).ToList();
//Bakınız : FemaleYield
Console.WriteLine("\n\nKadınlar\n===============");
foreach (var person in females)
{
    Console.WriteLine(person.Name+ " " + person.Age);
}

//SELECT * FROM Person WHERE Age > 25
var elders = list.Where(f => f.Age > 25).ToList();
//SELECT * FROM Person WHERE Age > 23 AND Age < 28 
var middles = list.Where(f => f.Age > 23 && f.Age < 28).ToList();

//SELECT * FROM Persons ORDER BY Age DESC
var orderByAgeDesc = list.OrderByDescending(p => p.Age).ToList();
Console.WriteLine("\n\nBüyükten Küçüğe\n===============");
foreach (var person in orderByAgeDesc)
{
    Console.WriteLine(person.Name+ " " + person.Age);
}

//SELECT * FROM Persons ORDER BY Age ASC
var orderByAgeAsc = list.OrderBy(p => p.Age).ToList();
Console.WriteLine("\n\nKüçükten Büyüğe\n===============");
foreach (var person in orderByAgeAsc)
{
    Console.WriteLine(person.Name+ " " + person.Age);
}

//SELECT * FROM Persons WHERE Age BETWEEN 20 AND 30 ORDER BY Age DESC
Console.WriteLine("\n\n20^li Yaşlar\n===============");
var twenties = list.Where(p => p.Age > 20 && p.Age < 30)
                   .OrderByDescending(o => o.Age)
                   .ToList();
foreach (var person in twenties)
{
    Console.WriteLine(person.Name + " " + person.Age);
}

//SELECT Name FROM Persons
var names = list.Select(s => s.Name).ToList();
Console.WriteLine("\n\nİsimler\n===============");
foreach (var name in names)
{
    Console.WriteLine(name); //Age yazılamaz çünkü select edilmedi
}

// SELECT Name FROM Persons WHERE Age > 30
var olderThan30s = list.Where(p => p.Age > 30).Select(s => s.Name).ToList();
Console.WriteLine("\n\nİsimler\n===============");
foreach (var name in olderThan30s)
{
    Console.WriteLine(name); //Age yazılamaz çünkü select edilmedi
}
record Person(string Name, int Age, Gender Gender);

enum Gender
{
    Male = 1,
    Female = 2
}
/*
public class Person
{
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name { get; init; }
    public string Age { get; init; } // init => yalnızca Constructor'da set edilebilir. field verilemez
}
 */

class Samples
{
    public IEnumerable<Person> FemaleYield(Person person)
    {
        if (person.Gender == Gender.Female)
        {
            yield return person;

        }
    }
}