using Lesson_2_9_.Entities;

namespace Lesson_2_9_.Repositories;

public interface IUserRepository
{
    public Guid Add(User user);
    public List<User> GetAll();
    public User? GetById(Guid id);
    public bool Delete(Guid id);
}
