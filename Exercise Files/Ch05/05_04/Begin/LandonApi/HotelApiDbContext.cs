using System;
using Microsoft.EntityFrameworkCore;

namespace LandonApi
{
    public class HotelApiDbContext: DbContext
    {
        public HotelApiDbContext(DbContextOptions options)
            :base(options)
        {
            public DbSet<RoomEntity> Roons { get; set; }
        }
    }
}
