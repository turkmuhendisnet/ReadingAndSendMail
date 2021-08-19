
namespace ReadingAndSendMail
{
    partial class frmMailViewer
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
            this.lblMailCap = new System.Windows.Forms.Label();
            this.txtMailCap = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtAttachmentName = new System.Windows.Forms.TextBox();
            this.lblAttachmentName = new System.Windows.Forms.Label();
            this.lblAttachmentFile = new System.Windows.Forms.Label();
            this.lblMailDate = new System.Windows.Forms.Label();
            this.dtpMailDate = new System.Windows.Forms.DateTimePicker();
            this.wbMessageText = new System.Windows.Forms.WebBrowser();
            this.lblMessageTxt = new System.Windows.Forms.Label();
            this.wbAttchFileCon = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // lblMailCap
            // 
            this.lblMailCap.AutoSize = true;
            this.lblMailCap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMailCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMailCap.Location = new System.Drawing.Point(-1, 16);
            this.lblMailCap.Name = "lblMailCap";
            this.lblMailCap.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblMailCap.Size = new System.Drawing.Size(50, 15);
            this.lblMailCap.TabIndex = 4;
            this.lblMailCap.Text = "Başlık";
            // 
            // txtMailCap
            // 
            this.txtMailCap.Location = new System.Drawing.Point(159, 11);
            this.txtMailCap.Name = "txtMailCap";
            this.txtMailCap.ReadOnly = true;
            this.txtMailCap.Size = new System.Drawing.Size(598, 20);
            this.txtMailCap.TabIndex = 5;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFrom.Location = new System.Drawing.Point(-1, 49);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblFrom.Size = new System.Drawing.Size(72, 15);
            this.lblFrom.TabIndex = 6;
            this.lblFrom.Text = "Gönderen";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(159, 44);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.ReadOnly = true;
            this.txtFrom.Size = new System.Drawing.Size(286, 20);
            this.txtFrom.TabIndex = 7;
            // 
            // txtAttachmentName
            // 
            this.txtAttachmentName.Location = new System.Drawing.Point(159, 83);
            this.txtAttachmentName.Name = "txtAttachmentName";
            this.txtAttachmentName.ReadOnly = true;
            this.txtAttachmentName.Size = new System.Drawing.Size(286, 20);
            this.txtAttachmentName.TabIndex = 9;
            // 
            // lblAttachmentName
            // 
            this.lblAttachmentName.AutoSize = true;
            this.lblAttachmentName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAttachmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAttachmentName.Location = new System.Drawing.Point(-1, 88);
            this.lblAttachmentName.Name = "lblAttachmentName";
            this.lblAttachmentName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblAttachmentName.Size = new System.Drawing.Size(71, 15);
            this.lblAttachmentName.TabIndex = 8;
            this.lblAttachmentName.Text = "Dosya Adı";
            // 
            // lblAttachmentFile
            // 
            this.lblAttachmentFile.AutoSize = true;
            this.lblAttachmentFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAttachmentFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAttachmentFile.Location = new System.Drawing.Point(-1, 415);
            this.lblAttachmentFile.Name = "lblAttachmentFile";
            this.lblAttachmentFile.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblAttachmentFile.Size = new System.Drawing.Size(160, 17);
            this.lblAttachmentFile.TabIndex = 11;
            this.lblAttachmentFile.Text = "Gelen Dosya İçeriği";
            // 
            // lblMailDate
            // 
            this.lblMailDate.AutoSize = true;
            this.lblMailDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMailDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMailDate.Location = new System.Drawing.Point(469, 49);
            this.lblMailDate.Name = "lblMailDate";
            this.lblMailDate.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblMailDate.Size = new System.Drawing.Size(45, 15);
            this.lblMailDate.TabIndex = 12;
            this.lblMailDate.Text = "Tarih";
            // 
            // dtpMailDate
            // 
            this.dtpMailDate.Enabled = false;
            this.dtpMailDate.Location = new System.Drawing.Point(557, 44);
            this.dtpMailDate.Name = "dtpMailDate";
            this.dtpMailDate.Size = new System.Drawing.Size(200, 20);
            this.dtpMailDate.TabIndex = 14;
            // 
            // wbMessageText
            // 
            this.wbMessageText.Location = new System.Drawing.Point(12, 142);
            this.wbMessageText.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMessageText.Name = "wbMessageText";
            this.wbMessageText.Size = new System.Drawing.Size(758, 259);
            this.wbMessageText.TabIndex = 15;
            // 
            // lblMessageTxt
            // 
            this.lblMessageTxt.AutoSize = true;
            this.lblMessageTxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMessageTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMessageTxt.Location = new System.Drawing.Point(-1, 124);
            this.lblMessageTxt.Name = "lblMessageTxt";
            this.lblMessageTxt.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblMessageTxt.Size = new System.Drawing.Size(60, 17);
            this.lblMessageTxt.TabIndex = 16;
            this.lblMessageTxt.Text = "Mesaj";
            // 
            // wbAttchFileCon
            // 
            this.wbAttchFileCon.Location = new System.Drawing.Point(12, 433);
            this.wbAttchFileCon.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbAttchFileCon.Name = "wbAttchFileCon";
            this.wbAttchFileCon.Size = new System.Drawing.Size(758, 372);
            this.wbAttchFileCon.TabIndex = 17;
            // 
            // frmMailViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(784, 817);
            this.Controls.Add(this.wbAttchFileCon);
            this.Controls.Add(this.lblMessageTxt);
            this.Controls.Add(this.wbMessageText);
            this.Controls.Add(this.dtpMailDate);
            this.Controls.Add(this.lblMailDate);
            this.Controls.Add(this.lblAttachmentFile);
            this.Controls.Add(this.txtAttachmentName);
            this.Controls.Add(this.lblAttachmentName);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblMailCap);
            this.Controls.Add(this.txtMailCap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMailViewer";
            this.Text = "Mail Görüntüleyici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMailCap;
        private System.Windows.Forms.TextBox txtMailCap;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtAttachmentName;
        private System.Windows.Forms.Label lblAttachmentName;
        private System.Windows.Forms.Label lblAttachmentFile;
        private System.Windows.Forms.Label lblMailDate;
        private System.Windows.Forms.DateTimePicker dtpMailDate;
        private System.Windows.Forms.WebBrowser wbMessageText;
        private System.Windows.Forms.Label lblMessageTxt;
        private System.Windows.Forms.WebBrowser wbAttchFileCon;
    }
}