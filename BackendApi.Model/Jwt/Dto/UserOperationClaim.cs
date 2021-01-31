using System;
using System.Collections.Generic;
using System.Text;
using BackendApi.Model.Jwt.Entity;

namespace BackendApi.Model.Jwt.Dto
{
    public class UserOperationClaim : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
