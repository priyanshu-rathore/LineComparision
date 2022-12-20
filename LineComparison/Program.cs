namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line comparison computation program");

            //Length between two points UC1
            Console.WriteLine("Enter first points x1 y1 x2 y2 respectively");

            double[] points = new double[4];

            for(int i = 0; i < points.Length; i++)
            {
                points[i] = Convert.ToDouble(Console.ReadLine());
            }


            
            double x1 = points[0],y1 = points[1],x2 = points[2],y2 = points[3];

            Console.WriteLine("given points are x1 = {0}, x2 = {1}, y1 = {2}, y3 = {3}",x1,x2,y1,y2);

            double length = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));

            Console.WriteLine("Length between two points is {0}",length);

            //second points

            Console.WriteLine("Enter second points x1 y1 x2 y2 respectively");

            double[] point = new double[4];

            for (int i = 0; i < point.Length; i++)
            {
                point[i] = Convert.ToDouble(Console.ReadLine());
            }



            double a1 = points[0], b1 = points[1], a2 = points[2], b2 = points[3];

            Console.WriteLine("given points are x1 = {0}, x2 = {1}, y1 = {2}, y3 = {3}", a1, b1, a2, b2);

            double length2 = Math.Sqrt((a2 - a1)* (a2 - a1) + (b2 - b1) * (b2 - b1));

            Console.WriteLine("Length between two points is {0}", length2);

            bool check = length.Equals(length2);

            if(check == true)
            {
                Console.WriteLine("Lines are equal");
            }
            else
            {
                Console.WriteLine("Lines are not equal");
            }
        }
    }
}