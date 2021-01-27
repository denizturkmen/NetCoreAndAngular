using System;
using System.Collections.Generic;
using System.Text;
using BackendApi.DataAccessLayer.Abstract;
using BackendApi.Model.Entity;

namespace BackendApi.DataAccessLayer.Concrete
{
    public class EfCorePersonDal : EfCoreGenericRepository<Person,DataContext>,IPersonDal
    {
       
    }
}
