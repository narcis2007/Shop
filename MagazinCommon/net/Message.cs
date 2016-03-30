using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinCommon.net
{
    public class Message
    {
        private string body;

        public Message(string body)
        {
            this.body = body;
        }

        public override string ToString()
        {
            return body;
        }
    }
}
