using System.Data;
using System.Text.Json;

namespace DependencyInjection;

class DependencyInjection
{
    static void Main(string[] args)
    {
       ILogger logger = new Logger();
       OrderProcessor op = new OrderProcessor(logger);
       op.ProccessOrder("MX3");
    }
}
