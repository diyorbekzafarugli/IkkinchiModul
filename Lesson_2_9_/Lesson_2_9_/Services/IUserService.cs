using Lesson_2_9_.Dtos;

namespace Lesson_2_9_.Services;

public interface IUserService
{
    public Guid AddUser(UserCreateDto userCreateDto);
    public List<UserGetDto> GetAllUsers();
    public UserGetDto? GetUserById(Guid id);
    public bool DeleteUser(Guid id);
}
