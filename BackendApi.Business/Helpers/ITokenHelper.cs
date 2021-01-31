using System;
using System.Collections.Generic;
using System.Text;
using BackendApi.Model.Jwt.Entity;

namespace BackendApi.Business.Helpers
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
