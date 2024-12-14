using API.DTOs;
using API.Entities; 

namespace API;

public interface IUserRepository
{
    void Update(AppUser user);

    Task<bool> SaveAllAsync();

    Task<IEnumerable<AppUser>> GetUserAsync();

    Task<AppUser?> GetUserByIDAsync(int id); //? indicates it can return null value

    Task<AppUser?> GetUserByUsernameAsync(string username);

    Task<IEnumerable<MemberDto>> GetMembersAsync();

    Task<MemberDto?> GetMemberAsync(string username);

}