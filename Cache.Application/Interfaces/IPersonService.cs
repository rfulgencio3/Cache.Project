using Cache.Application.DTOs;
using System;
using System.Collections.Generic;

namespace Cache.Application.Interfaces
{
    public interface IPersonService : IDisposable
    {
        IEnumerable<PersonDto> GetAllPersons();
        PersonDto GetPersonBySsn(int ssn);
        PersonDto InsertPerson(PersonDto personDto);
    }
}
