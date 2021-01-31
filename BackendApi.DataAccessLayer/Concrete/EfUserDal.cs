using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BackendApi.DataAccessLayer.Abstract;
using BackendApi.Model.Jwt.Entity;

namespace BackendApi.DataAccessLayer.Concrete
{
    public class EfUserDal : EfEntityRepositoryBase<User, JwtTokenProjectDbContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using var context = new JwtTokenProjectDbContext();
            var result = from uoc in context.UserOperationClaim
                join oc in context.OperationClaim
                    on uoc.Id equals oc.Id
                where uoc.UserId == user.UserId
                select new OperationClaim { Id = oc.Id, Name = oc.Name };
            return result.ToList();
        }
    }
}
