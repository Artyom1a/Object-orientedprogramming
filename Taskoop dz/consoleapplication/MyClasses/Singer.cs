namespace consoleapplication.MyClasses // Note: actual namespace depends on the project name.
{

    public class Singer
    {
        public string name;
        public string surname;
        public Singer()
        {
            name = "Artyom";
            surname = "Shevchik";
        }
        public void GetАutograph()
        {
            System.Console.WriteLine($"{name},{surname} with best wishes");
        }
    }
}
