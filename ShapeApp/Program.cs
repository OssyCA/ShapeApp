namespace ShapeApp
{
    internal class Program
    {
        // Ossy Drakeneld 24NET
        static void Main(string[] args)
        {
            // Create an instance of Circle with a radius of 5
            Circle circle = new(5);

            // Create another instance of Circle with a radius of 6
            Circle circle2 = new(6);

            // Create an instance of Triangle with height = 5 and base (width) = 6
            Triangle triangle = new(5, 6);

            Console.WriteLine(circle.GetArea());
            Console.WriteLine(circle2.GetArea());

            Console.WriteLine(circle.GetVolym(true));
            Console.WriteLine(circle2.GetVolym(false));

            Console.WriteLine(triangle.GetArea());
            Console.WriteLine(triangle.GetPerimeter(2, 10));
        }
    }
}
