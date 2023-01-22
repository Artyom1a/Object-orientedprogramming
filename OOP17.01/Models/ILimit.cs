namespace BankSystem.Models;

public interface ILimit
{
    int MaxOperations { get; }
    int MaxSum { get; }
}