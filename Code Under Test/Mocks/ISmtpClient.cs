namespace UnitTestDemo
{
    public interface ISmtpClient
    {
        bool SendMail(string to, string body);
    };    
}
