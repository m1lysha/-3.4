class Program
{
    static void Main(string[] args)
    {
        
        double x = 0.1;
       
        double endX = 2.1;
      
        double step = 0.1;

        Console.WriteLine("xtty");
        Console.WriteLine("---------------------");

       
        while (x <= endX)
        {
            
            double y = Math.Pow(x, 2) - x * Math.PI * Math.Cos(Math.PI * x);

           
            Console.WriteLine($"{x:F1}tt{y:F4}");

           
            x += step;
        }
    }
}