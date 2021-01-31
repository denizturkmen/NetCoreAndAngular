using System;
using System.Collections.Generic;
using System.Text;
using BackendApi.Model.Jwt.Entity;

namespace BackendApi.Business.Abstract
{
    public interface IUserService
    {
        public List<OperationClaim> GetClaims(User user);

        public void Add(User user);

        public User GetByMail(string email);
    }
}
