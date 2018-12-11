using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek.Models
{
    public class SmsManager:INotificator
    {
       
        public MessageStates MessageStates { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Send(MessageBase message)
        {
            try
            {
                SmsMessage sms = message as SmsMessage;

                MessageStates = MessageStates.Sent;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
