using ActiveUp.Net.Mail;
using ImapLibrary;
using ReadingAndSendMail;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ReadingAndSendMail
{

    public partial class frmMainViewer : Form
    {
        public frmMainViewer()
        {
            InitializeComponent();
        }

        private void btnMailCikar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in lsvGonMailAdr.SelectedItems)
                lsvGonMailAdr.Items.Remove(eachItem);
        }

        private void btnMailEkle_Click(object sender, EventArgs e)
        {
            if (CheckControl("Gönderen mail adresini girmek zorundasınız!", "Hata", edtGonderenMailAdresi)) return;            

            ListViewItem GonMailAdr = lsvGonMailAdr.FindItemWithText(edtGonderenMailAdresi.Text);//varsa ekleme
            if (GonMailAdr != null) return;

            ListViewItem lsvGonMailAdrEx = new ListViewItem();
            lsvGonMailAdrEx.Text = edtGonderenMailAdresi.Text;            
            lsvGonMailAdr.Items.Add(lsvGonMailAdrEx);

            ClearControl(edtGonderenMailAdresi);            
        }
        /// <summary>
        /// Kontrol içerisindeki değerin mail formatına uygunluğunu kontrol eder. 
        /// </summary>
        /// <param name="cControl">Kontrol edilecek komponet</param>
        /// <returns>Kontrol içindeki değer mail formatında ise true döner</returns>
        private bool EmailCheck(Control cControl)
        {
            bool Result = false;
            switch (cControl)
            {
                case TextBox _:
                    Regex mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
                    if (!mRegxExpression.IsMatch(cControl.Text.Trim()))
                    {
                        MessageBox.Show("E-mail adresinizi doğru formatta giriniz", "E-mail Hatası ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cControl.Focus();
                        Result = true;
                    }
                    break;
            }
            return Result;
        }


        private void edtGonderenMailAdresi_Leave(object sender, EventArgs e)
        {
            EmailCheck((TextBox)sender);
        }

        /// <summary>
        /// Dosyayı mail göndermeden önce yeni bir isimle başka bir dizine taşır ve dosyayı mail olarak gönderir. Daha sonra dosya silinir.
        /// </summary>
        /// <param name="sFile">Gönderilecek dosya</param>
        private void FileOperations(string sFile)
        {
            string sOldFileName = Path.GetFileName(sFile);
            string sWarehouse = sOldFileName.Substring(0, 1);
            string sNewFile = Path.GetDirectoryName(sFile) + sOldFileName.Substring(2, sOldFileName.Length - 2);

            try
            {
                File.Move(sFile, sNewFile);
            }
            catch (Exception Ex)
            {
                // MessageBox.Show("Dosya Adı Değiştirilemedi" + Environment.NewLine + Ex.ToString(), "İsim Değiştirme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppendLogAndSend(Ex);
            }
            SendOrderConfirmationMail(sWarehouse, sOldFileName, sNewFile, sFile);

            File.Delete(sNewFile);

        }

        /// <summary>
        /// Exceptionı log tutulabilecek bir text ifadeye çevirir
        /// </summary>
        /// <param name="ex">Exception</param>
        /// <returns>string</returns>
        public string CreateExceptionToErrorText(Exception ex)
        {
            string ErrorlineNo, Errormsg, extype, ErrorLocation;

            var line = Environment.NewLine + Environment.NewLine;

            ErrorlineNo = ex.StackTrace.Substring(ex.StackTrace.Length - 7, 7);
            Errormsg = ex.GetType().Name.ToString();
            extype = ex.GetType().ToString();
            ErrorLocation = ex.Message.ToString();

            string sErrorText = "";
            sErrorText = "-----------" + DateTime.Now.ToString() + " Tarihli Hata Kayıtları" + "-----------------";
            sErrorText += line + "Hata Satırı :" + " " + ErrorlineNo + line + "Hata Mesajı:" + " " + Errormsg + line + "Hata Tipi:" + " " + extype + line + "Hata Yeri :" + " " + ErrorLocation + line;
            sErrorText += "--------------------------------*End*------------------------------------------" + line;

            return sErrorText;
        }

        /// <summary>
        /// Programdaki hataları log tutar ve mail gönderir.
        /// </summary>
        /// <param name="ex">Oluşan hata</param>
        public void AppendLogFile(string sErrorText)
        {
            string filepath = Application.StartupPath;

            if (!Directory.Exists(filepath))
                Directory.CreateDirectory(filepath);

            filepath = filepath + DateTime.Today.ToString("dd-MM-yy") + ".txt";

            if (!File.Exists(filepath))
                File.Create(filepath).Dispose();

            using (StreamWriter sw = File.AppendText(filepath))
            {
                sw.WriteLine(sErrorText);                    
                sw.Flush();
                sw.Close();
            }         
        }

        /// <summary>
        /// Porgramda oluşan hataları mail gönderir.
        /// </summary>
        /// <param name="sException"></param>
        private void SendExceptionMail(string sExceptionText)
        {
            using (MailMessage mailmessage = new MailMessage())
            {
                mailmessage.From = new MailAddress(edtGonKulAdi.Text + "@" + edtMailUzantısı.Text);
                foreach (ListViewItem eachItem in lsvSenErrMaiUsr.Items)
                    mailmessage.To.Add(eachItem.SubItems[1].Text);

                if (mailmessage.To.Count > 0)
                {
                    mailmessage.Subject = "Online Sipariş Uygulamasında Hata " + DateTime.Now.ToString();
                    mailmessage.Body = sExceptionText + Environment.NewLine + "Bildirim mailidir cevaplamayınız!";

                    using (System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient())
                    {
                        smtp.Credentials = new System.Net.NetworkCredential(edtGonKulAdi.Text + "@" + edtMailUzantısı.Text, edtGonKulSif.Text);
                        smtp.Port = Convert.ToInt32(edtSunPort.Text);
                        smtp.Host = edtMailSunucusu.Text;
                        smtp.EnableSsl = false;
                        smtp.Send(mailmessage);                                                         
                    }
                }
            }
        }

        /// <summary>
        /// Onaylanan siparişlerin onay mesajını gönderir
        /// </summary>
        /// <param name="sWarehouse">Depo Kodu</param>
        /// <param name="sOldFileName">Eski dosya ismi</param>
        /// <param name="sNewFile">Yeni dosya ismi</param>
        /// <param name="sFile">Dosya</param>
        private void SendOrderConfirmationMail(string sWarehouse,string sOldFileName, string sNewFile,string sFile)
        {
            using (MailMessage mailmessage = new MailMessage())
            {
                mailmessage.From = new MailAddress(edtGonKulAdi.Text + "@" + edtMailUzantısı.Text);
                foreach (ListViewItem eachItem in lsvGonMailAdr.Items)
                    if (eachItem.SubItems[1].Text == sWarehouse)
                        mailmessage.To.Add(eachItem.Text);

                if (mailmessage.To.Count == 0)
                {
                    File.Move(sOldFileName, sNewFile);
                    return;
                }

                mailmessage.Subject = sOldFileName.Substring(2, sOldFileName.Length - 2);
                mailmessage.Body = "Bildirim mailidir cevaplamayınız";
                mailmessage.Attachments.Add(new Attachment(sNewFile));

                using (System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient())
                {
                    smtp.Credentials = new System.Net.NetworkCredential(edtGonKulAdi.Text + "@" + edtMailUzantısı.Text, edtGonKulSif.Text);
                    smtp.Port = Convert.ToInt32(edtSunPort.Text);
                    smtp.Host = edtMailSunucusu.Text;
                    smtp.EnableSsl = false;
                    try
                    {
                        smtp.Send(mailmessage);
                    }
                    catch (Exception Ex)
                    {
                        File.Move(sNewFile, sFile);
                        AppendLogAndSend(Ex);
                    }
                }
            }
        }

        /// <summary>
        /// Onay maili gönderilecek dosyaları ayarlar
        /// </summary>
        private void PrepareFile()
        {
            string[] filePaths = Directory.GetFiles(bedGidDosKayDiz.Text, "*.xml");

            for (int i = 0; i < filePaths.Count(); i++)
                FileOperations(filePaths[i]);

            lstDebug.Items.Add(string.Format("Toplam {0} dosya gönderildi.", filePaths.Count()));

            AddStatusAndProgres(string.Format("Toplam {0} dosya gönderildi.", filePaths.Count()), 90);
        }

        private void btnRunOneTime_Click(object sender, EventArgs e)
        {
            btnRunContinuously.Enabled=!btnRunOneTime.Enabled;
            btnRunContinuously.BackColor = Color.Red;
            ReceiveAndSaveMails();
            if (chbCevapMailiGonderilsin.Checked)
                PrepareFile();
            btnRunContinuously.Enabled = btnRunOneTime.Enabled;
            btnRunContinuously.BackColor = Color.DeepSkyBlue;
            AddStatusAndProgres("İşlemler tamamlandı", 100);
        }

        public void AppendLogAndSend(Exception Ex) 
        {
            try
            {
                AppendLogFile(CreateExceptionToErrorText(Ex));
                SendExceptionMail(CreateExceptionToErrorText(Ex));
            }
            catch (Exception Exx)
            {
                AppendLogFile(CreateExceptionToErrorText(Exx));
                SendExceptionMail(CreateExceptionToErrorText(Exx));
            }
        }
        /// <summary>
        /// Kontrollerin textini temizler
        /// </summary>
        /// <param name="cComponent">Kontrol</param>
        private void ClearControl(Control cComponent)
        {
            switch (cComponent)
            {
                case TextBox _:                    
                    ((TextBox)cComponent).Clear();
                break;
            }
        }
        /// <summary>
        /// Kontrolleri kontrol eder ve hata mesajı verir
        /// </summary>
        /// <param name="sMessaj">Mesaj</param>
        /// <param name="sCaption">Başlık</param>
        /// <param name="cComponent">Kontrol</param>
        /// <returns></returns>
        private bool CheckControl(string sMessaj, string sCaption, Control cComponent)
        {
            bool Result = false;
            switch (cComponent)
            {
                case TextBox _:
                    if (cComponent.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show(sMessaj, sCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cComponent.Focus();
                        Result=true;
                    }
                    break;
                case ListView _:
                    if (((ListView)cComponent).SelectedItems.Count <= 0)
                    {
                        MessageBox.Show(sMessaj, sCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ((ListView)cComponent).Focus();
                        Result= true;
                    }
                    break;
            }
            return Result;
        }

        public void  AddStatusAndProgres (string sStatus,int iValue)
        {
            StaBarLblStatus.Text = sStatus;
            prgbLoading.Value = iValue;
        }
       
        /// <summary>
        /// Mailleri al ve kaydet
        /// </summary>
        private void ReceiveAndSaveMails()
        {            
            Cursor.Current = Cursors.WaitCursor;
            btnRunOneTime.Enabled = false;
            if(CheckControl("Mail server giriniz!" + Environment.NewLine + "Örnek:" + Environment.NewLine + "imap.gmail.com" + Environment.NewLine + "outlook.office365.com", "Hata", edtEpostSunucusu)) return;
            if(CheckControl("Port giriniz!" + Environment.NewLine + "Örnek:" + Environment.NewLine + "Gmail :993 " + Environment.NewLine + "Outlook :993", "Hata", edtEpostPort)) return;
            try
            {
                try
                {
                    int iKayMaiAde = 0;
                    using (MailRepository MailBox= new MailRepository())
                    {
                        AddStatusAndProgres(edtMailUzantısı.Text + " sunucusuna bağlanılıyor...", 10);
                        if (!MailBox.Connected())
                        {                           
                            MailBox.Connect(edtEpostSunucusu.Text, Convert.ToInt32(edtEpostPort.Text), true, edtGelKullaniciAdi.Text + "@" + edtMailUzantısı.Text, edtGelSifre.Text);

                            if (MailBox.Connected())
                            {
                                AddStatusAndProgres(edtGelKullaniciAdi.Text + "@" + edtMailUzantısı.Text + " mail adresine bağlandı.", 15);
                                if (!MailBox.HaveMailBox("Orders Received"))
                                    MailBox.CreateMailBox("Orders Received");

                                if (!MailBox.HaveMailBox("Other"))
                                    MailBox.CreateMailBox("Other");
                                AddStatusAndProgres(" Mail listesi alınıyor", 20);
                                var InboxMails = MailBox.GetMails("INBOX", "ALL");

                                string XmlFileName = "";
                                int i = 1;
                                foreach (ActiveUp.Net.Mail.Message eMail in InboxMails)
                                {                                    
                                    ListViewItem GonMailAdres = lsvGonMailAdr.FindItemWithText(eMail.From.Email);
                                    if (eMail.Attachments.Count > 0)
                                    {
                                        if (GonMailAdres != null)
                                        {
                                            StaBarLblStatus.Text = $"Toplam {InboxMails.Count} içersinden {i}. mail alınıyor...";

                                            AddStatusAndProgres($"Toplam {InboxMails.Count} içersinden {i}. mail alınıyor...", 20+i*3);
                                            foreach (MimePart MailAttachment in eMail.Attachments)
                                            {
                                                if (MailAttachment.Filename.Substring(MailAttachment.Filename.Length - 3, 3) == "xml")
                                                {
                                                    ListViewItem mailitem = new ListViewItem();
                                                    mailitem.Text = eMail.BodyHtml.Text;
                                                    mailitem.SubItems.Add(eMail.From.Email);
                                                    mailitem.SubItems.Add(eMail.Subject);
                                                    mailitem.SubItems.Add(MailAttachment.Filename);

                                                    try
                                                    {
                                                        foreach (Address eMailToAdres in eMail.To)//birden fazla to  olursa her to için kayıt edecek fakat aşağıda ismi olamayan to ları hepsini aynı yere kayıt edecek
                                                        {
                                                            XmlFileName = bedGelDosKayDiz.Text + @"\" + GonMailAdres.Text + "_" + MailAttachment.Filename;

                                                            if (!File.Exists(XmlFileName))
                                                                MailAttachment.StoreToFile(XmlFileName);
                                                            if (!File.Exists(bedGelDosKayDiz.Text + @"\" + GonMailAdres.Text + "_" + MailAttachment.Filename))
                                                                MailAttachment.StoreToFile(bedGelDosKayDiz.Text + @"\" + GonMailAdres.Text + "_" + MailAttachment.Filename);
                                                        }
                                                        FileInfo file = new FileInfo(XmlFileName);
                                                        string XmlFile = File.ReadAllText(XmlFileName);
                                                        //File.WriteAllText(sFileName, ClearEmptyTags(XmlFile)); clear emty tag diye bir fonksiyona ihityaç yok bence
                                                        iKayMaiAde++;

                                                        MailBox.MoveMessage(eMail.Subject, "inbox", "Orders Received");

                                                        AddStatusAndProgres($"{eMail.Subject} maili inbox içersinden Orders Received taşındı", 65);
                                                    }
                                                    catch (Exception Ex)
                                                    {

                                                        iKayMaiAde--;
                                                        AppendLogAndSend(Ex);                                                    
                                                    }
                                                    mailitem.SubItems.Add(eMail.Date.ToString());
                                                    lsvMailler.Items.Add(mailitem);
                                                    i++;
                                                }
                                            }
                                            //mailitem.SubItems.Add(eMail.Date.ToString());
                                            //lsvMailler.Items.Add(mailitem);
                                            //i++;
                                        }
                                        else
                                        {
                                            MailBox.MoveMessage(eMail.Subject, "inbox", "Other");
                                            lstDebug.Items.Add($"{eMail.From} adresinden gelen mail Sipariş Gönderilen Mail Adresleri listesinde olmamasından dolayı Outlook'ta Inbox içersinden Other taşındı");
                                        }
                                    }
                                    else
                                    {
                                        MailBox.MoveMessage(eMail.Subject, "inbox", "Other");
                                        lstDebug.Items.Add($"{eMail.From} adresinden gelen {eMail.Subject} konulu  mail Attachment olmadığından Outlook'ta Inbox içersinden Other taşındı");
                                    }                                   
                                }
                            }

                            AddStatusAndProgres($"Mailler Alındı", 70);
                        }
                        MailBox.Disconnect();
                        AddStatusAndProgres(edtMailUzantısı.Text + " sunucusuna bağlanılamadı...", 75);
                    }
                    AddStatusAndProgres($"Toplam {lsvMailler.Items.Count} mail alındı.", 100);
                    lstDebug.Items.Add($"Toplam {iKayMaiAde} dosya kaydedildi.");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Environment.NewLine + $"{edtGelKullaniciAdi.Text + "@" + edtMailUzantısı.Text} mail adresine bağlantı kurulamadı.{Environment.NewLine}mail adresi ve şifrenizi kontrol ediniz.", "Login Olunamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                    AppendLogAndSend(Ex);
                }
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                btnRunOneTime.Enabled = true;
                AddStatusAndProgres($"Mail işlemleri tamamlandı", 80);
            }
        }

        /// <summary>
        /// ini dosyasına yazma işlemi yapar
        /// </summary>
        /// <param name="sSectionName">Üst başlık</param>
        /// <param name="sKeyName">Alt başlık</param>
        /// <param name="sValue">Değer</param>
        private void WriteIni(string sSectionName, string sKeyName, string sValue)
        {
            try
            {
                IniFileLibrary.WritePrivateProfileString(sSectionName, sKeyName, sValue, Application.StartupPath + @"config.ini");
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"{sSectionName} alının {sKeyName} değişkenin değeri yazılamadı " + Environment.NewLine + Ex.ToString(), "Yazma Hatsı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// ini dosyasından ver okur
        /// </summary>
        /// <param name="sSectionName">Üst başlık</param>
        /// <param name="sKeyName">Alt başlık</param>
        /// <param name="sDefault">Değer</param>
        /// <returns></returns>
        private string ReadIni(string sSectionName, string sKeyName, string sDefault = "")
        {
            StringBuilder sb = new StringBuilder(5000);
            try
            {
                IniFileLibrary.GetPrivateProfileString(sSectionName, sKeyName, "", sb, sb.Capacity, Application.StartupPath + @"config.ini");
                return sb.ToString();
            }
            catch(Exception Ex)
            {
                MessageBox.Show($"ini dosyasında {sSectionName} alının {sKeyName} değeri okunamadı " +Environment.NewLine + Ex.ToString(), "Okuma Hatsı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        private void tmrSaat_Tick(object sender, EventArgs e)
        {
            StaBarLblStatus2.Text = DateTime.Now.Second.ToString();
        }


        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            WriteIni("Mail", "MailUzantisi", edtMailUzantısı.Text);
            WriteIni("Mail", "KullaniciAdi", edtGelKullaniciAdi.Text);
            WriteIni("Mail", "Sifre", edtGelSifre.Text);

            WriteIni("Mail", "GonderenMailAdresSayisi", lsvGonMailAdr.Items.Count.ToString());

            int i = 1;
            foreach (ListViewItem item in lsvGonMailAdr.Items)
            {
                WriteIni("Mail", "GonderenMailAdresi" + i.ToString(), item.Text);
                WriteIni("Mail", "GonderenMailAdresi" + i.ToString() + "Kod", item.Text);
                i++;
            }

            WriteIni("HataGonderilecekMail", "HataGonderilecekMailAdresSayisi", lsvSenErrMaiUsr.Items.Count.ToString());
            i = 1;
            foreach (ListViewItem item in lsvSenErrMaiUsr.Items)
            {
                WriteIni("HataGonderilecekMail", "HataGonderilecekKullanici" + i.ToString()+ "Adi", item.Text);
                WriteIni("HataGonderilecekMail", "HataGonderilecekMail" + i.ToString() + "Adresi", item.SubItems[1].Text);
                i++;
            }



            WriteIni("Gonderen", "Sunucu", edtMailSunucusu.Text);
            WriteIni("Gonderen", "Port", edtSunPort.Text);
            WriteIni("Gonderen", "KullaniciAdi", edtGonKulAdi.Text);
            WriteIni("Gonderen", "Sifre", edtGonKulSif.Text);

            WriteIni("Ayarlar", "GelenDosyalarinKaydedilecegiDizin", bedGelDosKayDiz.Text);
            WriteIni("Ayarlar", "GidenDosyalarinKaydedilecegiDizin", bedGidDosKayDiz.Text);
            WriteIni("Ayarlar", "KontrolSikligi", edtKontrolSikligi.Text);
            WriteIni("Ayarlar", "CevapMailiGonderilsin", chbCevapMailiGonderilsin.Checked ? "1" : "0");

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            StaBarLblStatus.Width = Width - 100;
            StaBarLblStatus.Text = DateTime.Now.ToString();


            if (File.Exists(Application.StartupPath + @"DebugConfig.ini"))
                MessageBox.Show("Config.ini ayar dosyası kayıp", "Dosya Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            edtMailUzantısı.Text    = ReadIni("Mail", "MailUzantisi");
            edtGelKullaniciAdi.Text = ReadIni("Mail", "KullaniciAdi");
            edtGelSifre.Text        = ReadIni("Mail", "Sifre");

            int iGonderenMailAdresSayisi = Convert.ToInt16(ReadIni("Mail", "GonderenMailAdresSayisi"));
            lsvGonMailAdr.Items.Clear();

            for (int i = 1; i <= iGonderenMailAdresSayisi; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text =       ReadIni("Mail", "GonderenMailAdresi" + Convert.ToInt32(i));
                item.SubItems.Add(ReadIni("Mail", "GonderenMailAdresi" + Convert.ToInt32(i) + "Kod"));
                lsvGonMailAdr.Items.Add(item);
            }


            int iHatGonMailAdrSay = Convert.ToInt16(ReadIni("HataGonderilecekMail", "HataGonderilecekMailAdresSayisi"));
            lsvSenErrMaiUsr.Items.Clear();

            for (int i = 1; i <= iHatGonMailAdrSay; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = ReadIni("HataGonderilecekMail", "HataGonderilecekKullanici"+Convert.ToInt32(i)+"Adi");
                item.SubItems.Add(ReadIni("HataGonderilecekMail", "HataGonderilecekMail" + Convert.ToInt32(i) + "Adresi"));
                lsvSenErrMaiUsr.Items.Add(item);
            }

            edtMailSunucusu.Text = ReadIni("Gonderen", "Sunucu");
            edtSunPort.Text      = ReadIni("Gonderen", "Port");
            edtGonKulAdi.Text    = ReadIni("Gonderen", "KullaniciAdi");
            edtGonKulSif.Text    = ReadIni("Gonderen", "Sifre");


            bedGelDosKayDiz.Text    = ReadIni("Ayarlar", "GelenDosyalarinKaydedilecegiDizin", Application.StartupPath + @"\Gelen");
            bedGidDosKayDiz.Text    = ReadIni("Ayarlar", "GidenDosyalarinKaydedilecegiDizin", Application.StartupPath + @"\Giden");
            edtKontrolSikligi.Text  = ReadIni("Ayarlar", "KontrolSikligi", "5");
            chbCevapMailiGonderilsin.Checked = ReadIni("Ayarlar", "CevapMailiGonderilsin") == "1" ? true : false;

            tmrKontrol.Interval = Convert.ToInt32(edtKontrolSikligi.Text) * 60 * 100;            
            tbsTabs.SelectedIndex = 0;
        }

        private void tmrKontrol_Tick(object sender, EventArgs e)
        {
            lstDebug.Items.Add("---------- " + DateTime.Now.ToString());

            ReceiveAndSaveMails();
            if (chbCevapMailiGonderilsin.Checked)
                PrepareFile();
        }


        /// <summary>
        /// BrowserDialog içerisinden seçilen yolu verir. 
        /// </summary>
        /// <returns>Seçilen yol</returns>
        public string GetFileLocation()
        {
            FolderBrowserDialog fBrowser = new FolderBrowserDialog();
            fBrowser.Description = "Dosyanın Kayıt Yerini Seçiniz..";
            fBrowser.ShowDialog();

            return fBrowser.SelectedPath;

        }

        private void lsvGonMailAdr_KeyUp(object sender, KeyEventArgs e)
        {
            if (lsvGonMailAdr.Items.Count == 0) return;
            if (CheckControl("Mail adresi ve Kod seçmediniz!", "Hata", lsvGonMailAdr)) return;
            if (lsvGonMailAdr.SelectedItems.Count > 0)
            {
                edtGonderenMailAdresi.Text = lsvGonMailAdr.SelectedItems[0].Text;
            }
        }

        private void lsvGonMailAdr_Click(object sender, EventArgs e)
        {
            if (lsvGonMailAdr.Items.Count == 0)
                return;
            edtGonderenMailAdresi.Text = lsvGonMailAdr.SelectedItems[0].Text;
        }

        private void btnGelDosKayDiz_Click(object sender, EventArgs e)
        {
            bedGelDosKayDiz.Text = GetFileLocation();
        }

        private void btnGidDosKayDiz_Click(object sender, EventArgs e)
        {
            bedGidDosKayDiz.Text = GetFileLocation();
        }

        private void lsvMailler_DoubleClick(object sender, EventArgs e)
        {
            using (MailMessage SelectedMail = new MailMessage())
            {
                SelectedMail.From = new MailAddress(lsvMailler.SelectedItems[0].SubItems[1].Text);
                SelectedMail.Subject = lsvMailler.SelectedItems[0].SubItems[2].Text;
                SelectedMail.Body = lsvMailler.SelectedItems[0].Text;

                string[] filePaths = Directory.GetFiles(bedGelDosKayDiz.Text, "*.xml", SearchOption.AllDirectories);
                int index = -1;
                for (int i = 0; i < filePaths.Count(); i++)
                {
                    if (Path.GetFileName(filePaths[i]).Remove(0, lsvMailler.SelectedItems[0].SubItems[1].Text.Length+1) == lsvMailler.SelectedItems[0].SubItems[3].Text)//(Path.GetFileName(filePaths[i]).Substring(2, Path.GetFileName(filePaths[i]).Length - 2) == lsvMailler.SelectedItems[0].SubItems[3].Text)
                    {
                        index = i;
                        break;
                    }
                }
                string SelMailAtchPath = filePaths[index];

                string SelectedMailDate = lsvMailler.SelectedItems[0].SubItems[4].Text;

                frmMailViewer MailViewer = new frmMailViewer(SelectedMail, SelMailAtchPath, SelectedMailDate);
                MailViewer.Show();
            }
        }

        private void btnlsvSenErrMaiUsrAdd_Click(object sender, EventArgs e)
        {
           if(CheckControl("Hata maili gönderilecek kullanıcı adını giriniz!", "Hata", edtSenErrMaiUsrName))        return;
           if(CheckControl("Hata maili gönderilecek kullanıcı mail adresini giriniz!", "Hata", edtSenErrMaiUsrMail)) return;

            ListViewItem SenErrMaiUsr = lsvSenErrMaiUsr.FindItemWithText(edtSenErrMaiUsrMail.Text);//varsa ekleme
            if (SenErrMaiUsr != null) return;

            ListViewItem lsvSenErrMaiUsrItem = new ListViewItem();
            lsvSenErrMaiUsrItem.Text = edtSenErrMaiUsrName.Text;
            lsvSenErrMaiUsrItem.SubItems.Add(edtSenErrMaiUsrMail.Text);
            lsvSenErrMaiUsr.Items.Add(lsvSenErrMaiUsrItem);

            ClearControl(edtSenErrMaiUsrName);
            ClearControl(edtSenErrMaiUsrMail);
        }

        private void btnlsvSenErrMaiUsrDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem SenErrMaiUsr in lsvSenErrMaiUsr.SelectedItems)
                lsvSenErrMaiUsr.Items.Remove(SenErrMaiUsr);

        }

        private void btnRunContinuously_Click(object sender, EventArgs e)
        {
            tmrKontrol.Enabled = true;
            btnRunOneTime.Enabled = !tmrKontrol.Enabled;
            btnRunOneTime.BackColor=Color.Red;
            btnStop.Enabled = tmrKontrol.Enabled;
            btnStop.BackColor = Color.DeepSkyBlue;
            btnRunContinuously.Enabled= !tmrKontrol.Enabled;
            btnRunContinuously.BackColor = Color.Red;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrKontrol.Enabled = false;
            btnRunOneTime.Enabled = !tmrKontrol.Enabled;
        }

        private void edtSenErrMaiUsrMail_Leave(object sender, EventArgs e)
        {
            EmailCheck((TextBox)sender);
        }


        private void ShowtolHint(string sToolTipTitle, ToolTipIcon tToolTipIcon,string sMesaj ,Control cComponent)
        {
            tolHint.IsBalloon = true;
            tolHint.ToolTipTitle = sToolTipTitle;
            tolHint.ToolTipIcon = tToolTipIcon;
            tolHint.Show(sMesaj, cComponent, cComponent.Location.X-20, cComponent.Location.Y-80);
        }

        private void edtMailUzantısı_MouseHover(object sender, EventArgs e)
        {
            ShowtolHint("Hello, world!", ToolTipIcon.Info, "Please create a world.", (TextBox)sender);
        }

        private void edtMailUzantısı_MouseLeave(object sender, EventArgs e)
        {
            tolHint.Hide((TextBox)sender);
        }
    }
}