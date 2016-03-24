using Microsoft.Extensions.OptionsModel;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace Mongo.Connector.Repository
{
    public class ApplicationLoggerConnector : ILoggerProvider
    {
        readonly Func<string, LogLevel, bool> _filter;
        readonly IServiceProvider _serviceProvider;
        readonly ILogRepository _logRepository;

        public ApplicationLoggerConnector(IServiceProvider serviceProvider, Func<string, LogLevel, bool> filter, ILogRepository sampleRepository)
        {
            _filter = filter;
            _serviceProvider = serviceProvider;
            _logRepository = sampleRepository;
        }

        public ILogger CreateLogger(string name)
        {
            return new ApplicationLogger(name, _filter, _serviceProvider,_logRepository);
        }

        public void Dispose() { }
    }
}
