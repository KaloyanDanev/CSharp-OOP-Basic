using System;

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
        private set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException($"First name cannot contain fewer than 3 symbols!");
            }
            this.firstName = value;
        }
    }
    public string LastName
    {
        get { return this.lastName; }
        private set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException($"Last name cannot contain fewer than 3 symbols!");
            }
            this.lastName = value;
        }
    }

    public decimal Salary
    {
        get { return this.salary; }
        private set
        {
            if (value < 460)
            {
                throw new ArgumentException($"Salary cannot be less than 460 leva!");
            }
            this.salary = value;
        }
    }

    public int Age
    {
        get { return this.age; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException($"Age cannot be zero or a negative integer!");
            }
            this.age = value;
        }
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
    //public override string ToString()
    //{
    //    return $"{FirstName} {LastName} receives {Salary:f2} leva.";
    //}
}
