using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek.Models
{
    public class EmailManager : INotificator
    {
        public MessageStates MessageStates { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public MessageStates MessageState { get; private set; }

        public void Send(MessageBase message)
        {
            MessageState = MessageStates.Pending;
            try
            {
                SmsMessage sms = message as SmsMessage;

                MessageState = MessageStates.Sent;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
