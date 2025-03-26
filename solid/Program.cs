class Program
{
    public static void Main()
    {
        Rectangle rectangle = new Rectangle(10, 15);
        Circle circle = new Circle(20);

        object[] listObj = [circle];

        Console.WriteLine("Total area of the list : " + AreaCalculator.TotalArea(listObj));
    }
}
