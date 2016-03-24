using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mongo.Connector.Repository
{
    public class ApplicationLoggerOptions
    {
        public Dictionary<string, LogLevel> Filters { get; set; }
    }
}
