// See https://aka.ms/new-console-template for more information

class Cube: Shapes
{
    public double Width { get; set; }

    public double GetArea()
    {
        return Length * Height;
    }

    public double GetVolume()
    {
        return Length * Width * Height;
    }
}
