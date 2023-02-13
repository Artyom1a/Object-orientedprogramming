//using ConsoleApp1;
//using System;

//namespace MyApp // Note: actual namespace depends on the project name.
//{
//    internal class Program
//    {
//        //delegate int CalculateValues(int number1, int number2, int number3);
//        ////delegate void CalculateValues(double number);
//        //delegate void UserDecorator(ref User user);

//        public delegate void CalculateValues(double number);
//        static void Main(string[] args)
//        {
//            //    CalculateValues method = new InnerProgram1().Sum;
//            //    Console.WriteLine(method(5, 2, 4));
//            //    InnerProgram1 innerProgram1= new InnerProgram1();
//            //    method = innerProgram1.Multiplication;
//            //    Console.WriteLine(method(5, 2, 4));
//            //    Test test = new Test();
//            //    method = test.CustomCalculated;
//            //    Console.WriteLine(method(5, 2, 4));


//            //}

//            //public class InnerProgram1
//            //{
//            //    public int Sum(int number1, int number2, int number3)
//            //    {
//            //        return number1 + number2 + number3;
//            //    }
//            //    public int Multiplication(int number1, int number2, int number3)
//            //    {
//            //        return number1 * number2 * number3;
//            //    }
//            //CalculateValues method = Mult2;
//            //method += Mult3;
//            //method += Sqr;
//            //method(5);
//            //Console.WriteLine("_________________");
//            //method -= Mult2;
//            //method(5);
//            //Console.WriteLine("_________________");
//            //method -= Mult3;
//            //method(6);


//            //User user = null;
//            //UserDecorator decorator = AddName;
//            //decorator += AddAge;
//            //decorator += AddId;
//            //decorator += AddName;
//            //decorator(ref user);
//            //Console.WriteLine(user);

//            CalculateValues method = delegate (double value)
//            {
//                Console.WriteLine((value + value) / 3);
//            };

//            method(5);
   
//            method = (double value) =>
//            {
//                Console.WriteLine((value + value) / 3);
//            };
//            method(5);
//            Test(method);
//            List<int> lsit 

//            List<int> newlist = lsit.
            

//        }

//        //public static void CreateUser(ref User user)
//        //{
//        //    user = new User();
//        //}

//        //public static void AddId(ref User user)
//        //{
//        //    user.Id=5;
//        //}

//        //public static void AddName(ref User user)
//        //{
//        //    if (user == null) CreateUser(ref user);
//        //    user.Name = "Tom";
//        //}

//        //public static void AddAge(ref User user)
//        //{
//        //    //user = new User();
//        //    user.Age = 15;
//        //}


//        //public static void Mult2(double x)
//        //{ Console.WriteLine($"Mult2 {x * 2}"); }

//        //public static void Mult3(double x)
//        //{ Console.WriteLine($"Mult3 {x * 3}"); }

//        //public static void Sqr(double x) { Console.WriteLine($"Sqr {x * x}"); }

//        public static void Test(CalculateValues method)
//        {
//            Console.WriteLine("vvedity chislo");
//            double x = Convert.ToDouble(Console.ReadLine());
//            method(x);
//        }




//    }
//}