using System.Collections.Generic;
using CommandService.Models;

namespace CommandService.SyncDataServices.Grpc
{
    public interface IPlatformDataClient
    {
        IEnumerable<Platform> ReturnAllPlatforms();
    }
}