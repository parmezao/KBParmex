using JDKB.Helpers;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace JDKB.Email
{
    public class Sender
    {
        private readonly string _MyEmail;
        private readonly string _MyPassword;
        private readonly string _Host;
        private readonly int _Port;

        public Sender(string MyEmail, string MyPassword, string Host, int Port)
        {
            _MyEmail = MyEmail;
            _MyPassword = MyPassword;
            _Host = Host;
            _Port = Port;
        }

        private SmtpClient GetSmtp()
        {
            var _smtp = new SmtpClient();

            var credential = new NetworkCredential()
            {
                UserName = _MyEmail,
                Password = _MyPassword
            };

            _smtp.Credentials = credential;
            _smtp.Host = _Host;
            _smtp.Port = _Port;
            _smtp.EnableSsl = false;

            return _smtp;
        }

        private string GetURL()
        {
#if !DEBUG
            return "/";          
#endif

#if DEBUG
            return "http://localhost:54396/";
#endif
        }

        public async Task<bool> SendWellcome(EmailFormModel emailFormModel)
        {
            var message = new MailMessage();

            message.To.Add(new MailAddress(emailFormModel.FromEmail));
            message.From = new MailAddress(_MyEmail, "WebTips");
            message.Subject = "Bem vindo(a) ao WebTips";
            message.Body =
                "<!DOCTYPE html>" +
                "<html>" +
                "<head>" +
                "<title>WebTips - Bem vindo(a)</title>" +
                "</head>" +
                "<body style=\"margin:0;padding:10px;font-family:Helvetica,Arial,sans-serif;font-weight:300;background-color:#ffffff;max-width:600px;margin:0 auto;text-align:center;color:#333333;\">" +
                "<h2 style=\"color:#0fad00\">Bem vindo(a) ao WebTips</h2>" +
                "<h3>Prezado(a), " + emailFormModel.FromName + "</h3>" +
                "<p style=\"font-size:20px;color:#5C5C5C;\">" +
                "    Muito obrigado por se cadastrar no WebTips. Faça o login para aproveitar as dicas e não se esqueça, compartilhar é uma dádiva!" +
                "</p>" +
                "<a href=\"" + GetURL() + "login\" target=\"_blank\" style=\"background-color:#1979bb;display:inline-block;padding:7px 15px;border-radius:5px;color:#fff;text-decoration:none;margin-bottom:40px\">Login</a>" +
                "</body>" +
                "</html>";
            message.IsBodyHtml = true;

            using (var _smtp = GetSmtp())
            {
                await _smtp.SendMailAsync(message);
            }

            return await Task.FromResult(true);
        }

        public async Task<bool> SendConfirmation(EmailFormModel emailFormModel, int UserId)
        {
            //cria o hash com os dados
            Dictionary<string, string> dict = new Dictionary<string, string>
            {
                { "dateCreate", DateTime.Now.ToString("o") },
                { "dateExpire", DateTime.Now.AddHours(24).ToString("o") },
                { "userId", UserId.ToString() },
                { "Method", "ConfirmEmail" }
            };

            var hash = CryptAES.Encrypt(dict.ToDebugString());

            var message = new MailMessage();

            message.To.Add(new MailAddress(emailFormModel.FromEmail, emailFormModel.FromName));
            message.From = new MailAddress(_MyEmail, "JDKB - Base de Conhecimento");
            message.Subject = "Confirmar email";
            message.Body =
                "<!DOCTYPE html>" +
                "<html>" +
                "<head>" +
                "<title>JDKB - Confirmar email</title>" +
                "</head>" +
                "<body style=\"margin:0;padding:10px;font-family:Helvetica,Arial,sans-serif;font-weight:300;background-color:#ffffff;max-width:600px;margin:0 auto;text-align:center;color:#333333;\">" +
                "<h2 style=\"color:#0fad00\">Olá</h2>" +
                "<p style=\"font-size:20px;color:#5C5C5C;\">" +
                "    Obrigado por se cadastrar. Confirme seu email com o link (esse link vai expirar em 24 horas):" +
                "</p>" +
                "<a href=\"" + GetURL() + "confirm?hash=" + hash + "\" target=\"_blank\" style=\"background-color:#1979bb;display:inline-block;padding:7px 15px;border-radius:5px;color:#fff;text-decoration:none;margin-bottom:40px\">Confirmar meu email</a>" +
                "</body>" +
                "</html>";
            message.IsBodyHtml = true;

            using (var _smtp = GetSmtp())
            {
                await _smtp.SendMailAsync(message);
            }

            return await Task.FromResult(true);
        }

        public async Task<bool> SendRecover(EmailFormModel emailFormModel, int UserId)
        {
            //cria o hash com os dados
            Dictionary<string, string> dict = new Dictionary<string, string>
            {
                { "dateCreate", DateTime.Now.ToString("o") },
                { "dateExpire", DateTime.Now.AddHours(24).ToString("o") },
                { "userId", UserId.ToString() },
                { "Method", "RecoverPassword" }
            };

            var hash = CryptAES.Encrypt(dict.ToDebugString());

            var message = new MailMessage();

            message.To.Add(new MailAddress(emailFormModel.FromEmail, emailFormModel.FromName));
            message.From = new MailAddress(_MyEmail, "JDKB - Base de Conhecimento");
            message.Subject = "Recuperar senha";
            message.Body =
                "<!DOCTYPE html>" +
                "<html>" +
                "<head>" +
                "<title>JDKB - Recuperar senha</title>" +
                "</head>" +
                "<body style=\"margin:0;padding:10px;font-family:Helvetica,Arial,sans-serif;font-weight:300;background-color:#ffffff;max-width:600px;margin:0 auto;text-align:center;color:#333333;\">" +
                "<h2 style=\"color:#0fad00\">Olá " + emailFormModel.FromName + "</h2>" +
                "<p style=\"font-size:20px;color:#5C5C5C;\">" +
                "    Para redefinir sua senha, clique no link abaixo: (esse link vai expirar em 24 horas):" +
                "</p>" +
                "<a href=\"" + GetURL() + "Recoverconfirm?hash=" + hash + "\" target=\"_blank\" style=\"background-color:#1979bb;display:inline-block;padding:7px 15px;border-radius:5px;color:#fff;text-decoration:none;margin-bottom:40px\">Redefinir minha senha</a>" +
                "<p style=\"font-size:10px;color:gray;\">" +
                "Se você não solicitou a recuperação da senha, favor desconsiderar esse email" +
                "</p>" +
                "</body>" +
                "</html>";
            message.IsBodyHtml = true;

            using (var _smtp = GetSmtp())
            {
                await _smtp.SendMailAsync(message);
            }

            return await Task.FromResult(true);
        }

    }
}
