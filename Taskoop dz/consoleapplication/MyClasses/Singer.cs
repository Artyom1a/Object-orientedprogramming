namespace consoleapplication.MyClasses // Note: actual namespace depends on the project name.
{

    public class Singer
    {
        public string Name(string imy)
        {
            string firstname = "";
            if (!string.IsNullOrEmpty(imy))
            {
                firstname = imy;
            }
            return firstname;
        }
        public string Surname(string fam)
        {
            string lastname = "";
            if (!string.IsNullOrEmpty(fam))
            {
                lastname = fam;
            }
            return lastname;
        }
        public void GetАutograph(string firstname)
        {
            System.Console.WriteLine($"{firstname}, with best wishes");
        }
    }
}
