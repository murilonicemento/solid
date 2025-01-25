namespace SOLID.ISP.Violation;

public interface IRegister
{
  void ValidateData();
  void SaveBank();
  void SendEmail();
}