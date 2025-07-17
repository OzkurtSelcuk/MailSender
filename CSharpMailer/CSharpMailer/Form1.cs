using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace CSharpMailer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                // GÖNDERİCİ BİLGİLERİ
                string fromEmail = "selcukozkurt668@gmail.com"; // kendi e-posta adresin
                string password = "ziuecccxlmvbcuvz";        // Gmail uygulama şifresi

                // KULLANICIDAN ALINANLAR
                string toEmail = txtTo.Text;
                string subject = txtSubject.Text;
                string body = txtBody.Text;

                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromEmail);
                message.To.Add(toEmail);
                message.Subject = subject;
                message.Body = body;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(fromEmail,password);
                smtp.EnableSsl = true;

                smtp.Send(message);

                MessageBox.Show("Mail başarıyla gönderildi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
    }
}
