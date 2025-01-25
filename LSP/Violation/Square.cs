namespace SOLID.LSP.Violation;
public class Square : Rectangle
{
  public override double High
  {
    set { base.High = base.Width = value; }
  }

  public override double Width
  {
    set { base.High = base.Width = value; }
  }
}