using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Windows.Forms;

namespace reaction_time
{
    public partial class Form1 : Form
    {
        private DateTime startTime;
        private DateTime endTime;
        private bool check = false;
        private string reactionTimesFilePath;

        public Form1()
        {
            InitializeComponent();
            reactionTimesFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", "reaction_time.txt");
            this.BackColor = Color.Gray;
            // Create the file if it doesn't exist
            if (!File.Exists(reactionTimesFilePath))
            {
                File.Create(reactionTimesFilePath).Close();
            }
        }

        void wait()
        {
            if (!check)
            {
                this.BackColor = Color.LightBlue;
            }

            Random rnd = new Random();
            int random = rnd.Next(2000, 10000);
            Thread.Sleep(random);

            this.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            startTime = DateTime.Now;
        }

        private void click_Click(object sender, EventArgs e)
        {
            check = true;
            endTime = DateTime.Now;

            TimeSpan elapsedTime = endTime - startTime;
            time.Text = elapsedTime.ToString();

            // Save the reaction time to the text file
            SaveReactionTime(elapsedTime);
        }

        private void start_Click(object sender, EventArgs e)
        {
            check = false;
            wait();
        }

        private void SaveReactionTime(TimeSpan reactionTime)
        {
            // Append the reaction time to the text file
            using (StreamWriter sw = File.AppendText(reactionTimesFilePath))
            {
                sw.WriteLine($"{DateTime.Now}: {reactionTime}");
            }
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            // Read the content from the file and display it in the TextBox
            if (File.Exists(reactionTimesFilePath))
            {
                string content = File.ReadAllText(reactionTimesFilePath);
                prev_times.Text = content;
            }
            else
            {
                prev_times.Text = "File not found.";
            }
        }
        MailMessage mailMessage = new MailMessage();

        private void send_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential("maengelruege@gmail.com", "dgbk sjpr ssol oeyg\r\n");




                // Create a MailMessage object.

                // Set the From, To, Subject, and Body properties of the MailMessage object.
                mailMessage.From = new MailAddress("maengelruege@gmail.com");
                mailMessage.To.Add(new MailAddress("abbas@ali-raza.net"));
                mailMessage.Subject = "Mängelrüge";
                mailMessage.Body = "reaction time";
                // Create an Attachment object and add it to the Attachments collection of the MailMessage object.
                Attachment attachment = new Attachment(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", "reaction_time.txt"));
                mailMessage.Attachments.Add(attachment);

                // Send the email.
                smtpClient.Send(mailMessage);

                // Display a message to the user.
                MessageBox.Show("Email sent successfully!");
            }
            catch 
            {
                MessageBox.Show("There was some problem");
            }
            
        }
    }
}
