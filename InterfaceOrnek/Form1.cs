using InterfaceOrnek.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (cmbMetod.SelectedIndex < 0) return;

            INotificator notify;
            switch (cmbMetod.SelectedIndex)
            {
                case 0: //sms
                    notify = new SmsManager();
                    MessageBase message = new SmsMessage()
                    {
                        Body="sms body",
                        Sender="sms sender"
                    };
                    notify.Send(message);
                    if(notify.MessageStates == MessageStates.Sent)
                        MessageBox.Show("sms gönderildi");
                    break;
                case 1: //email
                    notify = new EmailManager();
                    break;
                case 2: //
                    
                    break;
                default:
                    break;
            }
        }
    }
}
