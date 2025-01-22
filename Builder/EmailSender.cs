using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class EmailSender
    {
        public string? Sender { get; set; }
        public string? Recipient { get; set; }
        public string? Subject { get; set; }

        public string? Body { get; set; }
    }
}
