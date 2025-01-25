using System;

namespace SOLID.LSP.Solution;
public class Square : Parallelogram
{
  public Square(int high, int width) : base(high, width)
  {
    if (width != high)
      throw new ArgumentException("Os dois lados do quadrado precisam ser iguais");
  }
}