using System;

class Faculty : Person
{
  public string Id{get; set;}
  public string Title {get; set;}
  public DateTime DateOfEmployment {get; set;}
  public string Employer {get; set;}
  public bool Tenured {get; set;}

  public Faculty() : base()
  {
    Console.WriteLine("Faculty constructor");
    Title="Instructor";
  }

  public Faculty(string fname, string lname) : base(fname, lname)
  {
    Console.WriteLine("Faculty constructor");
    Title="Instructor";
  }

  public void GrantTenure()
  {
    if ((((DateTime.Today - DateOfEmployment).TotalDays)/365) >=5.00)
      Tenured = true;
    else
      Tenured = false;
  }


  public void Promote()
  {
    if (((((DateTime.Today - DateOfEmployment).TotalDays)/365) > 2.00) && (Title == "Instructor"))
      {
        Title = "Assistant Professor";
        Console.WriteLine("Faculty promoted to Assistant Professor rank");
      }
   else if (((((DateTime.Today - DateOfEmployment).TotalDays)/365) > 5.00) && (Title == "Assistant Professor"))
      {
        Title = "Associate Professor";
        Console.WriteLine("Faculty promoted to Associate Professor rank");
      }
    else if (((((DateTime.Today - DateOfEmployment).TotalDays)/365) > 10.00) && (Title == "Associate Professor"))
      {
        Title = "Professor";
        Console.WriteLine("Faculty promoted to Professor rank");
      }
    else if (Title == "Professor")
      Console.WriteLine("No more promotion possible");
  }


      
  public override void Intro()
  {
    base.Intro();
    Console.WriteLine("Hello, I am " + FirstName + " " + LastName);
    Console.WriteLine("I work as a " + Title + " at " + Employer + " since " + DateOfEmployment);
  }
}