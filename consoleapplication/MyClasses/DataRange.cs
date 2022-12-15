namespace consoleapplication.MyClasses;

public class DataRange
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    // public DataRange(DateTime startDate, DateTime endDate)
    // {
    //     StartDate = startDate;
    //     EndDate = endDate;
    // }
    // public DataRange(int year)
    // {
    //     StartDate = new DateTime(year, 1, 1);
    //     EndDate = new DateTime(year, 12, 31);
    // }
    // public DataRange(DataRange dateRange)
    // {
    //     StartDate = dateRange.StartDate;
    //     EndDate = dateRange.EndDate;
    // }
    public DataRange(DateTime startDate, DateTime endDate)
    {
        StartDate = startDate;
        EndDate = endDate;
    }
    public DataRange(int year) : this(new DateTime(year, 1, 1), new DateTime(year, 12, 31))
    {

    }
    public DataRange(DataRange dateRange) : this(dateRange.StartDate, dateRange.EndDate)
    {

    }

    public override string ToString()
    {
        return $"{StartDate.ToString("dd/MM/yyyy")} -  {EndDate.ToString("dd/MM/yyyy")}";
    }

}