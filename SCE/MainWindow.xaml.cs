using Microsoft.Win32;
using SCE.BusinessObjects.SkypeMainDB;
using SCE.BusinessObjects.SkypeMainDB.Interfaces;
using SCE.Core;
using SCE.Core.Interfaces;
using SkypeMainDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SCE
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataTable MessageTable;

        private ContactProcessor contactProcessor;
        private ISCERepositoryFactory Factory;
        private List<Messages> messageList;
        private List<Contacts> contactList;
        private DateTime? FromDate;
        private DateTime? ToDate;
        private string selectedContact;


        public MainWindow()
        {
            MessageTable = new DataTable();
            MessageTable.Columns.Add("Timestamp");
            MessageTable.Columns.Add("Author");
            MessageTable.Columns.Add("Message");

            contactProcessor = new ContactProcessor();
            Factory = new SCERepositoryFactory();

            System.IO.Directory.CreateDirectory(@"c:\temp");

            InitializeComponent();
        }


        private void openDatabase_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "SQLite Database file|*.db";
            if (dialog.ShowDialog() == true)
            {
                File.Copy(dialog.FileName, @"c:\temp\maintemp.db", true);
                FillContactList();
                tabControl_main.IsEnabled = true;
                menuItem_export.IsEnabled = true;
            }
        }

        private void export_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "HTML file|*.html|PDF document|*.pdf";
            if(dialog.ShowDialog() == true)
            {
                string fileExtension = dialog.FileName.Split('.').Last().ToLower();
                switch (fileExtension)
                {
                    case "html":
                        WriteHtml(dialog.FileName);
                        break;
                    case "pdf":
                        WritePdf(dialog.FileName);
                        break;
                }
            }
        }

        private void WritePdf(string filename)
        {
            PDFMessageWriter writer = new PDFMessageWriter();
            writer.WritePDF(messageList, filename);
        }

        private void WriteHtml(string filename)
        {
            HtmlWriter writer = new HtmlWriter();
            writer.WriteHtml(messageList, filename);
        }

        private void FillContactList()
        {
            contactList = contactProcessor.getAllContacts().OrderBy(t => t.displayname).ToList();
            foreach (Contacts c in contactList)
            {
                comboBox_contacts.Items.Add(c.displayname + " (" + c.skypename + ")");
            }
            comboBox_contacts.SelectedIndex = 0;
        }

        private void populateMessageTable(string contact)
        {
            MessageTable.Rows.Clear();
            if (FromDate != null && ToDate != null)
            {
                messageList = Factory.CreateRepository<IMessageRepository>().GetByAccountNameFromTo(contact, FromDate.Value, ToDate.Value).OrderBy(t => t.timestamp).ToList();
            }
            else if (FromDate != null)
            {
                messageList = Factory.CreateRepository<IMessageRepository>().GetByAccountNameFrom(contact, FromDate.Value).OrderBy(t => t.timestamp).ToList();
            }
            else if (ToDate != null)
            {
                messageList = Factory.CreateRepository<IMessageRepository>().GetByAccountNameTo(contact, ToDate.Value).OrderBy(t => t.timestamp).ToList();
            }
            else
            {
                messageList = Factory.CreateRepository<IMessageRepository>().GetByAccountName(contact).OrderBy(t => t.timestamp).ToList();
            }

            foreach (Messages m in messageList)
            {
                var row = MessageTable.NewRow();
                row["Timestamp"] = Utils.TimestampToDateTime(m.timestamp.Value).ToLocalTime().ToString();
                row["Author"] = m.author;
                row["Message"] = m.body_xml;

                MessageTable.Rows.Add(row);
            }
            MessageTable.AcceptChanges();

            dataGrid_messages.AutoGenerateColumns = true;
            dataGrid_messages.DataContext = MessageTable.DefaultView;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            bool ischecked = (bool)checkBox_date_from.IsChecked;
            datePicker_from.IsEnabled = ischecked;

            if (!ischecked)
                FromDate = null;
            else
                FromDate = datePicker_from.SelectedDate;

            populateMessageTable(selectedContact);
        }

        private void checkBox_date_to_Checked(object sender, RoutedEventArgs e)
        {
            bool ischecked = (bool)checkBox_date_to.IsChecked;
            datePicker_to.IsEnabled = ischecked;

            if (!ischecked)
                ToDate = null;
            else
                ToDate = datePicker_to.SelectedDate;

            populateMessageTable(selectedContact);
        }

        private void comboBox_contacts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = comboBox_contacts.SelectedIndex;
            selectedContact = contactList[index].skypename;
            populateMessageTable(selectedContact);
        }

        private void datePicker_from_selected_date_changed(object sender, SelectionChangedEventArgs e)
        {
            FromDate = datePicker_from.SelectedDate;
            populateMessageTable(selectedContact);
        }

        private void datePicker_to_selected_date_changed(object sender, SelectionChangedEventArgs e)
        {
            ToDate = datePicker_to.SelectedDate;
            populateMessageTable(selectedContact);
        }
    }
}
