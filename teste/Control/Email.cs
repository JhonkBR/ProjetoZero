using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace teste.Controle
{
    public class Email
    {

        #region Valida E-mail
        // Método de verificar se o e-mail é válido.

        bool retornoemail;
        public bool ValidaEmailValido(string email)
        {
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            // Usei o regex para validar o e-mail, se essa poha for true o e-mail é valido, caso contrario é falso
            if (rg.IsMatch(email))
            {
                retornoemail = true;
            }

            else
            {
                retornoemail = false;
            }

            return retornoemail;
        }
        #endregion


        #region Enviar E-mail

        // Início do método de enviar o e-mail
        public bool EnviaEmail(string email, int pin)
        {
            using (System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient())
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("projetotestebr@gmail.com", "Mudar@123");

                using (System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage())
                {
                    mail.From = new System.Net.Mail.MailAddress("projetotestebr@gmail.com");

                    if (!string.IsNullOrWhiteSpace(email))
                    {
                        mail.To.Add(new System.Net.Mail.MailAddress(email));
                        mail.Body = "Segue o PIN para reset de senha: " + pin;
                    }
                    else
                    {
                        MessageBox.Show("Campo obrigatório! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    try
                    {
                        smtp.Send(mail);
                        retornoemail = true;
                    }

                    catch (Exception error)
                    {

                        MessageBox.Show("Erro ao enviar: " + error);

                    }

                    return retornoemail;
                }
                #endregion
            }
        }
    }
}





