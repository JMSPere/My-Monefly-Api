﻿using MonefyWeb.DomainServices.Models.Models.Users;
using MonefyWeb.Transversal.Models;

namespace MonefyWeb.Infraestructure.Repository.Contracts
{
    public interface IUserRepository
    {
        UserDataResponseBe GetUserData(long UserId);
        UserLoginResponseBe LoginUser(LoginRequestDto Request);
        UserRegisterResponseBe RegisterUser(RegisterRequestDto Request);
    }
}
