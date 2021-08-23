# ReadingAndSendMail
  It reads the mails in the mailbox. Displays the mails in the mailbox. The mail will send a confirmation mail to the received address.

## Mailler
### Tek Sefer Çalıştır
  The Tek Sefer Çalışıtr button connects to the e-mail address, reads the e-mails from the e-mail addresses in the Okunacak Mail Adresleri list and displays them in the list on the right.
  
### Sürekli Çalışıtr
  The Sürekli Çalışıtr button checks the mails coming from the Okunacak Mail Adresleri list to your mailbox during the Kontrol Sıklığı period in the Ayarlar tabshet and displays them in the listwiv on the right.
  
### Durdur
  Program to stop mail checking in Sürekli Çalışıtr mode.
  
![Main View](https://github.com/turkmuhendisnet/ReadingAndSendMail/blob/master/ReadingAndSendMail/ReadingAndSendMailMainView.PNG)

## Ayarlar
### Gelen Dosyaların Kaydedileceği Dizin
  Directory where incoming mail attachments are saved
  
### Giden Dosyaların Kaydedileceği Dizin
  Directory where Outgoing Mail attachments are saved
  
### Program Hatalarının Kaydedileceği Dizin
  The directory where the text file of the program errors is saved.

### Kontrol Sıklığı
  How often the program runs in Sürekli Çalışıtr state.

### Hata Maili Gönderilecek Kullanıcılar
  The e-mail addresses of the users to whom an e-mail will be sent when an error occurs in the program.

![Settings View](https://github.com/turkmuhendisnet/ReadingAndSendMail/blob/master/ReadingAndSendMail/ReadingAndSendMailSettingsView.PNG)


### Mail Görüntüleyici
![Mail View](https://github.com/turkmuhendisnet/ReadingAndSendMail/blob/master/ReadingAndSendMail/ReadingAndSendMailMailView.PNG)


## Used Technologies
- .NET Framework 4.8 
- C#
- MailSystem.Net-trunk

