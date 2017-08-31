using Domain.Entityes;

namespace Domain.Abstrac
{
    public interface IEmailSending
    {
        void SendMailToAdministrator(Basket basket, OrderDetails details, string attachFile);
        void SendMail(Basket basket, OrderDetails details, string attachFile);
    }
}