using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
  public class UserRepository
  {
    private SqlConnection _connection;

    public UserRepository(SqlConnection connection)
    {

    }

    public IEnumerable<User> Get()

      => _connection.GetAll<User>();




    public User Get(int id)

    => _connection.Get<User>(id);




    public void Create(User user)

    => _connection.Insert<User>(user);







  }
}