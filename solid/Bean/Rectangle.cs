﻿class Rectangle : Shape
{
    public double Height { get; set; }

    public double Width { get; set; }

    public Rectangle(double height, double width)
    {
        this.Height = height;
        this.Width = width;
    }

    public override double Area()
    {
        double area = Height * Width;

        return area;
    }
}
