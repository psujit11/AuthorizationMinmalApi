using Requirements.DTOs;
using static Requirements.DTOs.ServiceResponses;

namespace Requirements.Contracts
{
    public interface IUserAccount
    {
        Task<GeneralResponse> CreateAccount(UserDto userDTO);
        Task<LoginResponse> LoginAccount(LoginDto loginDTO);
        Task<GeneralResponse> AddNewAdmin(UserDto adminDTO);
    }
}
