using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace information_data
{
    class Program
    {
        private static string MyLastNAME;

        public static string MyLastNAME1 { get => MyLastNAME; set => MyLastNAME = value; }

        static void Main(string[] args)
        {
            Console.WriteLine("What is your name ?");
            Console.Write("Type your First Name");
            String MyFirstName;
            MyFirstName = Console.ReadLine();
            String MyLastNAME;
            Console.Write("Type your Last name ");
            MyLastNAME = Console.ReadLine();
            String age;
            Console.Write("Type your age");
           age = Console.ReadLine();
            String country;
            Console.WriteLine("type your country");
            country = Console.ReadLine();
            String State;
            Console.WriteLine( "Type your state");
            State = Console.ReadLine();
            String Question;
            Console.WriteLine("Type your question ");
            Question = Console.ReadLine();

             Console.WriteLine("Hello," +" " +  MyFirstName +" " + MyLastNAME +" "+ " " +age +" "+ " " +country+"  " +" " +State +"  "+ Question);
            Console.ReadLine();


             

     

        }
    }
}
