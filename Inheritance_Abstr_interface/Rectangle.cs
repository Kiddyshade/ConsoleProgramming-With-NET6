// See https://aka.ms/new-console-template for more information

class Rectangle : Shapes,IShapes {
    public double Width { get; set; }
    public double GetArea()
    {
        return Length * Width;
    }
}
