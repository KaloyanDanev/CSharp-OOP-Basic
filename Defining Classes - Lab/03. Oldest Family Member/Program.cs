using System;
using System.Linq;
using System.Reflection;

namespace OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var family = new Family();
            for (int i = 0; i < N; i++)
            {
                string[] people = Console.ReadLine().Split();
                string name = people[0];
                int age = int.Parse(people[1]);
                family.AddMember(new Person(name,age));
            }
            Console.WriteLine($"{family.GetOldestMember().name} {family.GetOldestMember().age}");
        }
    }
}
