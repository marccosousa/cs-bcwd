namespace uri1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double salary = double.Parse(Console.ReadLine());
            double sales = double.Parse(Console.ReadLine());
            double commission = sales * 0.15; 
            double totalSalary = salary + commission;
            Console.WriteLine($"SALARY = R$ {totalSalary.ToString("F2")}"); 


        }
    }
}

