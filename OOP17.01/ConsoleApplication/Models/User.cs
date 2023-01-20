namespace BankSystem.Models;

public class User
{
    public int Id { get; }
    public string Name { get; set; } = "No name";

    public User(int id)
    {
        Id = id;
    }
    public User(int id, string name) : this(id)
    {
        Name = name;
    }

    public override bool Equals(object? obj)
    {
        if (base.Equals(obj))
        {
            System.Console.WriteLine("Links equales");
            return true;
        }
        if (obj == null || obj is not User)
        {
            return false;
        }

        User user = (User)obj;

        return this.Id == user.Id && this.Name == user.Name;
    }

    public override int GetHashCode()
    {
        return Id * 1000 + Name.Length;
    }
}
