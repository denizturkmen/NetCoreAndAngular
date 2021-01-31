

using System.Collections.Generic;
using BackendApi.Model.Jwt.Entity;

namespace BackendApi.DataAccessLayer.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
