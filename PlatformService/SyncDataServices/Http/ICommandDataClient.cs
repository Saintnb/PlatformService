using System.Threading.Tasks;
using PlatformService.DTOs;

namespace PlatformService.SyncDataServices.Http
{

    public interface ICommandDataClient
    {

        Task SendPlatformtoCommand(PlatformReadDTO plat);

    }
}