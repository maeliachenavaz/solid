class Program
{
    public static void Main()
    {
        Rectangle rectangle = new Rectangle(10, 15);
        Circle circle = new Circle(20);
        Triangle triangle = new Triangle(15, 20);

        object[] listObj = [triangle];

        Console.WriteLine("Total area of the list : " + AreaCalculator.TotalArea(listObj));
    }
}
