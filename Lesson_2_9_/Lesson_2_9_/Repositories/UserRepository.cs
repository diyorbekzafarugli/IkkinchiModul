using Lesson_2_9_.Entities;

namespace Lesson_2_9_.Repositories;

public class UserRepository : IUserRepository
{
    private List<User> Users;
    public UserRepository()
    {
        Users = new List<User>();
    }

    public Guid Add(User user)
    {
        Users.Add(user);
        return user.UserId;
    }

    public bool Delete(Guid id)
    {
        foreach (var user in Users)
        {
            if (user.UserId == id)
            {
                Users.Remove(user);
                return true;
            }
        }
        return false;
    }

    public List<User> GetAll()
    {
        return Users;
    }

    public User? GetById(Guid id)
    {
        foreach (var user in Users)
        {
            if (user.UserId == id)
            {
                return user;
            }
        }

        return null;
    }
}
