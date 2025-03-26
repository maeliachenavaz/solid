class Square : Shape
{
    public double Edge {  get; set; }

    public Square (double edge)
    {
        this.Edge = edge;
    }

    public override double Area()
    {
        double area = this.Edge * this.Edge;

        return area;
    }
}