using ActiveUp.Net.Mail;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ImapLibrary
{
    public class MailRepository : IDisposable
    {

        private Imap4Client _client = null;

        protected Imap4Client Client
        {
            get
            {
                if (_client == null)
                    _client = new Imap4Client();
                return _client;
            }
        }

        /// <summary>
        /// Bağlantı kurulu mu
        /// </summary>
        /// <returns>Bağlantı başarılı ise true</returns>
        public bool Connected()
        {
            return Client.IsConnected;
        }

        /// <summary>
        /// Mail adresine bağlan
        /// </summary>
        /// <param name="sMailServer">Mail server</param>
        /// <param name="iPort">Port</param>
        /// <param name="bSsl">SSL</param>
        /// <param name="sLoginName">eMail</param>
        /// <param name="sPassword">Şifre</param>
        public void Connect(string sMailServer, int iPort, bool bSsl, string sLoginName, string sPassword)
        {
            if (bSsl)
                Client.ConnectSsl(sMailServer, iPort);
            else
                Client.Connect(sMailServer, iPort);

            Client.Login(sLoginName, sPassword);
        }

        /// <summary>
        /// Bağlantıyı kapat
        /// </summary>
        public void Disconnect()
        {
            Client.Disconnect();
        }

        /// <summary>
        /// Verilen klasör de tüm mailleri geitr
        /// </summary>
        /// <param name="mailBox">Klasör ismi</param>
        /// <returns></returns>
        public IEnumerable<Message> GetAllMails(string mailBox)
        {
            return GetMails(mailBox, "ALL").Cast<Message>();
        }

        /// <summary>
        /// İlgili klasördeki mailleri ara ve getir
        /// </summary>
        /// <param name="sMailBox">Klasör ismi</param>
        /// <param name="sSearcPhrases">Aranacak kelime</param>
        /// <returns></returns>
        public MessageCollection GetMails(string sMailBox, string sSearcPhrases)
        {
            var mails = Client.SelectMailbox(sMailBox);

            MessageCollection messages = mails.SearchParse(sSearcPhrases);
            return messages;
        }


        /// <summary>
        /// Mail serverde ilgili klasör var mı
        /// </summary>
        /// <param name="sMailboxName">Klasör ismi</param>
        /// <returns></returns>
        public bool HaveMailBox(string sMailboxName)
        {
            bool Result = false;
            MailboxCollection AllMailBoxes = Client.AllMailboxes;
            foreach (Mailbox mailBox in AllMailBoxes)
            {
                if (mailBox.Name.ToLower().Equals(sMailboxName.ToLower()))
                {
                    Result = true;
                    break;
                }
            }
            return Result;
        }
        /// <summary>
        /// Mail serverda yeni bir klasör oluştur
        /// </summary>
        /// <param name="sMailboxName">Klasör ismi</param>
        public void CreateMailBox(string sMailboxName)
        {
            Client.CreateMailbox(sMailboxName);
        }

        /// <summary>
        /// İlgili maili başka bir klasöre taşı
        /// </summary>
        /// <param name="sMailSubject">Taşınacak mail başlığı</param>
        /// <param name="sMailbox">Mailin olduğu klasör</param>
        /// <param name="sDestinationBoxName">Mailin taşınacağı klasör</param>
        public void MoveMessage(string sMailSubject, string sMailbox, string sDestinationBoxName)
        {
            Mailbox inbox = Client.SelectMailbox(sMailbox);

            Fetch fetch = inbox.Fetch;
            Header header;

            int index = 0;
            int messageCount = inbox.MessageCount;
            for (int i = 1; i <= messageCount; i++)
            {
                header = fetch.HeaderObject(i);
                if (header.Subject.Equals(sMailSubject))
                {
                    index = i;
                    break;
                }
            }
            if (index > 0)
                inbox.MoveMessage(index, sDestinationBoxName);
        }

        private bool disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    //dispose managed resources
                }
            }
            //dispose unmanaged resources
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}
