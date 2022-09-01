namespace MindBoxTask.Task1;

public class Triangle : Figure
{
    private readonly double a;
    private readonly double b;
    private readonly double c;

    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;

        if (!IsTriangleExists())
        {
            throw new ArgumentException($"Triangle with sides a={a}, b={b}, c={c} doesn't exist");
        }
    }

    public override double GetArea()
    {
        if (IsRightTriangle())
        {
            return CalculateRightTriangle();
        }

        var semiperimeter = GetSemiperimeter();
        return Math.Sqrt(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c));
    }

    private double GetSemiperimeter() => (a + b + c) / 2;

    private double GetHypotenuse() => Math.Max(a, Math.Max(b, c));

    private bool IsTriangleExists()
    {
        return a > 0 && b > 0 && c > 0 &&
               a + b > c &&
               a + c > b &&
               b + c > a;
    }

    private double CalculateRightTriangle()
    {
        var list = new List<double> { a, b, c };
        var hypotenuse = GetHypotenuse();
        list.Remove(hypotenuse);

        return 0.5 * list[0] * list[1];
    }

    private bool IsRightTriangle()
    {
        var hypotenuse = GetHypotenuse();
        return Math.Abs(a * a + b * b + c * c - 2 * hypotenuse * hypotenuse) < double.Epsilon;
    }
}