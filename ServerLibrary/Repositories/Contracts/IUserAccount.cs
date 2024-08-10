using BaseLibrary.DTOs;
using BaseLibrary.Responses;


namespace ServerLibrary.Repositories.Contracts
{
    public interface IUserAccount // Interface for the UserAccount
    {
        Task<GeneralResponse> CreateAsync(Register user); // Create a new user
        Task<LoginResponse> SignInAsync(Login user); // Sign in a user
        Task<LoginResponse> RefreshTokenAsync(RefreshToken token); // Refresh the token
    }
}
