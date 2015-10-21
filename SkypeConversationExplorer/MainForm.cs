using BusinessLogic;
using BusinessLogic.Interfaces;
using SkypeMainDB;
using SkypeMainDB.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkypeConversationExplorer
{
    public partial class MainForm : Form
    {
        ContactProcessor contactProcessor;
        ISCERepositoryFactory Factory;
        string selectedContact = "";
        List<Messages> messageList;
        DateTime? dateFrom = null;
        DateTime? dateTo = null;

        public MainForm()
        {
            contactProcessor = new ContactProcessor();
            Factory = new SCERepositoryFactory();

            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

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
                ListViewItem item = new ListViewItem(Utils.TimestampToDateTime(message.timestamp.Value).ToString());
                item.SubItems.Add(message.author);
                item.SubItems.Add(message.body_xml);

                messageListView.Items.Add(item);
            }

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
            contactBox.DataSource = contactProcessor.getAllContacts().Select(t => t.skypename).ToList();
        }

        private void contactBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedContact = contactBox.SelectedItem.ToString();
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
    }
}
