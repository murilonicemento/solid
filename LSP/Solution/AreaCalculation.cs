namespace SOLID.LSP.Solution;
public class AreaCalculation
{
    private static void ObterAreaParalelogramo(Parallelogram ret)
    {
        Console.Clear();
        Console.WriteLine("Calculo da área do Retângulo");
        Console.WriteLine();
        Console.WriteLine(ret.High + " * " + ret.Width);
        Console.WriteLine();
        Console.WriteLine(ret.Area);
        Console.ReadKey();
    }

    public static void Calcular()
    {
        var square = new Square(5, 5);
        var ret = new Rectangle(10, 5);

        ObterAreaParalelogramo(square);
        ObterAreaParalelogramo(ret);
    }
}