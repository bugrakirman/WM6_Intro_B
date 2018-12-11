using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek.Models
{
    public abstract class MessageBase
    {
        protected MessageBase()
        {
            this.MessageDate = DateTime.Now;  //old school
        }
        public virtual string Sender { get; set; }
        public virtual string Body { get; set; }

        public DateTime MessageDate { get; private set; } // = DateTime=Now; yeni yöntem
    }
}
