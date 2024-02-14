using BaseLibrary.DTOs;
using BaseLibrary.Responses;
using ClientLibrary.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientLibrary.Services.Implementations
{
    public class UserAccountService : IUserAccountService
    {
        public Task<GeneralResponse> CreateAsync(Register user)
        {
            throw new NotImplementedException();
        }

        public Task<LoginResponse> SignInAsync(Login user)
        {
            throw new NotImplementedException();
        }

        public Task<LoginResponse> RefreshTokenAsync(RefreshToken user)
        {
            throw new NotImplementedException();
        }

        public Task<WeatherForecast[]> GetWeatherforecasts()
        {
            throw new NotImplementedException();
        }
    }
}