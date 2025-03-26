class AreaCalculator
{
    public static double TotalArea(object[] arrObjects)
    {
        double area = 0;
        Rectangle objRectangle;
        Circle objCircle;
        Triangle objTriangle;

        foreach (var obj in arrObjects)
        {
            if (obj is Rectangle)
            {
                objRectangle = obj as Rectangle;
                area += objRectangle.Height * objRectangle.Width;
            }
            else if (obj is Circle)
            {
                objCircle = obj as Circle;
                area += objCircle.Radius * objCircle.Radius * Math.PI;
            }
            else if (obj is Triangle)
            {
                objTriangle = obj as Triangle;
                area += (objTriangle.BaseTriangle * objTriangle.Hauteur) / 2.0;
            }
        }

        return area;
    }
}