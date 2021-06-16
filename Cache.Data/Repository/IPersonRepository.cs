using Cache.Domain.Entities;
using System.Collections.Generic;

namespace Cache.Data.Repository
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAllPersons();
        Person GetPersonBySsn(int ssn);
        void InsertPerson(Person person);
    }
}