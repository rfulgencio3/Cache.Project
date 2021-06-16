using AutoMapper;
using Cache.Application.DTOs;
using Cache.Data.Repository;
using Cache.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Cache.Application.Services
{
    public class PersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;

        public PersonService(
            IPersonRepository personRepository,
            IMapper mapper
            )
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public IEnumerable<PersonDto> GetAllPersons()
        {
            var response = _personRepository.GetAllPersons();
            return _mapper.Map<IEnumerable<PersonDto>>(response);
        }
        public PersonDto GetPersonBySsn(int ssn)
        {
            var response = _personRepository.GetPersonBySsn(ssn);
            return _mapper.Map<PersonDto>(response);
        }
        public PersonDto InsertPerson(PersonDto personDto)
        {
            var personId = Guid.NewGuid();
            Person person = new Person(personId, personDto.Name, personDto.Ssn, personDto.Sex, personDto.DateOfBirth);

            _personRepository.InsertPerson(person);
            return personDto;
        }
    }
}
