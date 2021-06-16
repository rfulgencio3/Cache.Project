using Cache.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Cache.Data.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly CacheDbContext _cachingDbContext;
        public PersonRepository(CacheDbContext cacheDbContext)
        {
            _cachingDbContext = cacheDbContext;
        }
        public IEnumerable<Person> GetAllPersons()
        {
            return _cachingDbContext.Persons
                .ToList();
        }
        public Person GetPersonBySsn(int ssn)
        {
            return _cachingDbContext.Persons
                .FirstOrDefault(p => p.Ssn == ssn);
        }
        public void InsertPerson(Person person)
        {
            _cachingDbContext.Persons.Add(person);
            _cachingDbContext.SaveChanges();
        }
    }
}