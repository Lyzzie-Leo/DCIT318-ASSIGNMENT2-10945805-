using System;

abstract class Shape
{
  public abstract double GetArea();
}

class Circle : Shape
{
  private double radius;

  public Circle(double radius)
  {
    this.radius = radius;
  }

  public override double GetArea()
  {
    return Math.PI * Math.Pow(radius, 2);
  }
}

class Rectangle : Shape
{
  private double width;
  private double height;

  public Rectangle(double width, double height)
  {
    this.width = width;
    this.height = height;
  }

  public override double GetArea()
  {
    return width * height;
  }
}

static void Main(string[] args)
{
  Circle circle = new Circle(5);
  Rectangle rectangle = new Rectangle(4, 6);

  Console.WriteLine($"Circle Area: {circle.GetArea()}");
  Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
}
