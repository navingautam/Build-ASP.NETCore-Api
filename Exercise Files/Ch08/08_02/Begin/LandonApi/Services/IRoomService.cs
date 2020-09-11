using LandonApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LandonApi.Services
{
    public interface IRoomService
    {
        Task<PagedResults<Room>> GetRoomsAsync(PagingOptions pagingOptions);

        Task<Room> GetRoomAsync(Guid id);
    }
}
