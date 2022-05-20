// See https://aka.ms/new-console-template for more information

class triangle : Shapes,IShapes {
    public double Hypotenus { get; set; }

    public triangle()
    {

    }
    public triangle(double hypotenus)
    {
        Hypotenus = hypotenus;
    }

    public triangle(double length, double height)
    {
        Length = length;
        Height = height;
    }

    public double GetArea()
    {
        return .5 * Length * Height;
    }
}
