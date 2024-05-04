using HotelProject.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;


namespace HotelProject.WebUI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AdminMailViewModel model)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("HotelierAdmin", "vuralsayan01@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);  
            
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);   

            var bodyBuiler = new BodyBuilder(); 
            bodyBuiler.TextBody = model.Body;    
            mimeMessage.Body = bodyBuiler.ToMessageBody();  

            mimeMessage.Subject = model.Subject;   
            
            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);  
            client.Authenticate("vuralsayan01@gmail.com", "application key");   
            client.Send(mimeMessage);   
            client.Disconnect(true);    

            return View();
        }
    }
}
