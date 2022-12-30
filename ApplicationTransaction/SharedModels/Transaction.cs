//id 
//comment
//value
//date
//userid

using System;

namespace AppTransaction.ShareModels;

public class Transaction
{
    public int ID { get; }
    public string Comment { get; set; }
    public decimal Value { get; set; }
    public DateTime Date { get; set; }
    public int UserId { get; }
    // private readonly int _userId;
    // public int UserId { get => _userId; }
    public Transaction(int id, int userid)
    {
        ID = id;
        UserId = userid;
    }
    public Transaction(int id, int userid, string comment, decimal value, DateTime date) : this(id, userid)
    {

        Comment = comment;
        Value = value;
        Date = date;
    }
    public override string ToString()
    {
        return $"{ID}. {Date:dd/MM/yyyy} {Value:N3} Br {Comment}";
    }
}

