namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line comparison computation program");

            //Length between two points UC1
            Console.WriteLine("Enter x1 y1 x2 y2 respectively");

            double[] points = new double[4];

            for(int i = 0; i < points.Length; i++)
            {
                points[i] = Convert.ToDouble(Console.ReadLine());
            }
            double x1 = points[0],y1 = points[1],x2 = points[2],y2 = points[3];

            double length = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));

            Console.WriteLine("Length between two points is {0}",length);
        }
    }
}