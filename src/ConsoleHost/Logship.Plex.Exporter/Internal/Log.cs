using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logship.Plex.Exporter.ConsoleHost.Internal
{
    internal sealed partial class Log
    {
        [LoggerMessage(LogLevel.Error, "Uncaught Exception")]
        public static partial void UncaughtException(ILogger logger, Exception ex);
    }
}
