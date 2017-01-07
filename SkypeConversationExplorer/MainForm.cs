using SCE.BusinessObjects.SkypeMainDB;
using SCE.BusinessObjects.SkypeMainDB.Interfaces;
using SCE.Core;
using SCE.Core.Interfaces;
using SkypeMainDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace SkypeConversationExplorer
{
    public partial class MainForm : Form
    {
        ContactProcessor contactProcessor;
        ISCERepositoryFactory Factory;
        string selectedContact = "";
        List<Messages> messageList;
        List<Contacts> contactList;
        DateTime? dateFrom = null;
        DateTime? dateTo = null;

        public MainForm()
        {
            int i = 0;
            contactProcessor = new ContactProcessor();
            Factory = new SCERepositoryFactory();

            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openMainDbDialog.ShowDialog() == DialogResult.OK)
            {
                File.Copy(openMainDbDialog.FileName, ".\\maintemp.db", true);
                FillContactList();
                tabControl.Enabled = true;
                mainDbPathTextBox.Text = openMainDbDialog.FileName;
            }

        }

        private void FillContactList()
        {
            contactList = contactProcessor.getAllContacts().OrderBy(t => t.displayname).ToList();
            List<string> displayList = new List<string>();
            foreach (Contacts c in contactList)
            {
                displayList.Add(c.displayname + " (" + c.skypename + ")");
            }
            contactBox.DataSource = displayList;
        }

        private void contactBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedContact = contactList[contactBox.SelectedIndex].skypename;
            messageListView.Items.Clear();
            PopulateMessageList();
        }

        private void dateFromCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dateFromPicker.Enabled = dateFromCheckBox.Checked ? true : false;
            if (!dateFromCheckBox.Checked)
            {
                dateFrom = null;
                PopulateMessageList();
            }
        }

        private void dateToCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dateToPicker.Enabled = dateToCheckBox.Checked ? true : false;
            if (!dateToCheckBox.Checked)
            {
                dateTo = null;
                PopulateMessageList();
            }
        }

        private void dateFromPicker_ValueChanged(object sender, EventArgs e)
        {
            dateFrom = dateFromPicker.Value.Date;
            PopulateMessageList();
        }

        private void dateToPicker_ValueChanged(object sender, EventArgs e)
        {
            dateTo = dateToPicker.Value.Date;
            PopulateMessageList();
        }

        private void PopulateMessageList()
        {
            if (dateFrom != null && dateTo != null)
            {
                messageList = Factory.CreateRepository<IMessageRepository>().GetByAccountNameFromTo(selectedContact, dateFrom.Value, dateTo.Value).OrderBy(t => t.timestamp).ToList();
            }
            else if (dateFrom != null)
            {
                messageList = Factory.CreateRepository<IMessageRepository>().GetByAccountNameFrom(selectedContact, dateFrom.Value).OrderBy(t => t.timestamp).ToList();
            }
            else if (dateTo != null)
            {
                messageList = Factory.CreateRepository<IMessageRepository>().GetByAccountNameTo(selectedContact, dateTo.Value).OrderBy(t => t.timestamp).ToList();
            }
            else
            {
                messageList = Factory.CreateRepository<IMessageRepository>().GetByAccountName(selectedContact).OrderBy(t => t.timestamp).ToList();
            }

            messageListView.Items.Clear();

            foreach (Messages message in messageList)
            {
                ListViewItem item = new ListViewItem(Utils.TimestampToDateTime(message.timestamp.Value).ToLocalTime().ToString());
                item.SubItems.Add(message.author);
                item.SubItems.Add(StripHTML(HttpUtility.HtmlDecode(message.body_xml)));

                messageListView.Items.Add(item);
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            ExportDialog dialog = new ExportDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileExtension = dialog.FilePath.Split('.').Last().ToLower();
                switch(fileExtension)
                {
                    case "html":
                        WriteHtml(dialog.FilePath);
                        break;
                    case "pdf":
                        WritePdf(dialog.FilePath);
                        break;
                }
            }
        }
        public static string StripHTML(string input)
        {
            if (input == null) return string.Empty;
            return Regex.Replace(input, "<.*?>", String.Empty);
        }

        private void WriteHtml(string filepath)
        {
            HtmlWriter writer = new HtmlWriter();
            writer.WriteHtml(messageList, filepath);
        }

        private void WritePdf(string filepath)
        {
            PDFMessageWriter writer = new PDFMessageWriter();
            writer.WritePDF(messageList, filepath);
        }
    }
}
