using JsonFlatFileDataStore;
using CDNCompleteDeveloperNetwork.Models;

public class JsonUserRepository
{
    private readonly DataStore _store;
    private readonly IDocumentCollection<User> _users;

    public JsonUserRepository()
    {
        _store = new DataStore("users.json");  // The JSON file where data will be stored
        _users = _store.GetCollection<User>();
    }

    public IEnumerable<User> GetUsers() => _users.AsQueryable();
    public User GetUser(int id) => _users.Find(u => u.Id == id).FirstOrDefault();
    public void AddUser(User user) => _users.InsertOne(user);
    public bool UpdateUser(int id, User user) => _users.ReplaceOne(u => u.Id == id, user);
    public bool DeleteUser(int id) => _users.DeleteOne(u => u.Id == id);
}
