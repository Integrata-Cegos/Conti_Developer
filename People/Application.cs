using Javacream.Util;
using Javacream.People;
using Javacream.BusinessObjects;
using Javacream.Music;

public static class Application{
    public static University CreateDefaultUniversity(){
        return new University("LMU", new Address(81371, "München", "Marienplatz"));
    }
    public static Company CreateDefaultCompany(){
        Company c = new Company("Javacream", new Address(81371, "München", "Karlsplatz"));
        c.AddDepartmentAddress("dep1", new Address(33333, "Berlin", "Karlsplatz"));
        c.AddDepartmentAddress("dep2", new Address(44444, "Hamburg", "Karlsplatz"));
    return c;
    }

    public static Person CreateDefaultPerson(){
        Person p = new Person("Sawitzki", "Rainer", 183, Gender.Male);
        p.address = new Address(81371, "München", "Marienplatz");
        return p;
    }
    public static Student CreateDefaultStudent(){
        Student s = new Student("Einstein", "Albert", 163, Gender.Male, CreateDefaultUniversity());
        s.address = new Address(30333, "Berlin", "Alexanderplatz");
        return s;
    }
    public static Worker CreateDefaultWorker(){
        Worker w = new Worker("Schufter", "Johanna", 163, Gender.Female, CreateDefaultCompany());
        w.address = new Address(70000, "Stutgart", "Alexanderplatz");
        return w;
    }

    public static void TestCompany(){
        Company c = CreateDefaultCompany();
        Console.WriteLine(c.MainAddress.City);
    }
    public static void TestUniversity(){
        University u = CreateDefaultUniversity();
        Console.WriteLine(u.Address.City);
    }

    public static void TestPeople(){
        Person p = Application.CreateDefaultPerson();
        Student s = Application.CreateDefaultStudent();
        Worker w = Application.CreateDefaultWorker();
        Console.WriteLine("Debug to check people!");
    }

}