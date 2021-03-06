﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bll.interfaces;
using DAL.Interface;
using DTO;

namespace Bll.Concrete
{
    public class PersonManager: IPersonManager
    {
        private readonly IPersonDAL _personManager;

        public PersonManager(IPersonDAL PersonDAL) { _personManager = PersonDAL; }
        public PersonDTO AddPerson(PersonDTO person)
        {
            return _personManager.CreatePerson(person);
        }

        public void DeletePerson(int id)
        {
            _personManager.DeletePerson(id);
        }

   

        public List<PersonDTO> GetListOfPerson()
        {
            return _personManager.GetAllPerson();
        }

        public PersonDTO UpdatePerson(PersonDTO person)
        {
            return _personManager.UpdatePerson(person);
        }
    }
}