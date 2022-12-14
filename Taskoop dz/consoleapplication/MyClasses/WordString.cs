namespace consoleapplication.MyClasses
{
    public class WordString
    {
        public string perem;
        public WordString()
        {
            perem = "ergrb egh grtsgvrjenk";
        }
        public string ReverseString()
        {
            string str = "";
            for (int i = perem.Length - 1; i >= 0; i--)
            {
                str += perem[i];
            }
            return str;
        }
        public string UpperFirst()
        {
            string str1 = "";
            str1 += char.ToUpper(perem[0]);
            str1 += perem.Remove(0, 1);
            return str1;
        }
        public string UpperEvery()
        {
            string str2 = "";
            string[] array = perem.Split(" ");
            for (int i = 0; i < array.Length; i++)
            {
                str2 += char.ToUpper(array[i][0]);
                str2+= array[i].Remove(0,1)+" ";

            }
            return str2;
        }
    }
}
