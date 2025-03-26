class AreaCalculator
{
    public static double TotalArea(Shape[] shapeArr)
    {
        double area = 0;

        foreach (var shape in shapeArr)
        {
            area += shape.Area();
        }

        return area;
    }
}