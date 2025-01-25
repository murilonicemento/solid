namespace SOLID.LSP.Violation;
public class AreaCalculation
{
  private static void ObtainRectangleArea(Rectangle ret)
  {
    Console.Clear();
    Console.WriteLine("Calculo da área do Retangulo");
    Console.WriteLine();
    Console.WriteLine(ret.High + " * " + ret.Width);
    Console.WriteLine();
    Console.WriteLine(ret.Area);
    Console.ReadKey();
  }

  public static void Calculate()
  {
    var square = new Square()
    {
      High = 10,
      Width = 5
    };

    ObtainRectangleArea(square);
  }
}