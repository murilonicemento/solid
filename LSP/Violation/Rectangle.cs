namespace SOLID.LSP.Violation;
public class Rectangle
{
  public virtual double High { get; set; }
  public virtual double Width { get; set; }
  public double Area { get { return High * Width; } }
}