namespace consoleapplication.MyClasses
{
    internal class Vlidator
    {
        string? email;
        string? data;
        string? tel;

        public Vlidator()
        {
            System.Console.WriteLine("Class Validator");
            email = Console.ReadLine();
            System.Console.WriteLine("Write data in format dd/mm/yy");
            data = Console.ReadLine();
            tel = Console.ReadLine();
        }
        public bool IsEmail()
        {
            bool resultt = false;
            if (email.Contains("mail"))
            {
                resultt = true;
            }
            return resultt;
        }
        public bool IsUrl()
        {
            bool resultt = false;
            if (email.Contains("https://") || email.Contains("http://"))
            {
                resultt = true;
            }
            return resultt;
        }
        public bool IsDate()
        {
            bool resultt = false;
            if (data.Contains("/") && data.Length == 8)
            {
                resultt = true;
            }
            return resultt;
        }
        public bool IsPhone()
        {
            bool resultt = false;
            if (tel.Contains("+") && tel.Length == 8)
            {
                resultt = true;
            }
            return resultt;
        }

    }
}