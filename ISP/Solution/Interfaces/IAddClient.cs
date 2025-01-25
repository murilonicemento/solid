namespace SOLID.ISP.Solution.Interfaces
{
  public interface IAddClient : IRegister
  {
    void ValidateData();
    void SendEmail();
  }
}