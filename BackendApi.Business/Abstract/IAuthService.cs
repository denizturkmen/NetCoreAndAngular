using System;
using System.Collections.Generic;
using System.Text;
using BackendApi.Model.Jwt.Dto;
using BackendApi.Model.Jwt.Entity;

namespace BackendApi.Business.Abstract
{
    public interface IAuthService
    {
       public User Register(UserForRegisterDto userForRegisterDto, string password);
       
       public User Login(UserForLoginDto userForLoginDto);
       
       public bool UserExists(string email);
       public AccessToken CreateAccessToken(User user);
    }
}
