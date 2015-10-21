using BusinessLogic;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkypeConversationExplorer
{
    public partial class MainForm : Form
    {
        ContactProcessor contactProcessor;
        MessageProcessor messageProcessor;
        string selectedContact = "";
        List<Messages> messageList;

        public MainForm()
        {
            contactProcessor = new ContactProcessor();
            messageProcessor = new MessageProcessor();

            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void PopulateMessageList()
        {
            messageProcessor.retrieveMessages(selectedContact);
            messageList = messageProcessor.Messages.ToList();
            int i = 1;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (openMainDbDialog.ShowDialog() == DialogResult.OK)
            {
                File.Copy(openMainDbDialog.FileName, ".\\maintemp.db", true);
                FillContactList();
            }
            
        }

        private void FillContactList()
        {
            contactBox.DataSource = contactProcessor.getAllContacts().Select(t => t.skypename).ToList();
        }

        private void contactBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedContact = contactBox.SelectedItem.ToString();
            PopulateMessageList();
        }

        private void dateFromCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dateFromPicker.Enabled = dateFromCheckBox.Checked ? true : false;
        }

        private void dateToCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dateToPicker.Enabled = dateToCheckBox.Checked ? true : false;
        }
    }
}
