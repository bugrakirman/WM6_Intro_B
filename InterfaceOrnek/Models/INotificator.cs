using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek.Models
{
    public interface INotificator
    {
        MessageStates MessageStates { get; set; }
        void Send(MessageBase message);

    }
}
