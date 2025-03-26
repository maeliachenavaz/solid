class Program
{
    public static void Main()
    {
        Shape rectangle = new Rectangle(10, 15);
        Shape circle = new Circle(20);
        Shape triangle = new Triangle(15, 20);
        Shape square = new Square(30);

        Shape[] shapeArr = [square];

        Console.WriteLine("Total area of the list : " + AreaCalculator.TotalArea(shapeArr));
    }
}
