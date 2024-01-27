namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;

            var sum = a + b;
            var difference = a - b;
            var product = a * b;
            var quotient = a / b;
            var remainder = a % b;


            Console.WriteLine($"The sum of {a} and {b} is {sum}");
            Console.WriteLine($"The difference between {a} and {b} is {difference}");
            Console.WriteLine($"The product of {a} and {b} is {product}");
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-----");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var area = AreaOfCircle(radius);
            Console.WriteLine("");
            Console.WriteLine($"The area of your circle is {area}");


        }

        public static double AreaOfCircle(double radius)
        {
            
           return Math.PI * radius * radius;

        }

        
    }
}
