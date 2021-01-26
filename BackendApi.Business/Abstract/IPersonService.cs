using System;
using System.Collections.Generic;
using System.Text;
using BackendApi.Model.Entity;

namespace BackendApi.Business.Abstract
{
    public interface IPersonService
    {
        public List<Person> PersonList();
        public Person PersonGetId(int id);
        public void Create(Person saveEntity);
        public void Update(Person updateEntity);
        public void Delete(Person deleteEntity);
    }
}
