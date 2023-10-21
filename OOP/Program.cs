namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Circle circle1 = new Circle(6);
            Circle circle2 = new Circle(5);

            Console.WriteLine("Arean är: " + circle1.getArea() + " i cirkel 1");
            Console.WriteLine("Arean är: " + circle2.getArea() + " i cirkel 2");


        }
    }
}