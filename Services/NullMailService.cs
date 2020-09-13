using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutchTreat.Services
{
    public class NullMailService : IMailService
    {
        private readonly ILogger<NullMailService> _logger;
       // public ILogger<NullMailService> LoggerPropInjection { get; set; }

        public NullMailService(ILogger<NullMailService> logger)
        {
            _logger = logger;
            //LoggerPropInjection = NullLogger<NullMailService>.Instance;
        }
        public void SendMessage(string to, string subject, string body)
        {
            //Log message
            _logger.LogInformation($"To: {to} Subject: {subject} Body: {body}");
            //LoggerPropInjection.LogInformation("Logged using property set by DI container");
        }
    }
}
