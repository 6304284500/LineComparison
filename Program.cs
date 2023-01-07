public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter the value of X1 Coordinates");
        double X1= Convert.ToDouble (Console.ReadLine());
        Console.WriteLine("Please enter the value of  Y1 Coordinates");
        double Y1= Convert.ToDouble (Console.ReadLine());
        Console.WriteLine("Please enter the values of X2 and Y2 Coordinates");
        double X2= Convert.ToDouble (Console.ReadLine());
        double Y2= Convert.ToDouble (Console.ReadLine());

        double distance = Math.Sqrt((Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2)));
        Console.WriteLine("The Lenght of Two points is--- " + distance);
        {
            if ((X1 / X2 == Y1 / Y2))
                Console.WriteLine("The given are straight lines   " + "Lines are Equal");
            else
                Console.WriteLine("The given are not straight lines   " +"Lines are Not Equal");
        }
    }
}
