using System;
using System.Collections.Generic;
using System.Text;

namespace Cache.Domain.Entities
{
    public class Person
    {
        public Guid PersonId { get; set; }
        public string Name { get; set; }
        public int Ssn { get; set; }
        public char Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Person(Guid personId, string name, int ssn, char sex, DateTime dateOfBirth)
        {
            PersonId = personId;
            Name = name;
            Ssn = ssn;
            Sex = sex;
            DateOfBirth = dateOfBirth;
        }
    }
}
