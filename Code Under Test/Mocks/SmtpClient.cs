namespace UnitTestDemo
{
    class SmtpClient :  ISmtpClient
    {
        public bool SendMail(string to, string body)
        {
            return true;
        }
    }
}
