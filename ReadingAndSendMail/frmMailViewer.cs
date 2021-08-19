using System;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;

namespace ReadingAndSendMail
{
    public partial class frmMailViewer : Form
    {
        public frmMailViewer(MailMessage SelectedMail, string SelMailAtchPath, string SelectedMailDate)
        {
            InitializeComponent();
            txtFrom.Text = SelectedMail.From.ToString();
            txtMailCap.Text = SelectedMail.Subject;
            SelectedMail.Attachments.FirstOrDefault();

            wbMessageText.DocumentText = SelectedMail.Body;

            txtAttachmentName.Text = Path.GetFileName(SelMailAtchPath).Substring(2, Path.GetFileName(SelMailAtchPath).Length - 2);

            wbAttchFileCon.Navigate(SelMailAtchPath);

            dtpMailDate.Value = Convert.ToDateTime(SelectedMailDate);
        }

    }
}
