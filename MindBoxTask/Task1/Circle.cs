namespace MindBoxTask.Task1;

public class Circle : Figure
{
    private readonly double radius;

    public Circle(double radius)
    {
        this.radius = radius;

        if (radius <= 0)
        {
            throw new ArgumentException("Radius can't be negative or zero");
        }
    }

    public override double GetArea() => Math.PI * Math.Pow(radius, 2);
}