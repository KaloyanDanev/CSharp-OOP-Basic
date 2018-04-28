public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;

    public Person(string firstName, string lastName, int age, decimal salary)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.salary = salary;
    }
    
    public string FirstName
    {
        get { return this.firstName; }
    }
    public string LastName
    {
        get { return this.lastName; }
    }

    public decimal Salary
    {
        get { return this.salary; }
    }
    public int Age
    {
        get { return this.age; }
    }

    public void IncreaseSalary(decimal percentage)
    {
        if (Age > 30)
        {
            salary += salary * percentage / 100;
        }
        else
        {
            salary += salary * percentage / 200;
        }
    }
    public override string ToString()
    {
        return $"{FirstName} {LastName} receives {Salary:f2} leva.";
    }
}
