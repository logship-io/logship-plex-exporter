using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logship.Plex.Utility.Internal
{
    internal sealed partial class Log
    {
        [LoggerMessage(LogLevel.Error, "Uncaught Exception in IntervalService")]
        public static partial void UncaughtServiceException(ILogger logger, Exception ex);
    }
}
