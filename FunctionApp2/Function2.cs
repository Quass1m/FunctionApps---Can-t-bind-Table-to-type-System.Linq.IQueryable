using Microsoft.Azure.WebJobs;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.Azure.WebJobs.Host;
using System.Linq;

namespace FunctionApp2
{
    [StorageAccount("AzureWebJobsStorage")]
    public static class Function2
    {
        [FunctionName("Function2")]
        public static void Run([TimerTrigger("*/10 * * * * *")]TimerInfo myTimer, [Table("uniqueeventparserfunctionold")]IQueryable<TableEntity> readTable, TraceWriter log)
        {
            log.Info("C# function processed a request.");
        }
    }
}
