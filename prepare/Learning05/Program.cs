using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> Shapes = new List<Shape>();
        Square mySquare = new Square("blue", 3);
        Rectangle myRectangle = new Rectangle("pink", 6, 4);
        Circle myCircle = new Circle("yellow", 5);
        Shapes.Add(mySquare);
        Shapes.Add(myRectangle);
        Shapes.Add(myCircle);
        foreach(Shape myShape in Shapes)
        {
            Console.WriteLine($"{myShape.GetColor()}, {myShape.GetArea():F2}");
        }
    }
}