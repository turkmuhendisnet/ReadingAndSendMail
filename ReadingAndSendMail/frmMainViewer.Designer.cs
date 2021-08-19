
namespace ReadingAndSendMail
{
    partial class frmMainViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "alicakir@toksozgrup.com.tr",
            "S"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainViewer));
            this.grpBxMain = new System.Windows.Forms.GroupBox();
            this.grpBxButtom = new System.Windows.Forms.GroupBox();
            this.prgbLoading = new System.Windows.Forms.ProgressBar();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StaBarLblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.StaBarLblStatus2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lstDebug = new System.Windows.Forms.ListBox();
            this.tmrSaat = new System.Windows.Forms.Timer(this.components);
            this.tmrKontrol = new System.Windows.Forms.Timer(this.components);
            this.tbsAyarlar = new System.Windows.Forms.TabPage();
            this.pnlAyarlar = new System.Windows.Forms.Panel();
            this.grpBx = new System.Windows.Forms.GroupBox();
            this.bedGelDosKayDiz = new System.Windows.Forms.TextBox();
            this.lblGidDosKayDiz = new System.Windows.Forms.Label();
            this.bedGidDosKayDiz = new System.Windows.Forms.TextBox();
            this.btnGidDosKayDiz = new System.Windows.Forms.Button();
            this.btnGelDosKayDiz = new System.Windows.Forms.Button();
            this.lblGelDosKayDiz = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbCevapMailiGonderilsin = new System.Windows.Forms.CheckBox();
            this.edtEpostSunucusu = new System.Windows.Forms.TextBox();
            this.lblCvpMailGon = new System.Windows.Forms.Label();
            this.edtEpostPort = new System.Windows.Forms.TextBox();
            this.edtKontrolSikligi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKonSk = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpSendErrMai = new System.Windows.Forms.GroupBox();
            this.lsvSenErrMaiUsr = new System.Windows.Forms.ListView();
            this.clmUsrName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMailAdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.edtSenErrMaiUsrName = new System.Windows.Forms.TextBox();
            this.edtSenErrMaiUsrMail = new System.Windows.Forms.TextBox();
            this.btnlsvSenErrMaiUsrDelete = new System.Windows.Forms.Button();
            this.btnlsvSenErrMaiUsrAdd = new System.Windows.Forms.Button();
            this.lblSenErrMaiUsrName = new System.Windows.Forms.Label();
            this.lblSenErrMaiUsrMail = new System.Windows.Forms.Label();
            this.tbsMail = new System.Windows.Forms.TabPage();
            this.pnlMailAyarlar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRunOneTime = new System.Windows.Forms.Button();
            this.grpGonMaiAdr = new System.Windows.Forms.GroupBox();
            this.lsvGonMailAdr = new System.Windows.Forms.ListView();
            this.lsvGonMailAdrClmMailAdr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblGonMailAdr = new System.Windows.Forms.Label();
            this.edtGonderenMailAdresi = new System.Windows.Forms.TextBox();
            this.btnMailCikar = new System.Windows.Forms.Button();
            this.btnMailEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edtGonKulAdi = new System.Windows.Forms.TextBox();
            this.edtGonKulSif = new System.Windows.Forms.TextBox();
            this.grpAyrMail = new System.Windows.Forms.GroupBox();
            this.lblMailUzantısı = new System.Windows.Forms.Label();
            this.edtMailUzantısı = new System.Windows.Forms.TextBox();
            this.lblMailSuncusu = new System.Windows.Forms.Label();
            this.edtMailSunucusu = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.edtSunPort = new System.Windows.Forms.TextBox();
            this.grpGelMaiAdrBil = new System.Windows.Forms.GroupBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.edtGelKullaniciAdi = new System.Windows.Forms.TextBox();
            this.edtGelSifre = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.btnRunContinuously = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pnlMailIslemSonuclari = new System.Windows.Forms.Panel();
            this.lsvMailler = new System.Windows.Forms.ListView();
            this.lsvMaillerClmMsg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvMaillerGon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvMaillerBas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvMaillerDos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvMaillerTar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbsTabs = new System.Windows.Forms.TabControl();
            this.grpBxMain.SuspendLayout();
            this.grpBxButtom.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.tbsAyarlar.SuspendLayout();
            this.pnlAyarlar.SuspendLayout();
            this.grpBx.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpSendErrMai.SuspendLayout();
            this.tbsMail.SuspendLayout();
            this.pnlMailAyarlar.SuspendLayout();
            this.grpGonMaiAdr.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpAyrMail.SuspendLayout();
            this.grpGelMaiAdrBil.SuspendLayout();
            this.pnlMailIslemSonuclari.SuspendLayout();
            this.tbsTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxMain
            // 
            this.grpBxMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpBxMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpBxMain.Controls.Add(this.tbsTabs);
            this.grpBxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBxMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBxMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpBxMain.Location = new System.Drawing.Point(0, 0);
            this.grpBxMain.Name = "grpBxMain";
            this.grpBxMain.Size = new System.Drawing.Size(1215, 752);
            this.grpBxMain.TabIndex = 3;
            this.grpBxMain.TabStop = false;
            // 
            // grpBxButtom
            // 
            this.grpBxButtom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpBxButtom.Controls.Add(this.prgbLoading);
            this.grpBxButtom.Controls.Add(this.StatusBar);
            this.grpBxButtom.Controls.Add(this.lstDebug);
            this.grpBxButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpBxButtom.Location = new System.Drawing.Point(0, 752);
            this.grpBxButtom.Name = "grpBxButtom";
            this.grpBxButtom.Size = new System.Drawing.Size(1215, 153);
            this.grpBxButtom.TabIndex = 2;
            this.grpBxButtom.TabStop = false;
            // 
            // prgbLoading
            // 
            this.prgbLoading.Location = new System.Drawing.Point(732, 128);
            this.prgbLoading.Name = "prgbLoading";
            this.prgbLoading.Size = new System.Drawing.Size(480, 22);
            this.prgbLoading.TabIndex = 1;
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StaBarLblStatus,
            this.StaBarLblStatus2});
            this.StatusBar.Location = new System.Drawing.Point(3, 128);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(1209, 22);
            this.StatusBar.TabIndex = 0;
            this.StatusBar.Text = "statusStrip1";
            // 
            // StaBarLblStatus
            // 
            this.StaBarLblStatus.Name = "StaBarLblStatus";
            this.StaBarLblStatus.Size = new System.Drawing.Size(0, 17);
            this.StaBarLblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StaBarLblStatus2
            // 
            this.StaBarLblStatus2.Name = "StaBarLblStatus2";
            this.StaBarLblStatus2.Size = new System.Drawing.Size(0, 17);
            // 
            // lstDebug
            // 
            this.lstDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstDebug.FormattingEnabled = true;
            this.lstDebug.ItemHeight = 15;
            this.lstDebug.Location = new System.Drawing.Point(3, 16);
            this.lstDebug.MultiColumn = true;
            this.lstDebug.Name = "lstDebug";
            this.lstDebug.ScrollAlwaysVisible = true;
            this.lstDebug.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDebug.Size = new System.Drawing.Size(1209, 134);
            this.lstDebug.TabIndex = 0;
            // 
            // tmrSaat
            // 
            this.tmrSaat.Enabled = true;
            this.tmrSaat.Interval = 1000;
            this.tmrSaat.Tick += new System.EventHandler(this.tmrSaat_Tick);
            // 
            // tmrKontrol
            // 
            this.tmrKontrol.Interval = 1000;
            this.tmrKontrol.Tick += new System.EventHandler(this.tmrKontrol_Tick);
            // 
            // tbsAyarlar
            // 
            this.tbsAyarlar.BackColor = System.Drawing.Color.Cornsilk;
            this.tbsAyarlar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbsAyarlar.Controls.Add(this.pnlAyarlar);
            this.tbsAyarlar.Location = new System.Drawing.Point(4, 24);
            this.tbsAyarlar.Name = "tbsAyarlar";
            this.tbsAyarlar.Padding = new System.Windows.Forms.Padding(3);
            this.tbsAyarlar.Size = new System.Drawing.Size(1201, 705);
            this.tbsAyarlar.TabIndex = 2;
            this.tbsAyarlar.Text = "Ayarlar";
            // 
            // pnlAyarlar
            // 
            this.pnlAyarlar.BackColor = System.Drawing.Color.LightCyan;
            this.pnlAyarlar.Controls.Add(this.grpSendErrMai);
            this.pnlAyarlar.Controls.Add(this.groupBox1);
            this.pnlAyarlar.Controls.Add(this.grpBx);
            this.pnlAyarlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAyarlar.Location = new System.Drawing.Point(3, 3);
            this.pnlAyarlar.Name = "pnlAyarlar";
            this.pnlAyarlar.Size = new System.Drawing.Size(1191, 695);
            this.pnlAyarlar.TabIndex = 0;
            // 
            // grpBx
            // 
            this.grpBx.Controls.Add(this.lblGelDosKayDiz);
            this.grpBx.Controls.Add(this.btnGelDosKayDiz);
            this.grpBx.Controls.Add(this.btnGidDosKayDiz);
            this.grpBx.Controls.Add(this.bedGidDosKayDiz);
            this.grpBx.Controls.Add(this.lblGidDosKayDiz);
            this.grpBx.Controls.Add(this.bedGelDosKayDiz);
            this.grpBx.Location = new System.Drawing.Point(3, 3);
            this.grpBx.Name = "grpBx";
            this.grpBx.Size = new System.Drawing.Size(748, 84);
            this.grpBx.TabIndex = 18;
            this.grpBx.TabStop = false;
            this.grpBx.Text = "Dizin Ayarları";
            // 
            // bedGelDosKayDiz
            // 
            this.bedGelDosKayDiz.Location = new System.Drawing.Point(336, 20);
            this.bedGelDosKayDiz.Name = "bedGelDosKayDiz";
            this.bedGelDosKayDiz.Size = new System.Drawing.Size(402, 21);
            this.bedGelDosKayDiz.TabIndex = 17;
            // 
            // lblGidDosKayDiz
            // 
            this.lblGidDosKayDiz.AutoSize = true;
            this.lblGidDosKayDiz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblGidDosKayDiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGidDosKayDiz.Location = new System.Drawing.Point(6, 53);
            this.lblGidDosKayDiz.Name = "lblGidDosKayDiz";
            this.lblGidDosKayDiz.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblGidDosKayDiz.Size = new System.Drawing.Size(222, 15);
            this.lblGidDosKayDiz.TabIndex = 11;
            this.lblGidDosKayDiz.Text = "Giden Dosyaların Kaydedileceği Dizin";
            // 
            // bedGidDosKayDiz
            // 
            this.bedGidDosKayDiz.Location = new System.Drawing.Point(336, 53);
            this.bedGidDosKayDiz.Name = "bedGidDosKayDiz";
            this.bedGidDosKayDiz.Size = new System.Drawing.Size(402, 21);
            this.bedGidDosKayDiz.TabIndex = 18;
            // 
            // btnGidDosKayDiz
            // 
            this.btnGidDosKayDiz.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGidDosKayDiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGidDosKayDiz.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGidDosKayDiz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGidDosKayDiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGidDosKayDiz.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGidDosKayDiz.Location = new System.Drawing.Point(708, 53);
            this.btnGidDosKayDiz.Name = "btnGidDosKayDiz";
            this.btnGidDosKayDiz.Size = new System.Drawing.Size(30, 21);
            this.btnGidDosKayDiz.TabIndex = 13;
            this.btnGidDosKayDiz.Text = "...";
            this.btnGidDosKayDiz.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGidDosKayDiz.UseVisualStyleBackColor = false;
            this.btnGidDosKayDiz.Click += new System.EventHandler(this.btnGidDosKayDiz_Click);
            // 
            // btnGelDosKayDiz
            // 
            this.btnGelDosKayDiz.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGelDosKayDiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGelDosKayDiz.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGelDosKayDiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGelDosKayDiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGelDosKayDiz.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGelDosKayDiz.Location = new System.Drawing.Point(708, 20);
            this.btnGelDosKayDiz.Name = "btnGelDosKayDiz";
            this.btnGelDosKayDiz.Size = new System.Drawing.Size(30, 21);
            this.btnGelDosKayDiz.TabIndex = 4;
            this.btnGelDosKayDiz.Text = "...";
            this.btnGelDosKayDiz.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGelDosKayDiz.UseVisualStyleBackColor = false;
            this.btnGelDosKayDiz.Click += new System.EventHandler(this.btnGelDosKayDiz_Click);
            // 
            // lblGelDosKayDiz
            // 
            this.lblGelDosKayDiz.AutoSize = true;
            this.lblGelDosKayDiz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblGelDosKayDiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGelDosKayDiz.Location = new System.Drawing.Point(6, 20);
            this.lblGelDosKayDiz.Name = "lblGelDosKayDiz";
            this.lblGelDosKayDiz.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblGelDosKayDiz.Size = new System.Drawing.Size(222, 15);
            this.lblGelDosKayDiz.TabIndex = 1;
            this.lblGelDosKayDiz.Text = "Gelen Dosyaların Kaydedileceği Dizin";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblKonSk);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.edtKontrolSikligi);
            this.groupBox1.Controls.Add(this.edtEpostPort);
            this.groupBox1.Controls.Add(this.lblCvpMailGon);
            this.groupBox1.Controls.Add(this.edtEpostSunucusu);
            this.groupBox1.Controls.Add(this.chbCevapMailiGonderilsin);
            this.groupBox1.Location = new System.Drawing.Point(3, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 121);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "eMail Ayarları";
            // 
            // chbCevapMailiGonderilsin
            // 
            this.chbCevapMailiGonderilsin.AutoSize = true;
            this.chbCevapMailiGonderilsin.Location = new System.Drawing.Point(336, 98);
            this.chbCevapMailiGonderilsin.Name = "chbCevapMailiGonderilsin";
            this.chbCevapMailiGonderilsin.Size = new System.Drawing.Size(15, 14);
            this.chbCevapMailiGonderilsin.TabIndex = 24;
            this.chbCevapMailiGonderilsin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbCevapMailiGonderilsin.UseVisualStyleBackColor = true;
            // 
            // edtEpostSunucusu
            // 
            this.edtEpostSunucusu.Location = new System.Drawing.Point(336, 17);
            this.edtEpostSunucusu.Name = "edtEpostSunucusu";
            this.edtEpostSunucusu.Size = new System.Drawing.Size(180, 21);
            this.edtEpostSunucusu.TabIndex = 21;
            this.edtEpostSunucusu.Text = "outlook.office365.com";
            // 
            // lblCvpMailGon
            // 
            this.lblCvpMailGon.AutoSize = true;
            this.lblCvpMailGon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCvpMailGon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCvpMailGon.Location = new System.Drawing.Point(6, 97);
            this.lblCvpMailGon.Name = "lblCvpMailGon";
            this.lblCvpMailGon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblCvpMailGon.Size = new System.Drawing.Size(147, 15);
            this.lblCvpMailGon.TabIndex = 16;
            this.lblCvpMailGon.Text = "Cevap Maili Gönderilsin";
            // 
            // edtEpostPort
            // 
            this.edtEpostPort.Location = new System.Drawing.Point(336, 44);
            this.edtEpostPort.Name = "edtEpostPort";
            this.edtEpostPort.Size = new System.Drawing.Size(80, 21);
            this.edtEpostPort.TabIndex = 22;
            this.edtEpostPort.Text = "993";
            // 
            // edtKontrolSikligi
            // 
            this.edtKontrolSikligi.Location = new System.Drawing.Point(336, 71);
            this.edtKontrolSikligi.Name = "edtKontrolSikligi";
            this.edtKontrolSikligi.Size = new System.Drawing.Size(80, 21);
            this.edtKontrolSikligi.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 44);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Port";
            // 
            // lblKonSk
            // 
            this.lblKonSk.AutoSize = true;
            this.lblKonSk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblKonSk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKonSk.Location = new System.Drawing.Point(6, 71);
            this.lblKonSk.Name = "lblKonSk";
            this.lblKonSk.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblKonSk.Size = new System.Drawing.Size(92, 15);
            this.lblKonSk.TabIndex = 14;
            this.lblKonSk.Text = "Kontrol Sıklığı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "ePost Sunucusu";
            // 
            // grpSendErrMai
            // 
            this.grpSendErrMai.Controls.Add(this.lblSenErrMaiUsrMail);
            this.grpSendErrMai.Controls.Add(this.lblSenErrMaiUsrName);
            this.grpSendErrMai.Controls.Add(this.btnlsvSenErrMaiUsrAdd);
            this.grpSendErrMai.Controls.Add(this.btnlsvSenErrMaiUsrDelete);
            this.grpSendErrMai.Controls.Add(this.edtSenErrMaiUsrMail);
            this.grpSendErrMai.Controls.Add(this.edtSenErrMaiUsrName);
            this.grpSendErrMai.Controls.Add(this.lsvSenErrMaiUsr);
            this.grpSendErrMai.Location = new System.Drawing.Point(3, 301);
            this.grpSendErrMai.Name = "grpSendErrMai";
            this.grpSendErrMai.Size = new System.Drawing.Size(368, 391);
            this.grpSendErrMai.TabIndex = 26;
            this.grpSendErrMai.TabStop = false;
            this.grpSendErrMai.Text = "Hata Maili Gönderilecek Kullanıcılar";
            // 
            // lsvSenErrMaiUsr
            // 
            this.lsvSenErrMaiUsr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmUsrName,
            this.clmMailAdr});
            this.lsvSenErrMaiUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lsvSenErrMaiUsr.FullRowSelect = true;
            this.lsvSenErrMaiUsr.GridLines = true;
            this.lsvSenErrMaiUsr.HideSelection = false;
            this.lsvSenErrMaiUsr.Location = new System.Drawing.Point(6, 20);
            this.lsvSenErrMaiUsr.Name = "lsvSenErrMaiUsr";
            this.lsvSenErrMaiUsr.Size = new System.Drawing.Size(356, 289);
            this.lsvSenErrMaiUsr.TabIndex = 25;
            this.lsvSenErrMaiUsr.UseCompatibleStateImageBehavior = false;
            this.lsvSenErrMaiUsr.View = System.Windows.Forms.View.Details;
            // 
            // clmUsrName
            // 
            this.clmUsrName.Text = "Kullanıcı Adı";
            this.clmUsrName.Width = 108;
            // 
            // clmMailAdr
            // 
            this.clmMailAdr.Text = "Mail Adres";
            this.clmMailAdr.Width = 242;
            // 
            // edtSenErrMaiUsrName
            // 
            this.edtSenErrMaiUsrName.Location = new System.Drawing.Point(6, 334);
            this.edtSenErrMaiUsrName.Name = "edtSenErrMaiUsrName";
            this.edtSenErrMaiUsrName.Size = new System.Drawing.Size(106, 21);
            this.edtSenErrMaiUsrName.TabIndex = 25;
            // 
            // edtSenErrMaiUsrMail
            // 
            this.edtSenErrMaiUsrMail.Location = new System.Drawing.Point(118, 334);
            this.edtSenErrMaiUsrMail.Name = "edtSenErrMaiUsrMail";
            this.edtSenErrMaiUsrMail.Size = new System.Drawing.Size(244, 21);
            this.edtSenErrMaiUsrMail.TabIndex = 26;
            this.edtSenErrMaiUsrMail.Leave += new System.EventHandler(this.edtSenErrMaiUsrMail_Leave);
            // 
            // btnlsvSenErrMaiUsrDelete
            // 
            this.btnlsvSenErrMaiUsrDelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnlsvSenErrMaiUsrDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlsvSenErrMaiUsrDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnlsvSenErrMaiUsrDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlsvSenErrMaiUsrDelete.Location = new System.Drawing.Point(242, 361);
            this.btnlsvSenErrMaiUsrDelete.Name = "btnlsvSenErrMaiUsrDelete";
            this.btnlsvSenErrMaiUsrDelete.Size = new System.Drawing.Size(55, 25);
            this.btnlsvSenErrMaiUsrDelete.TabIndex = 39;
            this.btnlsvSenErrMaiUsrDelete.Text = "Çıkar";
            this.btnlsvSenErrMaiUsrDelete.UseVisualStyleBackColor = false;
            this.btnlsvSenErrMaiUsrDelete.Click += new System.EventHandler(this.btnlsvSenErrMaiUsrDelete_Click);
            // 
            // btnlsvSenErrMaiUsrAdd
            // 
            this.btnlsvSenErrMaiUsrAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnlsvSenErrMaiUsrAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlsvSenErrMaiUsrAdd.Location = new System.Drawing.Point(303, 361);
            this.btnlsvSenErrMaiUsrAdd.Name = "btnlsvSenErrMaiUsrAdd";
            this.btnlsvSenErrMaiUsrAdd.Size = new System.Drawing.Size(59, 25);
            this.btnlsvSenErrMaiUsrAdd.TabIndex = 27;
            this.btnlsvSenErrMaiUsrAdd.Text = "Ekle";
            this.btnlsvSenErrMaiUsrAdd.UseVisualStyleBackColor = false;
            this.btnlsvSenErrMaiUsrAdd.Click += new System.EventHandler(this.btnlsvSenErrMaiUsrAdd_Click);
            // 
            // lblSenErrMaiUsrName
            // 
            this.lblSenErrMaiUsrName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSenErrMaiUsrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSenErrMaiUsrName.Location = new System.Drawing.Point(-6, 312);
            this.lblSenErrMaiUsrName.Name = "lblSenErrMaiUsrName";
            this.lblSenErrMaiUsrName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblSenErrMaiUsrName.Size = new System.Drawing.Size(92, 19);
            this.lblSenErrMaiUsrName.TabIndex = 41;
            this.lblSenErrMaiUsrName.Text = "Kullanıcı Adı";
            // 
            // lblSenErrMaiUsrMail
            // 
            this.lblSenErrMaiUsrMail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSenErrMaiUsrMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSenErrMaiUsrMail.Location = new System.Drawing.Point(106, 312);
            this.lblSenErrMaiUsrMail.Name = "lblSenErrMaiUsrMail";
            this.lblSenErrMaiUsrMail.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblSenErrMaiUsrMail.Size = new System.Drawing.Size(92, 19);
            this.lblSenErrMaiUsrMail.TabIndex = 42;
            this.lblSenErrMaiUsrMail.Text = "Mail Adresi";
            // 
            // tbsMail
            // 
            this.tbsMail.BackColor = System.Drawing.Color.Transparent;
            this.tbsMail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbsMail.Controls.Add(this.pnlMailIslemSonuclari);
            this.tbsMail.Controls.Add(this.pnlMailAyarlar);
            this.tbsMail.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbsMail.Location = new System.Drawing.Point(4, 24);
            this.tbsMail.Name = "tbsMail";
            this.tbsMail.Padding = new System.Windows.Forms.Padding(3);
            this.tbsMail.Size = new System.Drawing.Size(1201, 705);
            this.tbsMail.TabIndex = 0;
            this.tbsMail.Text = "Mail ile Alımlar";
            // 
            // pnlMailAyarlar
            // 
            this.pnlMailAyarlar.BackColor = System.Drawing.Color.LightCyan;
            this.pnlMailAyarlar.Controls.Add(this.btnStop);
            this.pnlMailAyarlar.Controls.Add(this.btnRunContinuously);
            this.pnlMailAyarlar.Controls.Add(this.grpGelMaiAdrBil);
            this.pnlMailAyarlar.Controls.Add(this.grpAyrMail);
            this.pnlMailAyarlar.Controls.Add(this.groupBox2);
            this.pnlMailAyarlar.Controls.Add(this.grpGonMaiAdr);
            this.pnlMailAyarlar.Controls.Add(this.btnRunOneTime);
            this.pnlMailAyarlar.Controls.Add(this.label1);
            this.pnlMailAyarlar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMailAyarlar.Location = new System.Drawing.Point(3, 3);
            this.pnlMailAyarlar.Name = "pnlMailAyarlar";
            this.pnlMailAyarlar.Size = new System.Drawing.Size(370, 695);
            this.pnlMailAyarlar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(6, 95);
            this.label1.MaximumSize = new System.Drawing.Size(0, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 2);
            this.label1.TabIndex = 3;
            // 
            // btnRunOneTime
            // 
            this.btnRunOneTime.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRunOneTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRunOneTime.Location = new System.Drawing.Point(3, 664);
            this.btnRunOneTime.Name = "btnRunOneTime";
            this.btnRunOneTime.Size = new System.Drawing.Size(108, 28);
            this.btnRunOneTime.TabIndex = 11;
            this.btnRunOneTime.Text = "Tek Sefer Çalıştır";
            this.btnRunOneTime.UseVisualStyleBackColor = false;
            this.btnRunOneTime.Click += new System.EventHandler(this.btnRunOneTime_Click);
            // 
            // grpGonMaiAdr
            // 
            this.grpGonMaiAdr.Controls.Add(this.btnMailEkle);
            this.grpGonMaiAdr.Controls.Add(this.btnMailCikar);
            this.grpGonMaiAdr.Controls.Add(this.edtGonderenMailAdresi);
            this.grpGonMaiAdr.Controls.Add(this.lblGonMailAdr);
            this.grpGonMaiAdr.Controls.Add(this.lsvGonMailAdr);
            this.grpGonMaiAdr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpGonMaiAdr.Location = new System.Drawing.Point(6, 278);
            this.grpGonMaiAdr.Name = "grpGonMaiAdr";
            this.grpGonMaiAdr.Size = new System.Drawing.Size(358, 380);
            this.grpGonMaiAdr.TabIndex = 17;
            this.grpGonMaiAdr.TabStop = false;
            this.grpGonMaiAdr.Text = "Okuncak Mail Adresleri";
            // 
            // lsvGonMailAdr
            // 
            this.lsvGonMailAdr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lsvGonMailAdrClmMailAdr});
            this.lsvGonMailAdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lsvGonMailAdr.FullRowSelect = true;
            this.lsvGonMailAdr.GridLines = true;
            this.lsvGonMailAdr.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.lsvGonMailAdr.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lsvGonMailAdr.Location = new System.Drawing.Point(5, 20);
            this.lsvGonMailAdr.Name = "lsvGonMailAdr";
            this.lsvGonMailAdr.Size = new System.Drawing.Size(349, 275);
            this.lsvGonMailAdr.TabIndex = 24;
            this.lsvGonMailAdr.UseCompatibleStateImageBehavior = false;
            this.lsvGonMailAdr.View = System.Windows.Forms.View.Details;
            // 
            // lsvGonMailAdrClmMailAdr
            // 
            this.lsvGonMailAdrClmMailAdr.Text = "Mail Adres";
            this.lsvGonMailAdrClmMailAdr.Width = 344;
            // 
            // lblGonMailAdr
            // 
            this.lblGonMailAdr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblGonMailAdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGonMailAdr.Location = new System.Drawing.Point(-3, 301);
            this.lblGonMailAdr.Name = "lblGonMailAdr";
            this.lblGonMailAdr.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblGonMailAdr.Size = new System.Drawing.Size(120, 25);
            this.lblGonMailAdr.TabIndex = 29;
            this.lblGonMailAdr.Text = "Mail Adresi";
            // 
            // edtGonderenMailAdresi
            // 
            this.edtGonderenMailAdresi.Location = new System.Drawing.Point(174, 301);
            this.edtGonderenMailAdresi.Name = "edtGonderenMailAdresi";
            this.edtGonderenMailAdresi.Size = new System.Drawing.Size(180, 21);
            this.edtGonderenMailAdresi.TabIndex = 8;
            // 
            // btnMailCikar
            // 
            this.btnMailCikar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMailCikar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMailCikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMailCikar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMailCikar.Location = new System.Drawing.Point(256, 339);
            this.btnMailCikar.Name = "btnMailCikar";
            this.btnMailCikar.Size = new System.Drawing.Size(46, 25);
            this.btnMailCikar.TabIndex = 27;
            this.btnMailCikar.Text = "Çıkar";
            this.btnMailCikar.UseVisualStyleBackColor = false;
            this.btnMailCikar.Click += new System.EventHandler(this.btnMailCikar_Click);
            // 
            // btnMailEkle
            // 
            this.btnMailEkle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMailEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMailEkle.Location = new System.Drawing.Point(308, 339);
            this.btnMailEkle.Name = "btnMailEkle";
            this.btnMailEkle.Size = new System.Drawing.Size(46, 25);
            this.btnMailEkle.TabIndex = 10;
            this.btnMailEkle.Text = "Ekle";
            this.btnMailEkle.UseVisualStyleBackColor = false;
            this.btnMailEkle.Click += new System.EventHandler(this.btnMailEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.edtGonKulSif);
            this.groupBox2.Controls.Add(this.edtGonKulAdi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 76);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mail Gönderilecek Adres Bilgileri";
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1, 17);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1, 44);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Şifre";
            // 
            // edtGonKulAdi
            // 
            this.edtGonKulAdi.Location = new System.Drawing.Point(175, 17);
            this.edtGonKulAdi.Name = "edtGonKulAdi";
            this.edtGonKulAdi.Size = new System.Drawing.Size(180, 21);
            this.edtGonKulAdi.TabIndex = 4;
            this.edtGonKulAdi.Text = "noreply";
            // 
            // edtGonKulSif
            // 
            this.edtGonKulSif.Location = new System.Drawing.Point(175, 44);
            this.edtGonKulSif.Name = "edtGonKulSif";
            this.edtGonKulSif.Size = new System.Drawing.Size(180, 21);
            this.edtGonKulSif.TabIndex = 5;
            this.edtGonKulSif.Text = "N0r3ply01";
            this.edtGonKulSif.UseSystemPasswordChar = true;
            // 
            // grpAyrMail
            // 
            this.grpAyrMail.Controls.Add(this.edtSunPort);
            this.grpAyrMail.Controls.Add(this.lblPort);
            this.grpAyrMail.Controls.Add(this.edtMailSunucusu);
            this.grpAyrMail.Controls.Add(this.lblMailSuncusu);
            this.grpAyrMail.Controls.Add(this.edtMailUzantısı);
            this.grpAyrMail.Controls.Add(this.lblMailUzantısı);
            this.grpAyrMail.Location = new System.Drawing.Point(6, 3);
            this.grpAyrMail.Name = "grpAyrMail";
            this.grpAyrMail.Size = new System.Drawing.Size(358, 103);
            this.grpAyrMail.TabIndex = 27;
            this.grpAyrMail.TabStop = false;
            this.grpAyrMail.Text = "Sunucu Bilgileri";
            // 
            // lblMailUzantısı
            // 
            this.lblMailUzantısı.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMailUzantısı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMailUzantısı.Location = new System.Drawing.Point(1, 23);
            this.lblMailUzantısı.Name = "lblMailUzantısı";
            this.lblMailUzantısı.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblMailUzantısı.Size = new System.Drawing.Size(120, 21);
            this.lblMailUzantısı.TabIndex = 17;
            this.lblMailUzantısı.Text = "Mail Uzantısı";
            // 
            // edtMailUzantısı
            // 
            this.edtMailUzantısı.Location = new System.Drawing.Point(174, 20);
            this.edtMailUzantısı.Name = "edtMailUzantısı";
            this.edtMailUzantısı.Size = new System.Drawing.Size(180, 21);
            this.edtMailUzantısı.TabIndex = 1;
            this.edtMailUzantısı.Text = "toksozgrup.com.tr";
            // 
            // lblMailSuncusu
            // 
            this.lblMailSuncusu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMailSuncusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMailSuncusu.Location = new System.Drawing.Point(1, 54);
            this.lblMailSuncusu.Name = "lblMailSuncusu";
            this.lblMailSuncusu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblMailSuncusu.Size = new System.Drawing.Size(120, 25);
            this.lblMailSuncusu.TabIndex = 19;
            this.lblMailSuncusu.Text = "Mail Sunucusu";
            // 
            // edtMailSunucusu
            // 
            this.edtMailSunucusu.Location = new System.Drawing.Point(174, 47);
            this.edtMailSunucusu.Name = "edtMailSunucusu";
            this.edtMailSunucusu.Size = new System.Drawing.Size(180, 21);
            this.edtMailSunucusu.TabIndex = 2;
            this.edtMailSunucusu.Text = "172.30.234.50";
            // 
            // lblPort
            // 
            this.lblPort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPort.Location = new System.Drawing.Point(1, 79);
            this.lblPort.Name = "lblPort";
            this.lblPort.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblPort.Size = new System.Drawing.Size(120, 21);
            this.lblPort.TabIndex = 21;
            this.lblPort.Text = "Port";
            // 
            // edtSunPort
            // 
            this.edtSunPort.Location = new System.Drawing.Point(175, 73);
            this.edtSunPort.Name = "edtSunPort";
            this.edtSunPort.Size = new System.Drawing.Size(180, 21);
            this.edtSunPort.TabIndex = 3;
            this.edtSunPort.Text = "587";
            // 
            // grpGelMaiAdrBil
            // 
            this.grpGelMaiAdrBil.Controls.Add(this.lblKullaniciAdi);
            this.grpGelMaiAdrBil.Controls.Add(this.edtGelSifre);
            this.grpGelMaiAdrBil.Controls.Add(this.edtGelKullaniciAdi);
            this.grpGelMaiAdrBil.Controls.Add(this.lblSifre);
            this.grpGelMaiAdrBil.Location = new System.Drawing.Point(6, 188);
            this.grpGelMaiAdrBil.Name = "grpGelMaiAdrBil";
            this.grpGelMaiAdrBil.Size = new System.Drawing.Size(358, 84);
            this.grpGelMaiAdrBil.TabIndex = 28;
            this.grpGelMaiAdrBil.TabStop = false;
            this.grpGelMaiAdrBil.Text = "Mail Adresi Giriş Bilgileri";
            // 
            // lblSifre
            // 
            this.lblSifre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(1, 50);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblSifre.Size = new System.Drawing.Size(120, 18);
            this.lblSifre.TabIndex = 32;
            this.lblSifre.Text = "Şifre";
            // 
            // edtGelKullaniciAdi
            // 
            this.edtGelKullaniciAdi.Location = new System.Drawing.Point(174, 20);
            this.edtGelKullaniciAdi.Name = "edtGelKullaniciAdi";
            this.edtGelKullaniciAdi.Size = new System.Drawing.Size(180, 21);
            this.edtGelKullaniciAdi.TabIndex = 6;
            this.edtGelKullaniciAdi.Text = "esiparis";
            // 
            // edtGelSifre
            // 
            this.edtGelSifre.Location = new System.Drawing.Point(174, 47);
            this.edtGelSifre.Name = "edtGelSifre";
            this.edtGelSifre.Size = new System.Drawing.Size(180, 21);
            this.edtGelSifre.TabIndex = 7;
            this.edtGelSifre.Text = "SipaR.2021";
            this.edtGelSifre.UseSystemPasswordChar = true;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(2, 23);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblKullaniciAdi.Size = new System.Drawing.Size(120, 25);
            this.lblKullaniciAdi.TabIndex = 34;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // btnRunContinuously
            // 
            this.btnRunContinuously.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRunContinuously.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRunContinuously.Location = new System.Drawing.Point(130, 664);
            this.btnRunContinuously.Name = "btnRunContinuously";
            this.btnRunContinuously.Size = new System.Drawing.Size(108, 28);
            this.btnRunContinuously.TabIndex = 29;
            this.btnRunContinuously.Text = "Sürekli Çalıştır";
            this.btnRunContinuously.UseVisualStyleBackColor = false;
            this.btnRunContinuously.Click += new System.EventHandler(this.btnRunContinuously_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Enabled = false;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Location = new System.Drawing.Point(256, 664);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(108, 28);
            this.btnStop.TabIndex = 30;
            this.btnStop.Text = "Durdur";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pnlMailIslemSonuclari
            // 
            this.pnlMailIslemSonuclari.BackColor = System.Drawing.Color.Cornsilk;
            this.pnlMailIslemSonuclari.Controls.Add(this.lsvMailler);
            this.pnlMailIslemSonuclari.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMailIslemSonuclari.Location = new System.Drawing.Point(378, 3);
            this.pnlMailIslemSonuclari.Name = "pnlMailIslemSonuclari";
            this.pnlMailIslemSonuclari.Size = new System.Drawing.Size(816, 695);
            this.pnlMailIslemSonuclari.TabIndex = 1;
            // 
            // lsvMailler
            // 
            this.lsvMailler.BackColor = System.Drawing.SystemColors.Window;
            this.lsvMailler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lsvMaillerClmMsg,
            this.lsvMaillerGon,
            this.lsvMaillerBas,
            this.lsvMaillerDos,
            this.lsvMaillerTar});
            this.lsvMailler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvMailler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lsvMailler.FullRowSelect = true;
            this.lsvMailler.GridLines = true;
            this.lsvMailler.HideSelection = false;
            this.lsvMailler.Location = new System.Drawing.Point(0, 0);
            this.lsvMailler.MultiSelect = false;
            this.lsvMailler.Name = "lsvMailler";
            this.lsvMailler.Size = new System.Drawing.Size(816, 695);
            this.lsvMailler.TabIndex = 0;
            this.lsvMailler.UseCompatibleStateImageBehavior = false;
            this.lsvMailler.View = System.Windows.Forms.View.Details;
            this.lsvMailler.DoubleClick += new System.EventHandler(this.lsvMailler_DoubleClick);
            // 
            // lsvMaillerClmMsg
            // 
            this.lsvMaillerClmMsg.Text = "Msg";
            this.lsvMaillerClmMsg.Width = 154;
            // 
            // lsvMaillerGon
            // 
            this.lsvMaillerGon.Text = "Gönderen";
            this.lsvMaillerGon.Width = 159;
            // 
            // lsvMaillerBas
            // 
            this.lsvMaillerBas.Text = "Başlık";
            this.lsvMaillerBas.Width = 228;
            // 
            // lsvMaillerDos
            // 
            this.lsvMaillerDos.Text = "Dosya";
            this.lsvMaillerDos.Width = 183;
            // 
            // lsvMaillerTar
            // 
            this.lsvMaillerTar.Text = "Tarih";
            this.lsvMaillerTar.Width = 88;
            // 
            // tbsTabs
            // 
            this.tbsTabs.Controls.Add(this.tbsMail);
            this.tbsTabs.Controls.Add(this.tbsAyarlar);
            this.tbsTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbsTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbsTabs.Location = new System.Drawing.Point(3, 16);
            this.tbsTabs.Name = "tbsTabs";
            this.tbsTabs.SelectedIndex = 0;
            this.tbsTabs.Size = new System.Drawing.Size(1209, 733);
            this.tbsTabs.TabIndex = 1;
            // 
            // frmMainViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 905);
            this.Controls.Add(this.grpBxMain);
            this.Controls.Add(this.grpBxButtom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainViewer";
            this.Text = "WMS Online Sipariş Alımı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpBxMain.ResumeLayout(false);
            this.grpBxButtom.ResumeLayout(false);
            this.grpBxButtom.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.tbsAyarlar.ResumeLayout(false);
            this.pnlAyarlar.ResumeLayout(false);
            this.grpBx.ResumeLayout(false);
            this.grpBx.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpSendErrMai.ResumeLayout(false);
            this.grpSendErrMai.PerformLayout();
            this.tbsMail.ResumeLayout(false);
            this.pnlMailAyarlar.ResumeLayout(false);
            this.grpGonMaiAdr.ResumeLayout(false);
            this.grpGonMaiAdr.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpAyrMail.ResumeLayout(false);
            this.grpAyrMail.PerformLayout();
            this.grpGelMaiAdrBil.ResumeLayout(false);
            this.grpGelMaiAdrBil.PerformLayout();
            this.pnlMailIslemSonuclari.ResumeLayout(false);
            this.tbsTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBxMain;
        private System.Windows.Forms.GroupBox grpBxButtom;
        private System.Windows.Forms.ListBox lstDebug;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel StaBarLblStatus;
        private System.Windows.Forms.ToolStripStatusLabel StaBarLblStatus2;
        private System.Windows.Forms.Timer tmrSaat;
        private System.Windows.Forms.Timer tmrKontrol;
        private System.Windows.Forms.ProgressBar prgbLoading;
        private System.Windows.Forms.TabControl tbsTabs;
        private System.Windows.Forms.TabPage tbsMail;
        private System.Windows.Forms.Panel pnlMailIslemSonuclari;
        private System.Windows.Forms.ListView lsvMailler;
        private System.Windows.Forms.ColumnHeader lsvMaillerClmMsg;
        private System.Windows.Forms.ColumnHeader lsvMaillerGon;
        private System.Windows.Forms.ColumnHeader lsvMaillerBas;
        private System.Windows.Forms.ColumnHeader lsvMaillerDos;
        private System.Windows.Forms.ColumnHeader lsvMaillerTar;
        private System.Windows.Forms.Panel pnlMailAyarlar;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRunContinuously;
        private System.Windows.Forms.GroupBox grpGelMaiAdrBil;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox edtGelSifre;
        private System.Windows.Forms.TextBox edtGelKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.GroupBox grpAyrMail;
        private System.Windows.Forms.TextBox edtSunPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox edtMailSunucusu;
        private System.Windows.Forms.Label lblMailSuncusu;
        private System.Windows.Forms.TextBox edtMailUzantısı;
        private System.Windows.Forms.Label lblMailUzantısı;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox edtGonKulSif;
        private System.Windows.Forms.TextBox edtGonKulAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpGonMaiAdr;
        private System.Windows.Forms.Button btnMailEkle;
        private System.Windows.Forms.Button btnMailCikar;
        private System.Windows.Forms.TextBox edtGonderenMailAdresi;
        private System.Windows.Forms.Label lblGonMailAdr;
        private System.Windows.Forms.ListView lsvGonMailAdr;
        private System.Windows.Forms.ColumnHeader lsvGonMailAdrClmMailAdr;
        private System.Windows.Forms.Button btnRunOneTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbsAyarlar;
        private System.Windows.Forms.Panel pnlAyarlar;
        private System.Windows.Forms.GroupBox grpSendErrMai;
        private System.Windows.Forms.Label lblSenErrMaiUsrMail;
        private System.Windows.Forms.Label lblSenErrMaiUsrName;
        private System.Windows.Forms.Button btnlsvSenErrMaiUsrAdd;
        private System.Windows.Forms.Button btnlsvSenErrMaiUsrDelete;
        private System.Windows.Forms.TextBox edtSenErrMaiUsrMail;
        private System.Windows.Forms.TextBox edtSenErrMaiUsrName;
        private System.Windows.Forms.ListView lsvSenErrMaiUsr;
        private System.Windows.Forms.ColumnHeader clmUsrName;
        private System.Windows.Forms.ColumnHeader clmMailAdr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKonSk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtKontrolSikligi;
        private System.Windows.Forms.TextBox edtEpostPort;
        private System.Windows.Forms.Label lblCvpMailGon;
        private System.Windows.Forms.TextBox edtEpostSunucusu;
        private System.Windows.Forms.CheckBox chbCevapMailiGonderilsin;
        private System.Windows.Forms.GroupBox grpBx;
        private System.Windows.Forms.Label lblGelDosKayDiz;
        private System.Windows.Forms.Button btnGelDosKayDiz;
        private System.Windows.Forms.Button btnGidDosKayDiz;
        private System.Windows.Forms.TextBox bedGidDosKayDiz;
        private System.Windows.Forms.Label lblGidDosKayDiz;
        private System.Windows.Forms.TextBox bedGelDosKayDiz;
    }
}

