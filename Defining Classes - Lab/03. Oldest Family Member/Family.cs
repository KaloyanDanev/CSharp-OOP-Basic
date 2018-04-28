using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public class Family
    {
        private List<Person> members;
        public Family()
        {
            this.members = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.members.Add(member);
        }

        public Person GetOldestMember()
        {
            Person result = members.OrderByDescending(p => p.age).First();
            return result;
        }
}
