using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text;
namespace task3_mohamed_elsayed
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //problem 1
            //Console.WriteLine("enter number");
            //string input = Console.ReadLine();
            //int x,  y;bool flag =int.TryParse(input,out x);
            //if (flag)
            //    y = Convert.ToInt32(input);
            // ------------------------------------------
            //problem 2 
            //string input = Console.ReadLine();
            //int x; bool flag = int.TryParse(input, out x);
            //if (flag)
            //    Console.WriteLine(x);
            //else Console.WriteLine("your input is invalid");
            //---------------------------------------------
            //problem 3 
            //int x = 10; string str = "mohamed";double y = 2.2;
            //object o = x;
            //Console.WriteLine(o.GetHashCode());//10
            //o = str;
            //Console.WriteLine(o.GetHashCode());//-1708606982
            //o = y;
            //Console.WriteLine(o.GetHashCode());//-644349949
            //----------------------------------------------
            //problem 4
            //obj o1 = new obj();
            //obj o2 = new obj();
            //o1.x = 10;
            //o2 =o1;
            //o2.x = 20;
            //Console.WriteLine(o1.x);//20
            //-----------------------------------------------
            //problem 5
            //string str = "test";
            //Console.WriteLine(str.GetHashCode());
            //str += "hi willy";
            //Console.WriteLine(str.GetHashCode());
            //----------------------------------------------
            //problem 6
            //StringBuilder SB;
            //SB = new StringBuilder("Hi ");
            //Console.WriteLine(SB);
            //Console.WriteLine(SB.GetHashCode());//58225482
            //SB.Append("Hi Willy");
            //Console.WriteLine(SB);
            //Console.WriteLine(SB.GetHashCode());//58225482 
            //----------------------------------------------
            //problem 7
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            int sum = input1 + input2;
            Console.WriteLine(" Concatenation: Sum is " + input1 + " + " + input2 + " = " + sum);
            Console.WriteLine(" Composite Formatting: Sum is {0} + {1} = {2}", input1, input2, sum);

        }
    }
    public class obj
    {
        public int x;
    }
}
