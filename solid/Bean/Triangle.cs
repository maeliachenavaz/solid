class Triangle : Shape
{
    public double BaseTriangle {  get; set; }
    public double Hauteur { get; set; }

    public Triangle (double baseTriangle, double hauteur)
    {
        this.BaseTriangle = baseTriangle;
        this.Hauteur = hauteur;
    }

    public override double Area()
    {
        double area = (this.BaseTriangle * this.Hauteur) / 2.0;

        return area;
    }
}