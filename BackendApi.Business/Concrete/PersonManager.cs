using System;
using System.Collections.Generic;
using System.Text;
using BackendApi.Business.Abstract;
using BackendApi.DataAccessLayer.Abstract;
using BackendApi.Model.Entity;

namespace BackendApi.Business.Concrete
{
    public class PersonManager : IPersonService
    {
        private IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }
        public List<Person> PersonList()
        {
            return _personDal.GetAll();
        }

        public Person PersonGetId(int id)
        {
            return _personDal.GetById(id);
        }

        public void Create(Person saveEntity)
        {
            _personDal.Create(saveEntity);
        }

        public void Update(Person updateEntity)
        {
           _personDal.Update(updateEntity);
        }

        public void Delete(Person deleteEntity)
        {
            _personDal.Delete(deleteEntity);
        }
    }
}
