namespace SOLID.LSP.Solution;
public abstract class Parallelogram
{
  public double High { get; private set; }
  public double Width { get; private set; }
  public double Area { get { return High * Width; } }

  protected Parallelogram(int high, int width)
  {
    High = high;
    Width = width;
  }
}