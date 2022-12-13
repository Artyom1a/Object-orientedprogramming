namespace consoleapplication.MyClasses // Note: actual namespace depends on the project name.
{

    public class Singer
    {
        public string name;
        public string surname;
        public Singer(string firstname,string lastname)
        {
            name = firstname;
            surname = lastname;
        }
        public void GetАutograph(string name,string surname)
        {
            System.Console.WriteLine($"{name},{surname} with best wishes");
        }
    }
}
