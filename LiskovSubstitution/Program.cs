// See https://aka.ms/new-console-template for more information
using LiskovSubstitution;

Console.WriteLine("Hello, World!");

//Square square = new Square();
//square.Width = 15;
//Console.WriteLine($"Area of square: {square.GetArea()}");
//var rectangle = Geometry.GetRectangle(15, 20);

Rectangle rectangle = new Rectangle();
rectangle.Width = 15;
rectangle.Height = 20;

Square square = new Square();
square.EdgeLength = 5;

Console.WriteLine(rectangle.GetArea());
Console.WriteLine(square.GetArea());

/*
 * Miras alan nesne; veren nesnenin davranışını değiştirmemeli.
 */
