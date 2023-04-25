public class Person
{
    public string _givenName = "";
    public string _firstName = "";
    
    public Person()
    {
    }

    public void ShowEasterName()
    {
        Console.WriteLine($"{_firstName}, {_givenName}");
    }
    public void ShowWestenName()
    {
        Console.WriteLine($"{_givenName}, {_firstName}");
    }
}

//Person person = new Person();
//person._givenName = "Ma";
//person._firstName = "Heye"
//person.ShowWesternName();
//person.ShowEasternName();

public class House
{
    public string _owner;
    public List<Blind> _blinds = new List<Blind>();
}

public class Job
{
    public string _jobTitle;
    public string _companyName;
    public int _startYear;
    public int _endYear;
    
}