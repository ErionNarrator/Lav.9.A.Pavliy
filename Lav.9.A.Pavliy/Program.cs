try
{
    Console.Write("Введите x1: ");
    double x1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите y1: ");
    double y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите x2: ");
    double x2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите y2: ");
    double y2 = Convert.ToDouble(Console.ReadLine());

    Vector vector = new Vector(x1, y1, x2, y2);
    Console.WriteLine($"Длина вектора: {vector.Length()}");
    vector.DrawConsole(); 
}
catch (Exception err)
{
    Console.WriteLine(err.Message);
}
public class Vector
{
    private double x1, y1, x2, y2;

    public Vector(double x1, double y1, double x2, double y2)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }

 
    public (double, double) Point1
    {
        get { return (x1, y1); }
        set { (x1, y1) = value; }
    }

    public (double, double) Point2
    {
        get { return (x2, y2); }
        set { (x2, y2) = value; }
    }

    public double Length()
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    
    public void DrawConsole()
    {
        Console.WriteLine($"Линия, нарисованная от({x1}, {y1}) до ({x2}, {y2})  толщиной 2 пикселя.");
    }

    
}


