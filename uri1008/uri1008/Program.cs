namespace uri1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); 
            int hours = int.Parse(Console.ReadLine());
            double salaryPerHour = double.Parse(Console.ReadLine());
            double salary = salaryPerHour * hours;
            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine($"SALARY = U$ {salary.ToString("F2")}"); 


        }
    }
}
