class AreaCalculator
{
    public static double TotalArea(object[] arrObjects)
    {
        double area = 0;
        Rectangle objRectangle;
        Circle objCircle;

        foreach (var obj in arrObjects)
        {
            if (obj is Rectangle)
            {
                objRectangle = obj as Rectangle;
                area += objRectangle.Height * objRectangle.Width;
            }
            else
            {
                objCircle = obj as Circle;
                area += objCircle.Radius * objCircle.Radius * Math.PI;
            }
        }

        return area;
    }
}