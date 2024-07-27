using Demo.Generics;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region non Generics
            //int A = 5, B = 7;
            //Console.WriteLine($"A = {A} , B = {B}");
            //Helper.SWAP(ref A,ref B);
            //Console.WriteLine($"A = {A} , B = {B}");
            //Console.WriteLine("================");
            //double X = 5.2, Y = 7.5;
            //Console.WriteLine($"A = {X} , B = {Y}");
            //Helper.SWAP(ref X,ref Y);
            //Console.WriteLine($"A = {X} , B = {Y}");

            //Point point = new Point(10, 3);
            //Point point2 = new Point(2, 4);
            //Helper.SWAP(ref point,ref point2);
            //Console.WriteLine($"{point}  \n {point2}"); 
            #endregion

            Employee employee01 = new Employee() { Id = 30, Name = "Mohamed", Salary = 4000 };
            Employee employee02 = new Employee() { Id = 30, Name = "Mohamed", Salary = 4000 };
           if (employee01.Equals(employee02) )
            Console.WriteLine("Yes");
           else
            Console.WriteLine("not");
           
           



        }
    }
}
