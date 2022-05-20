
Console.WriteLine("Enter the Length");
double Length = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the Widht");
double Width = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the Height");
double Height = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the Hypotenous");
double hypo = double.Parse(Console.ReadLine());


var cube = new Cube();

//triangle.Length = Length;
//triangle.Height = Height;        instead of this 
var triangle = new triangle() {Height=Height,Length=Length,Hypotenus=hypo};
var triangle1 = new triangle(hypo);
var triangle2 = new triangle(Length, Height);
var Circle = new Circle();
var rectangle = new Rectangle();

cube.Length = Length;
cube.Width = Width; cube.Height=Height;


Circle.Length = Length;
Circle.Height = Height;

rectangle.Length = Length;
rectangle.Width=Width; rectangle.Height=Height;

Console.WriteLine("Area of Cube is: "+cube.GetArea());
Console.WriteLine("Volume of Cube is: "+cube.GetVolume());
Console.WriteLine("Area of triangle is: " + triangle.GetArea());
Console.WriteLine("Area of triangle is: " + triangle1.GetArea());
Console.WriteLine("Area of triangle is: " + triangle2.GetArea());
Console.WriteLine("Area of rectangle is: " + rectangle.GetArea());