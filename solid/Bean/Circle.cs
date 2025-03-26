class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        this.Radius = radius;
    }

    public override double Area()
    {
        double area = this.Radius * this.Radius * Math.PI;

        return area;
    }
}