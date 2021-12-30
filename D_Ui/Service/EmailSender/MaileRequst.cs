using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D_Ui.Service.EmailSender
{
    public class MaileRequst
    {
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string ClientEmail { get; set; }
        public string Body { get; set; }
        public List<IFormFile> Attachment { get; set; }
    }
}
