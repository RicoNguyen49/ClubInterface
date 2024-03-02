using System;

interface IClub
{
    //Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //Methods
    public string Fullname();
}

class Members : IClub
{
    //Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }

    //Default constructor
    public Members()
    {
    }

    //Parameterized constructor
    public Members(int id, string firstName, string lastName, string email, int age, string address)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Age = age;
        Address = address;
    }
    //display
    public void DisplayMemberInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {Fullname()}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Address: {Address}");
    }

    //return fullname
    public string Fullname()
    {
        return $"{FirstName} {LastName}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Creating a ClubMember object
        Members member1 = new Members(1, "Bob", "Ross", "bobpaints@yahoo.com", 65, "407 cental St");

        //Displaying member information
        member1.DisplayMemberInfo();
    }
}
